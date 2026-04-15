using InspectorsGadget.forms;
using InspectorsGadget.helpers;
using InspectorsGadget.models;
using System;
using System.Threading.Channels;
using System.IO;

namespace InspectorsGadget
{
    public partial class MainForm : Form
    {
        // Tracks the active file so Save, Save As, and Load all stay in sync.
        // Defaults to the original fixed path so existing data is found on startup.

        // ── Constructor now receives the path chosen on the startup screen ────
        public MainForm(string filePath)
        {
            InitializeComponent();
            InspectionManager.CurrentFilePath = filePath;
            RefreshDashboard();
        }

        // Loads from CurrentFilePath (if it exists) then rebuilds all dashboard controls.
        private void RefreshDashboard()
        {
            try
            {
                // Load data from file
               
                InspectionManager.LoadFromFile(InspectionManager.CurrentFilePath);

                // Calculate metrics
                decimal totalCost = InspectionManager.GetTotalRepairCost();
                double avgRisk = InspectionManager.GetPropertyRiskScore();
                int itemCount = InspectionManager.Items.Count;
                int criticalCount = InspectionManager.GetCriticalItems().Count;

                // Update metric labels
                lblTotalRepairCost.Text = $"${totalCost:F2}";
                lblAvgRiskScore.Text = $"{avgRisk:F1} / 10";
                lblItemsInspected.Text = itemCount.ToString();
                lblCriticalIssues.Text = criticalCount.ToString();

                // Populate grid
                dgvInspectionItems.Rows.Clear();
                foreach (var item in InspectionManager.GetSortedByRisk())
                {
                    dgvInspectionItems.Rows.Add(
                        item.ItemName,
                        item.GetType().Name.Replace("Item", ""),
                        $"{item.RiskLevel}/10",
                        $"${item.RepairCost:F2}"
                    );
                }

                // Reflect the active filename in the window title bar.
                UpdateTitleBar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Updates the form title to show the name of the currently active file.
        private void UpdateTitleBar()
        {
            string fileName = Path.GetFileNameWithoutExtension(InspectionManager.CurrentFilePath);
            this.Text = $"InspectorsGadget — {fileName} | Inspector: {InspectionManager.InspectorName}";
        }

        // doesnt do anything yet but we want to have it there for when we implement the dashboard view with charts and graphs and stuff, so we can just switch to that view when the button is clicked
        // but right now all the other forms are just popup dialogs that you can open from the dashboard, so we want to keep it simple for now and just have the dashboard be the main view with the grid and metrics,
        // and then we can add more features to it later on when we have more time
        private void BtnDashboard_Click(object sender, EventArgs e) { }

        private void BtnAddInspection_Click(object sender, EventArgs e)
        {
            var addForm = new AddItemForm(InspectionManager.CurrentFilePath);
            if (addForm.ShowDialog(this) == DialogResult.OK)
            {
                RefreshDashboard();
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            // Guard: require a selected row.
            if (dgvInspectionItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Column 0 holds ItemName — matches how rows are built in RefreshDashboard.
            string selectedName = dgvInspectionItems.SelectedRows[0].Cells[0].Value?.ToString();
            var itemToEdit = InspectionManager.Items.FirstOrDefault(i => i.ItemName == selectedName);

            if (itemToEdit == null)
            {
                MessageBox.Show("Selected item not found in the data list.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // CriticalItems are decorator wrappers — direct editing isn't supported.
            if (itemToEdit is CriticalItem)
            {
                MessageBox.Show("Critical items cannot be edited directly. \nDelete and re - add the item if changes are needed.", "Cannot Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var editForm = new EditItemForm(itemToEdit, InspectionManager.CurrentFilePath);
            if (editForm.ShowDialog(this) == DialogResult.OK)
            {
                RefreshDashboard();
            }

        }

        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the grid
            if (dgvInspectionItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Column 0 holds ItemName - matches how rows are added in RefreshDashboard
            string selectedName = dgvInspectionItems.SelectedRows[0].Cells[0].Value?.ToString();

            // Find the actual object in the InspectionManager.Items list that matches the selected name
            var itemToRemove = InspectionManager.Items.FirstOrDefault(i => i.ItemName == selectedName);
            if (itemToRemove == null)
            {
                MessageBox.Show("Selected item not found in the data list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show($"Are you sure you want to delete '{selectedName}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                InspectionManager.RemoveItem(itemToRemove);
                InspectionManager.SaveToFile(InspectionManager.CurrentFilePath);
                RefreshDashboard();
            }
        }

        private void BtnViewReport_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportForm();
            reportForm.ShowDialog(this);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            // TODO: Open SettingsForm dialog
            MessageBox.Show("Settings form not yet implemented", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ─── File: Browse & Load ──────────────────────────────────────────────
        // Opens an OpenFileDialog so the user can pick any previously saved report.
        // The loaded file becomes the active file for subsequent saves.
        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog
            {
                Title = "Open Inspection Report",
                Filter = "Inspection Reports (*.csv)|*.csv|All Files (*.*)|*.*",
                DefaultExt = "csv",
                InitialDirectory = Path.GetDirectoryName(Path.GetFullPath(InspectionManager.CurrentFilePath))
                                   ?? AppDomain.CurrentDomain.BaseDirectory
            };

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    // Update the path first — RefreshDashboard reads CurrentFilePath.
                    InspectionManager.CurrentFilePath = dlg.FileName;
                    RefreshDashboard();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading file: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ─── File: Save ───────────────────────────────────────────────────────
        // Saves to whatever file is currently active (defaulting to inspections.csv).
        // After the user has done a Save As, subsequent saves go to the new path.
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                InspectionManager.SaveToFile(InspectionManager.CurrentFilePath);
                MessageBox.Show(
                    $"Data saved to:\n{Path.GetFullPath(InspectionManager.CurrentFilePath)}",
                    "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // ─── File: Save As ────────────────────────────────────────────────────
        // Opens a SaveFileDialog so the user can name the report and choose a location.
        // The chosen path becomes the new active file for subsequent saves.
        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            using var dlg = new SaveFileDialog
            {
                Title = "Save Inspection Report As",
                Filter = "Inspection Reports (*.csv)|*.csv|All Files (*.*)|*.*",
                DefaultExt = "csv",
                // Suggest a timestamped filename so reports don't accidentally overwrite each other.
                FileName = $"inspection_{DateTime.Now:yyyyMMdd-HHmm}",
                // Start the dialog in the folder where the current file lives (or app folder).
                InitialDirectory = Path.GetDirectoryName(Path.GetFullPath(InspectionManager.CurrentFilePath))
                                   ?? AppDomain.CurrentDomain.BaseDirectory
            };

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    InspectionManager.CurrentFilePath = dlg.FileName;
                    InspectionManager.SaveToFile(InspectionManager.CurrentFilePath);
                    UpdateTitleBar();
                    MessageBox.Show(
                        $"Report saved to:\n{InspectionManager.CurrentFilePath}",
                        "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

