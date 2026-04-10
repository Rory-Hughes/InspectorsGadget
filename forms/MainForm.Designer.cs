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
            sidebarPanel = new Panel();
            sidebarTitle = new Label();
            dashboardBtn = new Button();
            btnAddInspection = new Button();
            btnViewReport = new Button();
            btnSettings = new Button();
            contentPanel = new Panel();
            btnDeleteItem = new Button();
            headerLabel = new Label();
            metricsPanel = new Panel();
            lblCriticalIssues = new Label();
            lblItemsInspected = new Label();
            lblAvgRiskScore = new Label();
            lblCriticalTitle = new Label();
            lblItemsTitle = new Label();
            lblAvgTitle = new Label();
            lblTotalRepairCost = new Label();
            lblTotalTitle = new Label();
            itemGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            btnRefresh = new Button();
            btnSave = new Button();
            sidebarPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            metricsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemGrid).BeginInit();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(33, 37, 41);
            sidebarPanel.Controls.Add(sidebarTitle);
            sidebarPanel.Controls.Add(dashboardBtn);
            sidebarPanel.Controls.Add(btnAddInspection);
            sidebarPanel.Controls.Add(btnViewReport);
            sidebarPanel.Controls.Add(btnSettings);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Margin = new Padding(2);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Padding = new Padding(8);
            sidebarPanel.Size = new Size(160, 642);
            sidebarPanel.TabIndex = 1;
            // 
            // sidebarTitle
            // 
            sidebarTitle.AutoSize = true;
            sidebarTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            sidebarTitle.ForeColor = Color.White;
            sidebarTitle.Location = new Point(0, 0);
            sidebarTitle.Margin = new Padding(0, 8, 0, 16);
            sidebarTitle.Name = "sidebarTitle";
            sidebarTitle.Size = new Size(107, 28);
            sidebarTitle.TabIndex = 0;
            sidebarTitle.Text = "Navigator";
            // 
            // dashboardBtn
            // 
            dashboardBtn.BackColor = Color.FromArgb(0, 105, 111);
            dashboardBtn.Cursor = Cursors.Hand;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Segoe UI", 10F);
            dashboardBtn.ForeColor = Color.White;
            dashboardBtn.Location = new Point(8, 48);
            dashboardBtn.Margin = new Padding(2);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(144, 32);
            dashboardBtn.TabIndex = 1;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = false;
            dashboardBtn.Click += BtnDashboard_Click;
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
            contentPanel.Controls.Add(btnDeleteItem);
            contentPanel.Controls.Add(headerLabel);
            contentPanel.Controls.Add(metricsPanel);
            contentPanel.Controls.Add(itemGrid);
            contentPanel.Controls.Add(btnRefresh);
            contentPanel.Controls.Add(btnSave);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(160, 0);
            contentPanel.Margin = new Padding(2);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(16);
            contentPanel.Size = new Size(988, 642);
            contentPanel.TabIndex = 0;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.BackColor = Color.Brown;
            btnDeleteItem.Cursor = Cursors.Hand;
            btnDeleteItem.FlatStyle = FlatStyle.Flat;
            btnDeleteItem.Font = new Font("Segoe UI", 10F);
            btnDeleteItem.ForeColor = Color.White;
            btnDeleteItem.Location = new Point(561, 592);
            btnDeleteItem.Margin = new Padding(2);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(133, 32);
            btnDeleteItem.TabIndex = 7;
            btnDeleteItem.Text = "🗑Delete Item";
            btnDeleteItem.UseVisualStyleBackColor = false;
            btnDeleteItem.Click += BtnDeleteItem_Click;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            headerLabel.ForeColor = Color.FromArgb(33, 37, 41);
            headerLabel.Location = new Point(200, 9);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(545, 37);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Inspector's Gadget - Property Dashboard";
            // 
            // metricsPanel
            // 
            metricsPanel.AutoScroll = true;
            metricsPanel.BackColor = Color.White;
            metricsPanel.Controls.Add(lblCriticalIssues);
            metricsPanel.Controls.Add(lblItemsInspected);
            metricsPanel.Controls.Add(lblAvgRiskScore);
            metricsPanel.Controls.Add(lblCriticalTitle);
            metricsPanel.Controls.Add(lblItemsTitle);
            metricsPanel.Controls.Add(lblAvgTitle);
            metricsPanel.Controls.Add(lblTotalRepairCost);
            metricsPanel.Controls.Add(lblTotalTitle);
            metricsPanel.Location = new Point(16, 56);
            metricsPanel.Margin = new Padding(2);
            metricsPanel.Name = "metricsPanel";
            metricsPanel.Size = new Size(953, 88);
            metricsPanel.TabIndex = 1;
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
            // itemGrid
            // 
            itemGrid.AllowUserToAddRows = false;
            itemGrid.AllowUserToDeleteRows = false;
            itemGrid.BackgroundColor = Color.White;
            itemGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            itemGrid.Location = new Point(16, 160);
            itemGrid.Margin = new Padding(2);
            itemGrid.MultiSelect = false;
            itemGrid.Name = "itemGrid";
            itemGrid.RowHeadersWidth = 51;
            itemGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            itemGrid.Size = new Size(953, 414);
            itemGrid.TabIndex = 2;
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
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(0, 105, 111);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(835, 592);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(133, 32);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "⟳ Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
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
            Controls.Add(sidebarPanel);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Inspector's Gadget";
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            metricsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)itemGrid).EndInit();
            ResumeLayout(false);
        }


        #region Designer Fields

        private Panel sidebarPanel;
        private Label sidebarTitle;
        private Button dashboardBtn;
        private Button btnAddInspection;
        private Button btnViewReport;
        private Button btnSettings;
        private Panel contentPanel;
        private Label headerLabel;
        private Panel metricsPanel;
        private DataGridView itemGrid;
        private Button btnRefresh;
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
    }
}
