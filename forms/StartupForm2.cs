using InspectorsGadget.helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InspectorsGadget
{
    // Built entirely in code — no Designer.cs required.
    public class StartupForm2 : Form
    {
        // ── Public results read by Program.cs after OK ────────────────────────
        public string SelectedFilePath { get; private set; } = string.Empty;

        // ── Controls ──────────────────────────────────────────────────────────
        // Header
        private readonly Panel _headerPanel = new();
        private readonly Label _headerTitle = new();
        private readonly Label _headerSub = new();

        // Phase 1 — choice
        private readonly Panel _choicePanel = new();
        private readonly Label _choiceLabel = new();
        private readonly Button _btnNew = new();
        private readonly Button _btnLoad = new();
        private readonly Label _errorLabel = new();

        // Phase 2 — new report inputs
        private readonly Panel _newPanel = new();
        private readonly Label _lblNewTitle = new();
        private readonly Label _lblFile = new();
        private readonly TextBox _txtFile = new();
        private readonly Button _btnBrowse = new();
        private readonly Label _lblInspector = new();
        private readonly TextBox _txtInspector = new();
        private readonly Button _btnBack = new();
        private readonly Button _btnStart = new();

        // ── Constructor ───────────────────────────────────────────────────────
        public StartupForm2()
        {
            SuspendLayout();
            BuildForm();
            BuildHeader();
            BuildChoicePanel();
            BuildNewPanel();

            Controls.AddRange(new Control[] { _headerPanel, _choicePanel, _newPanel });
            ResumeLayout(false);
        }

        // ── Layout helpers ────────────────────────────────────────────────────
        private void BuildForm()
        {
            Text = "InspectorsGadget";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(520, 420);
            BackColor = Color.FromArgb(249, 248, 245);
            Font = new Font("Segoe UI", 9F);
        }

        private void BuildHeader()
        {
            _headerPanel.Dock = DockStyle.Top;
            _headerPanel.Height = 88;
            _headerPanel.BackColor = Color.FromArgb(0, 105, 111);

            _headerTitle.Text = "InspectorsGadget";
            _headerTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            _headerTitle.ForeColor = Color.White;
            _headerTitle.AutoSize = true;
            _headerTitle.Location = new Point(24, 14);

            _headerSub.Text = "Property Inspection Management";
            _headerSub.Font = new Font("Segoe UI", 10F);
            _headerSub.ForeColor = Color.FromArgb(180, 220, 222);
            _headerSub.AutoSize = true;
            _headerSub.Location = new Point(26, 52);

            _headerPanel.Controls.AddRange(new Control[] { _headerTitle, _headerSub });
        }

        private void BuildChoicePanel()
        {
            _choicePanel.Location = new Point(0, 88);
            _choicePanel.Size = new Size(520, 332);
            _choicePanel.BackColor = Color.Transparent;

            _choiceLabel.Text = "How would you like to proceed?";
            _choiceLabel.Font = new Font("Segoe UI", 11F);
            _choiceLabel.ForeColor = Color.FromArgb(40, 37, 29);
            _choiceLabel.AutoSize = true;
            _choiceLabel.Location = new Point(24, 32);

            // ── New Report card ──
            _btnNew.Text = "+ New Inspection\nReport";
            _btnNew.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            _btnNew.Size = new Size(220, 120);
            _btnNew.Location = new Point(24, 80);
            _btnNew.FlatStyle = FlatStyle.Flat;
            _btnNew.BackColor = Color.FromArgb(0, 105, 111);
            _btnNew.ForeColor = Color.White;
            _btnNew.Cursor = Cursors.Hand;
            _btnNew.FlatAppearance.BorderSize = 0;
            _btnNew.Click += BtnNew_Click;

            // ── Load Report card ──
            _btnLoad.Text = "Open Existing\nReport";
            _btnLoad.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            _btnLoad.Size = new Size(220, 120);
            _btnLoad.Location = new Point(276, 80);
            _btnLoad.FlatStyle = FlatStyle.Flat;
            _btnLoad.BackColor = Color.White;
            _btnLoad.ForeColor = Color.FromArgb(0, 105, 111);
            _btnLoad.Cursor = Cursors.Hand;
            _btnLoad.FlatAppearance.BorderColor = Color.FromArgb(0, 105, 111);
            _btnLoad.FlatAppearance.BorderSize = 2;
            _btnLoad.Click += BtnLoad_Click;

            // ── Error label (shown when no CSVs exist) ──
            _errorLabel.Text = string.Empty;
            _errorLabel.Font = new Font("Segoe UI", 9F);
            _errorLabel.ForeColor = Color.FromArgb(161, 44, 123);
            _errorLabel.AutoSize = false;
            _errorLabel.Size = new Size(472, 52);
            _errorLabel.Location = new Point(24, 222);
            _errorLabel.Visible = false;

            _choicePanel.Controls.AddRange(new Control[]
                { _choiceLabel, _btnNew, _btnLoad, _errorLabel });
        }

        private void BuildNewPanel()
        {
            _newPanel.Location = new Point(0, 88);
            _newPanel.Size = new Size(520, 332);
            _newPanel.BackColor = Color.Transparent;
            _newPanel.Visible = false;

            // Section title
            _lblNewTitle.Text = "New Inspection Report";
            _lblNewTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblNewTitle.ForeColor = Color.FromArgb(40, 37, 29);
            _lblNewTitle.AutoSize = true;
            _lblNewTitle.Location = new Point(24, 24);

            // Divider line
            var divider = new Label
            {
                AutoSize = false,
                Size = new Size(472, 1),
                Location = new Point(24, 54),
                BackColor = Color.FromArgb(212, 209, 202)
            };

            // ── Report filename ──
            _lblFile.Text = "Save Report As";
            _lblFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _lblFile.ForeColor = Color.FromArgb(40, 37, 29);
            _lblFile.AutoSize = true;
            _lblFile.Location = new Point(24, 70);

            _txtFile.Location = new Point(24, 92);
            _txtFile.Size = new Size(384, 27);
            _txtFile.Font = new Font("Segoe UI", 9F);
            _txtFile.Text = $"inspection_{DateTime.Now:yyyy-MM-dd}";
            _txtFile.PlaceholderText = "Enter a filename…";

            _btnBrowse.Text = "Browse…";
            _btnBrowse.Font = new Font("Segoe UI", 9F);
            _btnBrowse.Location = new Point(416, 91);
            _btnBrowse.Size = new Size(80, 29);
            _btnBrowse.FlatStyle = FlatStyle.Flat;
            _btnBrowse.BackColor = Color.FromArgb(237, 234, 229);
            _btnBrowse.Cursor = Cursors.Hand;
            _btnBrowse.FlatAppearance.BorderColor = Color.FromArgb(212, 209, 202);
            _btnBrowse.Click += BtnBrowse_Click;

            // ── Inspector name ──
            _lblInspector.Text = "Inspector Name";
            _lblInspector.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _lblInspector.ForeColor = Color.FromArgb(40, 37, 29);
            _lblInspector.AutoSize = true;
            _lblInspector.Location = new Point(24, 138);

            _txtInspector.Location = new Point(24, 160);
            _txtInspector.Size = new Size(472, 27);
            _txtInspector.Font = new Font("Segoe UI", 9F);
            _txtInspector.PlaceholderText = "Full name of the inspector signing this report";

            // Help text
            var helpText = new Label
            {
                Text = "The inspector's name will appear as a digital signature on the final report.",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Italic),
                ForeColor = Color.FromArgb(122, 121, 116),
                AutoSize = false,
                Size = new Size(472, 20),
                Location = new Point(24, 193)
            };

            // ── Navigation buttons ──
            _btnBack.Text = "← Back";
            _btnBack.Font = new Font("Segoe UI", 9F);
            _btnBack.Location = new Point(24, 262);
            _btnBack.Size = new Size(100, 32);
            _btnBack.FlatStyle = FlatStyle.Flat;
            _btnBack.BackColor = Color.FromArgb(237, 234, 229);
            _btnBack.Cursor = Cursors.Hand;
            _btnBack.FlatAppearance.BorderColor = Color.FromArgb(212, 209, 202);
            _btnBack.Click += BtnBack_Click;

            _btnStart.Text = "Start Inspection →";
            _btnStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _btnStart.Location = new Point(344, 262);
            _btnStart.Size = new Size(152, 32);
            _btnStart.FlatStyle = FlatStyle.Flat;
            _btnStart.BackColor = Color.FromArgb(0, 105, 111);
            _btnStart.ForeColor = Color.White;
            _btnStart.Cursor = Cursors.Hand;
            _btnStart.FlatAppearance.BorderSize = 0;
            _btnStart.Click += BtnStart_Click;

            _newPanel.Controls.AddRange(new Control[]
            {
                _lblNewTitle, divider,
                _lblFile, _txtFile, _btnBrowse,
                _lblInspector, _txtInspector, helpText,
                _btnBack, _btnStart
            });
        }

        // ── Event handlers ────────────────────────────────────────────────────

        private void BtnNew_Click(object sender, EventArgs e)
        {
            _choicePanel.Visible = false;
            _newPanel.Visible = true;
            _txtInspector.Focus();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            _errorLabel.Visible = false;

            string appDir = AppDomain.CurrentDomain.BaseDirectory;
            string[] found = Directory.GetFiles(appDir, "*.csv");

            if (found.Length == 0)
            {
                _errorLabel.Text =
                    "No inspection reports were found in the application folder.\r\n" +
                    "Please create a new report to get started.";
                _errorLabel.Visible = true;
                return;
            }

            using var dlg = new OpenFileDialog
            {
                Title = "Open Inspection Report",
                Filter = "Inspection Reports (*.csv)|*.csv|All Files (*.*)|*.*",
                DefaultExt = "csv",
                InitialDirectory = appDir
            };

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                SelectedFilePath = dlg.FileName;
                // Inspector name is not set on load — MainForm title will omit it.
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using var dlg = new SaveFileDialog
            {
                Title = "Choose Save Location for New Report",
                Filter = "Inspection Reports (*.csv)|*.csv",
                DefaultExt = "csv",
                FileName = _txtFile.Text.Trim(),
                InitialDirectory = AppDomain.CurrentDomain.BaseDirectory
            };

            if (dlg.ShowDialog(this) == DialogResult.OK)
                _txtFile.Text = dlg.FileName;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _newPanel.Visible = false;
            _choicePanel.Visible = true;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            string fileName = _txtFile.Text.Trim();
            string inspector = _txtInspector.Text.Trim();

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Please enter a filename for the new report.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _txtFile.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(inspector))
            {
                MessageBox.Show("Please enter the inspector's name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _txtInspector.Focus();
                return;
            }

            // Ensure .csv extension.
            if (!fileName.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
                fileName += ".csv";

            // If user typed a bare name, root it next to the exe.
            if (!Path.IsPathRooted(fileName))
                fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            SelectedFilePath = fileName;
            InspectionManager.InspectorName = inspector;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
