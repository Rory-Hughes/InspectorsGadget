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
            addInspectionBtn = new Button();
            viewReportBtn = new Button();
            settingsBtn = new Button();
            contentPanel = new Panel();
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
            refreshBtn = new Button();
            exportBtn = new Button();
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
            sidebarPanel.Controls.Add(addInspectionBtn);
            sidebarPanel.Controls.Add(viewReportBtn);
            sidebarPanel.Controls.Add(settingsBtn);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Margin = new Padding(2);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Padding = new Padding(8);
            sidebarPanel.Size = new Size(160, 480);
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
            dashboardBtn.Click += DashboardBtn_Click;
            // 
            // addInspectionBtn
            // 
            addInspectionBtn.BackColor = Color.FromArgb(60, 63, 65);
            addInspectionBtn.Cursor = Cursors.Hand;
            addInspectionBtn.FlatStyle = FlatStyle.Flat;
            addInspectionBtn.Font = new Font("Segoe UI", 10F);
            addInspectionBtn.ForeColor = Color.White;
            addInspectionBtn.Location = new Point(8, 88);
            addInspectionBtn.Margin = new Padding(2);
            addInspectionBtn.Name = "addInspectionBtn";
            addInspectionBtn.Size = new Size(144, 32);
            addInspectionBtn.TabIndex = 2;
            addInspectionBtn.Text = "Add Inspection";
            addInspectionBtn.UseVisualStyleBackColor = false;
            addInspectionBtn.Click += AddInspectionBtn_Click;
            // 
            // viewReportBtn
            // 
            viewReportBtn.BackColor = Color.FromArgb(60, 63, 65);
            viewReportBtn.Cursor = Cursors.Hand;
            viewReportBtn.FlatStyle = FlatStyle.Flat;
            viewReportBtn.Font = new Font("Segoe UI", 10F);
            viewReportBtn.ForeColor = Color.White;
            viewReportBtn.Location = new Point(8, 128);
            viewReportBtn.Margin = new Padding(2);
            viewReportBtn.Name = "viewReportBtn";
            viewReportBtn.Size = new Size(144, 32);
            viewReportBtn.TabIndex = 3;
            viewReportBtn.Text = "View Report";
            viewReportBtn.UseVisualStyleBackColor = false;
            viewReportBtn.Click += ViewReportBtn_Click;
            // 
            // settingsBtn
            // 
            settingsBtn.BackColor = Color.FromArgb(60, 63, 65);
            settingsBtn.Cursor = Cursors.Hand;
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Font = new Font("Segoe UI", 10F);
            settingsBtn.ForeColor = Color.White;
            settingsBtn.Location = new Point(8, 168);
            settingsBtn.Margin = new Padding(2);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(144, 32);
            settingsBtn.TabIndex = 4;
            settingsBtn.Text = "Settings";
            settingsBtn.UseVisualStyleBackColor = false;
            settingsBtn.Click += SettingsBtn_Click;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.White;
            contentPanel.Controls.Add(headerLabel);
            contentPanel.Controls.Add(metricsPanel);
            contentPanel.Controls.Add(itemGrid);
            contentPanel.Controls.Add(refreshBtn);
            contentPanel.Controls.Add(exportBtn);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(160, 0);
            contentPanel.Margin = new Padding(2);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(16);
            contentPanel.Size = new Size(659, 480);
            contentPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            headerLabel.ForeColor = Color.FromArgb(33, 37, 41);
            headerLabel.Location = new Point(16, 16);
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
            metricsPanel.Size = new Size(624, 88);
            metricsPanel.TabIndex = 1;
            // 
            // lblCriticalIssues
            // 
            lblCriticalIssues.BackColor = Color.FromArgb(245, 245, 245);
            lblCriticalIssues.BorderStyle = BorderStyle.FixedSingle;
            lblCriticalIssues.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCriticalIssues.ForeColor = Color.FromArgb(192, 57, 43);
            lblCriticalIssues.Location = new Point(470, 31);
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
            lblItemsInspected.Location = new Point(309, 31);
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
            lblAvgRiskScore.Location = new Point(155, 31);
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
            lblCriticalTitle.Location = new Point(470, 0);
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
            lblItemsTitle.Location = new Point(309, 0);
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
            lblAvgTitle.Location = new Point(155, 0);
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
            itemGrid.Name = "itemGrid";
            itemGrid.RowHeadersWidth = 51;
            itemGrid.Size = new Size(624, 240);
            itemGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Item Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Category";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Risk Level";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Est. Cost";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // refreshBtn
            // 
            refreshBtn.BackColor = Color.FromArgb(0, 105, 111);
            refreshBtn.Cursor = Cursors.Hand;
            refreshBtn.FlatStyle = FlatStyle.Flat;
            refreshBtn.Font = new Font("Segoe UI", 10F);
            refreshBtn.ForeColor = Color.White;
            refreshBtn.Location = new Point(560, 416);
            refreshBtn.Margin = new Padding(2);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(80, 32);
            refreshBtn.TabIndex = 3;
            refreshBtn.Text = "🔄 Refresh";
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += RefreshBtn_Click;
            // 
            // exportBtn
            // 
            exportBtn.BackColor = Color.FromArgb(52, 152, 219);
            exportBtn.Cursor = Cursors.Hand;
            exportBtn.FlatStyle = FlatStyle.Flat;
            exportBtn.Font = new Font("Segoe UI", 10F);
            exportBtn.ForeColor = Color.White;
            exportBtn.Location = new Point(472, 416);
            exportBtn.Margin = new Padding(2);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(80, 32);
            exportBtn.TabIndex = 4;
            exportBtn.Text = "💾 Save";
            exportBtn.UseVisualStyleBackColor = false;
            exportBtn.Click += ExportBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 480);
            Controls.Add(contentPanel);
            Controls.Add(sidebarPanel);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Inspector's Gadget";
            WindowState = FormWindowState.Maximized;
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
        private Button addInspectionBtn;
        private Button viewReportBtn;
        private Button settingsBtn;
        private Panel contentPanel;
        private Label headerLabel;
        private Panel metricsPanel;
        private DataGridView itemGrid;
        private Button refreshBtn;
        private Button exportBtn;

        #endregion

        private Label lblTotalTitle;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label lblTotalRepairCost;
        private Label lblAvgTitle;
        private Label lblItemsTitle;
        private Label lblCriticalTitle;
        private Label lblCriticalIssues;
        private Label lblItemsInspected;
        private Label lblAvgRiskScore;
    }
}
