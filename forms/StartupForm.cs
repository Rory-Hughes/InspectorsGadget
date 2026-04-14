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

namespace InspectorsGadget.forms
{
    public partial class StartupForm : Form
    {

        public string SelectedFilePath { get; private set; } = string.Empty;

        public StartupForm()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            panChoice.Visible = false;
            panNew.Visible = true;
            txtInspector.Focus();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            // 
            string appDir = AppDomain.CurrentDomain.BaseDirectory;
            string[] found = Directory.GetFiles(appDir, "*.csv");

            if (found.Length == 0)
            {
                lblError.Text =
                    "No inspection reports were found in the application folder.\r\n" +
                    "Please create a new report to get started.";
                lblError.Visible = true;
                return;
            };

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
            };
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtFile.Text))
            {
                txtFile.Text = $"inspection_{DateTime.Now:yyyy-MM-dd}";
            };

            using var dlg = new SaveFileDialog
            {
                Title = "Choose Save Location for New Report",
                Filter = "Inspection Reports (*.csv)|*.csv",
                DefaultExt = "csv",
                FileName = txtFile.Text.Trim(),
                InitialDirectory = AppDomain.CurrentDomain.BaseDirectory
            };

            if (dlg.ShowDialog(this) == DialogResult.OK)
                txtFile.Text = dlg.FileName;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panNew.Visible = false;
            panChoice.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string fileName = txtFile.Text.Trim();
            string inspector = txtInspector.Text.Trim();

            if (string.IsNullOrWhiteSpace(fileName))
            {
                txtFile.Text = $"inspection_{DateTime.Now:yyyy-MM-dd}";
            };

            if (string.IsNullOrWhiteSpace(inspector))
            {
                MessageBox.Show("Please enter the inspector's name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInspector.Focus();
                return;
            };

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
