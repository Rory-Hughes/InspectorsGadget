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
            components = new System.ComponentModel.Container();

            // Sidebar Panel
            sidebarPanel = new Panel();
            sidebarPanel.BackColor = Color.FromArgb(33, 37, 41);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Width = 200;
            sidebarPanel.Padding = new Padding(10);

            // Sidebar Title
            sidebarTitle = new Label();
            sidebarTitle.Text = "Navigator";
            sidebarTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            sidebarTitle.ForeColor = Color.White;
            sidebarTitle.AutoSize = true;
            sidebarTitle.Margin = new Padding(0, 10, 0, 20);
            sidebarPanel.Controls.Add(sidebarTitle);

            // Navigation Buttons
            dashboardBtn = new Button();
            dashboardBtn.Text = "📊 Dashboard";
            dashboardBtn.Width = 180;
            dashboardBtn.Height = 40;
            dashboardBtn.Top = 60;
            dashboardBtn.Left = 10;
            dashboardBtn.BackColor = Color.FromArgb(0, 105, 111);
            dashboardBtn.ForeColor = Color.White;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Segoe UI", 10F);
            dashboardBtn.Cursor = Cursors.Hand;
            dashboardBtn.Click += DashboardBtn_Click;
            sidebarPanel.Controls.Add(dashboardBtn);

            addInspectionBtn = new Button();
            addInspectionBtn.Text = "➕ Add Inspection";
            addInspectionBtn.Width = 180;
            addInspectionBtn.Height = 40;
            addInspectionBtn.Top = 110;
            addInspectionBtn.Left = 10;
            addInspectionBtn.BackColor = Color.FromArgb(60, 63, 65);
            addInspectionBtn.ForeColor = Color.White;
            addInspectionBtn.FlatStyle = FlatStyle.Flat;
            addInspectionBtn.Font = new Font("Segoe UI", 10F);
            addInspectionBtn.Cursor = Cursors.Hand;
            addInspectionBtn.Click += AddInspectionBtn_Click;
            sidebarPanel.Controls.Add(addInspectionBtn);

            viewReportBtn = new Button();
            viewReportBtn.Text = "📄 View Report";
            viewReportBtn.Width = 180;
            viewReportBtn.Height = 40;
            viewReportBtn.Top = 160;
            viewReportBtn.Left = 10;
            viewReportBtn.BackColor = Color.FromArgb(60, 63, 65);
            viewReportBtn.ForeColor = Color.White;
            viewReportBtn.FlatStyle = FlatStyle.Flat;
            viewReportBtn.Font = new Font("Segoe UI", 10F);
            viewReportBtn.Cursor = Cursors.Hand;
            viewReportBtn.Click += ViewReportBtn_Click;
            sidebarPanel.Controls.Add(viewReportBtn);

            settingsBtn = new Button();
            settingsBtn.Text = "⚙️ Settings";
            settingsBtn.Width = 180;
            settingsBtn.Height = 40;
            settingsBtn.Top = 210;
            settingsBtn.Left = 10;
            settingsBtn.BackColor = Color.FromArgb(60, 63, 65);
            settingsBtn.ForeColor = Color.White;
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Font = new Font("Segoe UI", 10F);
            settingsBtn.Cursor = Cursors.Hand;
            settingsBtn.Click += SettingsBtn_Click;
            sidebarPanel.Controls.Add(settingsBtn);

            // Content Panel
            contentPanel = new Panel();
            contentPanel.BackColor = Color.White;
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Padding = new Padding(20);

            // Header
            headerLabel = new Label();
            headerLabel.Text = "Inspector's Gadget - Property Dashboard";
            headerLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            headerLabel.ForeColor = Color.FromArgb(33, 37, 41);
            headerLabel.AutoSize = true;
            headerLabel.Location = new Point(20, 20);
            contentPanel.Controls.Add(headerLabel);

            // Metrics Panel
            metricsPanel = new Panel();
            metricsPanel.AutoScroll = true;
            metricsPanel.Location = new Point(20, 70);
            metricsPanel.Size = new Size(780, 110);
            metricsPanel.BackColor = Color.White;
            contentPanel.Controls.Add(metricsPanel);

            // Create metric cards
            CreateMetricCard(metricsPanel, 10, 10, "Total Repair Cost", "$0.00", Color.FromArgb(0, 105, 111));
            CreateMetricCard(metricsPanel, 200, 10, "Avg Risk Score", "0.0 / 10", Color.FromArgb(230, 126, 34));
            CreateMetricCard(metricsPanel, 390, 10, "Items Inspected", "0", Color.FromArgb(52, 152, 219));
            CreateMetricCard(metricsPanel, 580, 10, "Critical Issues", "0", Color.FromArgb(192, 57, 43));

            // Data Grid
            itemGrid = new DataGridView();
            itemGrid.Location = new Point(20, 200);
            itemGrid.Size = new Size(780, 300);
            itemGrid.AllowUserToAddRows = false;
            itemGrid.AllowUserToDeleteRows = false;
            itemGrid.BackgroundColor = Color.White;
            itemGrid.BorderStyle = BorderStyle.FixedSingle;
            itemGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contentPanel.Controls.Add(itemGrid);

            // Configure grid columns
            itemGrid.Columns.Add("ItemName", "Item Name");
            itemGrid.Columns.Add("Category", "Category");
            itemGrid.Columns.Add("RiskLevel", "Risk Level");
            itemGrid.Columns.Add("EstimatedCost", "Est. Cost");

            itemGrid.Columns["ItemName"].Width = 200;
            itemGrid.Columns["Category"].Width = 120;
            itemGrid.Columns["RiskLevel"].Width = 100;
            itemGrid.Columns["EstimatedCost"].Width = 120;

            // Bottom Buttons
            refreshBtn = new Button();
            refreshBtn.Text = "🔄 Refresh";
            refreshBtn.Width = 100;
            refreshBtn.Height = 35;
            refreshBtn.Location = new Point(700, 520);
            refreshBtn.BackColor = Color.FromArgb(0, 105, 111);
            refreshBtn.ForeColor = Color.White;
            refreshBtn.FlatStyle = FlatStyle.Flat;
            refreshBtn.Font = new Font("Segoe UI", 10F);
            refreshBtn.Cursor = Cursors.Hand;
            refreshBtn.Click += RefreshBtn_Click;
            contentPanel.Controls.Add(refreshBtn);

            exportBtn = new Button();
            exportBtn.Text = "💾 Save";
            exportBtn.Width = 100;
            exportBtn.Height = 35;
            exportBtn.Location = new Point(590, 520);
            exportBtn.BackColor = Color.FromArgb(52, 152, 219);
            exportBtn.ForeColor = Color.White;
            exportBtn.FlatStyle = FlatStyle.Flat;
            exportBtn.Font = new Font("Segoe UI", 10F);
            exportBtn.Cursor = Cursors.Hand;
            exportBtn.Click += ExportBtn_Click;
            contentPanel.Controls.Add(exportBtn);

            // Form
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1024, 600);
            this.Name = "MainForm";
            this.Text = "Inspector's Gadget";
            this.WindowState = FormWindowState.Maximized;
            this.Controls.Add(contentPanel);
            this.Controls.Add(sidebarPanel);

            ResumeLayout(false);
        }

        private void CreateMetricCard(Panel parent, int x, int y, string title, string value, Color accentColor)
        {
            Panel card = new Panel();
            card.Location = new Point(x, y);
            card.Size = new Size(180, 90);
            card.BackColor = Color.FromArgb(245, 245, 245);
            card.BorderStyle = BorderStyle.FixedSingle;
            parent.Controls.Add(card);

            Label titleLabel = new Label();
            titleLabel.Text = title;
            titleLabel.Font = new Font("Segoe UI", 9F);
            titleLabel.ForeColor = Color.FromArgb(100, 100, 100);
            titleLabel.Location = new Point(10, 10);
            titleLabel.AutoSize = true;
            card.Controls.Add(titleLabel);

            Label valueLabel = new Label();
            valueLabel.Text = value;
            valueLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            valueLabel.ForeColor = accentColor;
            valueLabel.Location = new Point(10, 35);
            valueLabel.AutoSize = true;
            valueLabel.Name = $"Value_{title.Replace(" ", "")}";
            card.Controls.Add(valueLabel);
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
    }
}
