namespace InspectorsGadget
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panSidebar = new Panel();
            lblSidebarTitle = new Label();
            btnDashboard = new Button();
            btnAddInspection = new Button();
            btnViewReport = new Button();
            btnSettings = new Button();
            contentPanel = new Panel();
            btnSaveAs = new Button();
            btnEditItem = new Button();
            btnDeleteItem = new Button();
            lblHeader = new Label();
            panMetrics = new Panel();
            lblCriticalIssues = new Label();
            lblItemsInspected = new Label();
            lblAvgRiskScore = new Label();
            lblCriticalTitle = new Label();
            lblItemsTitle = new Label();
            lblAvgTitle = new Label();
            lblTotalRepairCost = new Label();
            lblTotalTitle = new Label();
            dgvInspectionItems = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            btnLoadFile = new Button();
            btnSave = new Button();
            panSidebar.SuspendLayout();
            contentPanel.SuspendLayout();
            panMetrics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInspectionItems).BeginInit();
            SuspendLayout();
            // 
            // panSidebar
            // 
            panSidebar.BackColor = Color.FromArgb(33, 37, 41);
            panSidebar.Controls.Add(lblSidebarTitle);
            panSidebar.Controls.Add(btnDashboard);
            panSidebar.Controls.Add(btnAddInspection);
            panSidebar.Controls.Add(btnViewReport);
            panSidebar.Controls.Add(btnSettings);
            panSidebar.Dock = DockStyle.Left;
            panSidebar.Location = new Point(0, 0);
            panSidebar.Margin = new Padding(2);
            panSidebar.Name = "panSidebar";
            panSidebar.Padding = new Padding(8);
            panSidebar.Size = new Size(160, 642);
            panSidebar.TabIndex = 1;
            // 
            // lblSidebarTitle
            // 
            lblSidebarTitle.AutoSize = true;
            lblSidebarTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSidebarTitle.ForeColor = Color.White;
            lblSidebarTitle.Location = new Point(0, 0);
            lblSidebarTitle.Margin = new Padding(0, 8, 0, 16);
            lblSidebarTitle.Name = "lblSidebarTitle";
            lblSidebarTitle.Size = new Size(107, 28);
            lblSidebarTitle.TabIndex = 0;
            lblSidebarTitle.Text = "Navigator";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(0, 105, 111);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(8, 48);
            btnDashboard.Margin = new Padding(2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(144, 32);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += BtnDashboard_Click;
            // 
            // btnAddInspection
            // 
            btnAddInspection.BackColor = Color.FromArgb(60, 63, 65);
            btnAddInspection.Cursor = Cursors.Hand;
            btnAddInspection.FlatStyle = FlatStyle.Flat;
            btnAddInspection.Font = new Font("Segoe UI", 10F);
            btnAddInspection.ForeColor = Color.White;
            btnAddInspection.Location = new Point(8, 88);
            btnAddInspection.Margin = new Padding(2);
            btnAddInspection.Name = "btnAddInspection";
            btnAddInspection.Size = new Size(144, 32);
            btnAddInspection.TabIndex = 2;
            btnAddInspection.Text = "Add Inspection";
            btnAddInspection.UseVisualStyleBackColor = false;
            btnAddInspection.Click += BtnAddInspection_Click;
            // 
            // btnViewReport
            // 
            btnViewReport.BackColor = Color.FromArgb(60, 63, 65);
            btnViewReport.Cursor = Cursors.Hand;
            btnViewReport.FlatStyle = FlatStyle.Flat;
            btnViewReport.Font = new Font("Segoe UI", 10F);
            btnViewReport.ForeColor = Color.White;
            btnViewReport.Location = new Point(8, 128);
            btnViewReport.Margin = new Padding(2);
            btnViewReport.Name = "btnViewReport";
            btnViewReport.Size = new Size(144, 32);
            btnViewReport.TabIndex = 3;
            btnViewReport.Text = "View Report";
            btnViewReport.UseVisualStyleBackColor = false;
            btnViewReport.Click += BtnViewReport_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(60, 63, 65);
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 10F);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(8, 168);
            btnSettings.Margin = new Padding(2);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(144, 32);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += BtnSettings_Click;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.White;
            contentPanel.Controls.Add(btnSaveAs);
            contentPanel.Controls.Add(btnEditItem);
            contentPanel.Controls.Add(btnDeleteItem);
            contentPanel.Controls.Add(lblHeader);
            contentPanel.Controls.Add(panMetrics);
            contentPanel.Controls.Add(dgvInspectionItems);
            contentPanel.Controls.Add(btnLoadFile);
            contentPanel.Controls.Add(btnSave);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(160, 0);
            contentPanel.Margin = new Padding(2);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(16);
            contentPanel.Size = new Size(988, 642);
            contentPanel.TabIndex = 0;
            // 
            // btnSaveAs
            // 
            btnSaveAs.BackColor = Color.FromArgb(52, 152, 219);
            btnSaveAs.Cursor = Cursors.Hand;
            btnSaveAs.FlatStyle = FlatStyle.Flat;
            btnSaveAs.Font = new Font("Segoe UI", 10F);
            btnSaveAs.ForeColor = Color.White;
            btnSaveAs.Location = new Point(561, 592);
            btnSaveAs.Margin = new Padding(2);
            btnSaveAs.Name = "btnSaveAs";
            btnSaveAs.Size = new Size(133, 32);
            btnSaveAs.TabIndex = 9;
            btnSaveAs.Text = "Save File As...";
            btnSaveAs.UseVisualStyleBackColor = false;
            btnSaveAs.Click += btnSaveAs_Click;
            // 
            // btnEditItem
            // 
            btnEditItem.BackColor = Color.Goldenrod;
            btnEditItem.Location = new Point(16, 593);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new Size(133, 32);
            btnEditItem.TabIndex = 8;
            btnEditItem.Text = "Edit Item";
            btnEditItem.UseVisualStyleBackColor = false;
            btnEditItem.Click += btnEditItem_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.BackColor = Color.Brown;
            btnDeleteItem.Cursor = Cursors.Hand;
            btnDeleteItem.FlatAppearance.BorderColor = Color.Black;
            btnDeleteItem.FlatAppearance.BorderSize = 2;
            btnDeleteItem.Font = new Font("Segoe UI", 10F);
            btnDeleteItem.ForeColor = Color.White;
            btnDeleteItem.Location = new Point(154, 593);
            btnDeleteItem.Margin = new Padding(2);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(133, 32);
            btnDeleteItem.TabIndex = 7;
            btnDeleteItem.Text = "🗑Delete Item";
            btnDeleteItem.UseVisualStyleBackColor = false;
            btnDeleteItem.Click += BtnDeleteItem_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(33, 37, 41);
            lblHeader.Location = new Point(200, 9);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(545, 37);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Inspector's Gadget - Property Dashboard";
            // 
            // panMetrics
            // 
            panMetrics.AutoScroll = true;
            panMetrics.BackColor = Color.White;
            panMetrics.Controls.Add(lblCriticalIssues);
            panMetrics.Controls.Add(lblItemsInspected);
            panMetrics.Controls.Add(lblAvgRiskScore);
            panMetrics.Controls.Add(lblCriticalTitle);
            panMetrics.Controls.Add(lblItemsTitle);
            panMetrics.Controls.Add(lblAvgTitle);
            panMetrics.Controls.Add(lblTotalRepairCost);
            panMetrics.Controls.Add(lblTotalTitle);
            panMetrics.Location = new Point(16, 56);
            panMetrics.Margin = new Padding(2);
            panMetrics.Name = "panMetrics";
            panMetrics.Size = new Size(953, 88);
            panMetrics.TabIndex = 1;
            // 
            // lblCriticalIssues
            // 
            lblCriticalIssues.BackColor = Color.FromArgb(245, 245, 245);
            lblCriticalIssues.BorderStyle = BorderStyle.FixedSingle;
            lblCriticalIssues.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCriticalIssues.ForeColor = Color.FromArgb(192, 57, 43);
            lblCriticalIssues.Location = new Point(798, 31);
            lblCriticalIssues.Name = "lblCriticalIssues";
            lblCriticalIssues.Size = new Size(154, 57);
            lblCriticalIssues.TabIndex = 7;
            lblCriticalIssues.Text = "0";
            lblCriticalIssues.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblItemsInspected
            // 
            lblItemsInspected.BackColor = Color.FromArgb(245, 245, 245);
            lblItemsInspected.BorderStyle = BorderStyle.FixedSingle;
            lblItemsInspected.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblItemsInspected.ForeColor = Color.FromArgb(52, 152, 219);
            lblItemsInspected.Location = new Point(515, 31);
            lblItemsInspected.Name = "lblItemsInspected";
            lblItemsInspected.Size = new Size(154, 57);
            lblItemsInspected.TabIndex = 6;
            lblItemsInspected.Text = "0";
            lblItemsInspected.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAvgRiskScore
            // 
            lblAvgRiskScore.BackColor = Color.FromArgb(245, 245, 245);
            lblAvgRiskScore.BorderStyle = BorderStyle.FixedSingle;
            lblAvgRiskScore.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAvgRiskScore.ForeColor = Color.FromArgb(230, 126, 34);
            lblAvgRiskScore.Location = new Point(254, 31);
            lblAvgRiskScore.Name = "lblAvgRiskScore";
            lblAvgRiskScore.Size = new Size(148, 57);
            lblAvgRiskScore.TabIndex = 5;
            lblAvgRiskScore.Text = "0.0 / 10";
            lblAvgRiskScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCriticalTitle
            // 
            lblCriticalTitle.BackColor = Color.FromArgb(245, 245, 245);
            lblCriticalTitle.BorderStyle = BorderStyle.FixedSingle;
            lblCriticalTitle.Font = new Font("Segoe UI", 9F);
            lblCriticalTitle.ForeColor = Color.FromArgb(100, 100, 100);
            lblCriticalTitle.Location = new Point(798, 0);
            lblCriticalTitle.Name = "lblCriticalTitle";
            lblCriticalTitle.Size = new Size(154, 31);
            lblCriticalTitle.TabIndex = 4;
            lblCriticalTitle.Text = "Critical Issues:";
            lblCriticalTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblItemsTitle
            // 
            lblItemsTitle.BackColor = Color.FromArgb(245, 245, 245);
            lblItemsTitle.BorderStyle = BorderStyle.FixedSingle;
            lblItemsTitle.Font = new Font("Segoe UI", 9F);
            lblItemsTitle.ForeColor = Color.FromArgb(100, 100, 100);
            lblItemsTitle.Location = new Point(515, 0);
            lblItemsTitle.Name = "lblItemsTitle";
            lblItemsTitle.Size = new Size(154, 31);
            lblItemsTitle.TabIndex = 3;
            lblItemsTitle.Text = "Items Inspected:";
            lblItemsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAvgTitle
            // 
            lblAvgTitle.BackColor = Color.FromArgb(245, 245, 245);
            lblAvgTitle.BorderStyle = BorderStyle.FixedSingle;
            lblAvgTitle.Font = new Font("Segoe UI", 9F);
            lblAvgTitle.ForeColor = Color.FromArgb(100, 100, 100);
            lblAvgTitle.Location = new Point(254, 0);
            lblAvgTitle.Name = "lblAvgTitle";
            lblAvgTitle.Size = new Size(148, 31);
            lblAvgTitle.TabIndex = 2;
            lblAvgTitle.Text = "Avg Risk Score:";
            lblAvgTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalRepairCost
            // 
            lblTotalRepairCost.BackColor = Color.FromArgb(245, 245, 245);
            lblTotalRepairCost.BorderStyle = BorderStyle.FixedSingle;
            lblTotalRepairCost.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotalRepairCost.ForeColor = Color.FromArgb(0, 105, 111);
            lblTotalRepairCost.Location = new Point(0, 31);
            lblTotalRepairCost.Name = "lblTotalRepairCost";
            lblTotalRepairCost.Size = new Size(146, 57);
            lblTotalRepairCost.TabIndex = 1;
            lblTotalRepairCost.Text = "0$";
            lblTotalRepairCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.BackColor = Color.FromArgb(245, 245, 245);
            lblTotalTitle.BorderStyle = BorderStyle.FixedSingle;
            lblTotalTitle.Font = new Font("Segoe UI", 9F);
            lblTotalTitle.ForeColor = Color.FromArgb(100, 100, 100);
            lblTotalTitle.Location = new Point(0, 0);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(146, 31);
            lblTotalTitle.TabIndex = 0;
            lblTotalTitle.Text = "Total Repair Cost:";
            lblTotalTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvInspectionItems
            // 
            dgvInspectionItems.AllowUserToAddRows = false;
            dgvInspectionItems.AllowUserToDeleteRows = false;
            dgvInspectionItems.BackgroundColor = Color.White;
            dgvInspectionItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInspectionItems.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvInspectionItems.Location = new Point(16, 160);
            dgvInspectionItems.Margin = new Padding(2);
            dgvInspectionItems.MultiSelect = false;
            dgvInspectionItems.Name = "dgvInspectionItems";
            dgvInspectionItems.RowHeadersWidth = 51;
            dgvInspectionItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInspectionItems.Size = new Size(953, 414);
            dgvInspectionItems.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Item Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Category";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Risk Level";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Est. Cost";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 200;
            // 
            // btnLoadFile
            // 
            btnLoadFile.BackColor = Color.FromArgb(0, 105, 111);
            btnLoadFile.Cursor = Cursors.Hand;
            btnLoadFile.FlatStyle = FlatStyle.Flat;
            btnLoadFile.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadFile.ForeColor = Color.White;
            btnLoadFile.Location = new Point(835, 592);
            btnLoadFile.Margin = new Padding(2);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(133, 32);
            btnLoadFile.TabIndex = 3;
            btnLoadFile.Text = "Load File";
            btnLoadFile.UseVisualStyleBackColor = false;
            btnLoadFile.Click += BtnLoadFile_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(52, 152, 219);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(698, 592);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 32);
            btnSave.TabIndex = 4;
            btnSave.Text = "💾Save File";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(1148, 642);
            Controls.Add(contentPanel);
            Controls.Add(panSidebar);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Inspector's Gadget";
            panSidebar.ResumeLayout(false);
            panSidebar.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            panMetrics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInspectionItems).EndInit();
            ResumeLayout(false);
        }


        #region Designer Fields

        private Panel panSidebar;
        private Label lblSidebarTitle;
        private Button btnDashboard;
        private Button btnAddInspection;
        private Button btnViewReport;
        private Button btnSettings;
        private Panel contentPanel;
        private Label lblHeader;
        private Panel panMetrics;
        private DataGridView dgvInspectionItems;
        private Button btnLoadFile;
        private Button btnSave;

        #endregion

        private Label lblTotalTitle;
        private Label lblTotalRepairCost;
        private Label lblAvgTitle;
        private Label lblItemsTitle;
        private Label lblCriticalTitle;
        private Label lblCriticalIssues;
        private Label lblItemsInspected;
        private Label lblAvgRiskScore;
        private Button btnDeleteItem;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button btnEditItem;
        private Button btnSaveAs;
    }
}
