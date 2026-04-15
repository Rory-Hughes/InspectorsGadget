namespace InspectorsGadget
{
    partial class ReportForm
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
            panMain = new Panel();
            lblHeader = new Label();
            txtReport = new TextBox();
            btnSendReport = new Button();
            btnClose = new Button();
            panMain.SuspendLayout();
            SuspendLayout();
            // 
            // panMain
            // 
            panMain.AutoScroll = true;
            panMain.Controls.Add(lblHeader);
            panMain.Controls.Add(txtReport);
            panMain.Controls.Add(btnSendReport);
            panMain.Controls.Add(btnClose);
            panMain.Dock = DockStyle.Fill;
            panMain.Location = new Point(16, 16);
            panMain.Margin = new Padding(2);
            panMain.Name = "panMain";
            panMain.Size = new Size(853, 905);
            panMain.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.Top;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(33, 37, 41);
            lblHeader.Location = new Point(257, 22);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(327, 32);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Property Inspection Report";
            // 
            // txtReport
            // 
            txtReport.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtReport.Location = new Point(16, 56);
            txtReport.Margin = new Padding(2);
            txtReport.Multiline = true;
            txtReport.Name = "txtReport";
            txtReport.ReadOnly = true;
            txtReport.ScrollBars = ScrollBars.Vertical;
            txtReport.Size = new Size(805, 780);
            txtReport.TabIndex = 1;
            // 
            // btnSendReport
            // 
            btnSendReport.BackColor = Color.FromArgb(0, 105, 111);
            btnSendReport.Cursor = Cursors.Hand;
            btnSendReport.FlatStyle = FlatStyle.Flat;
            btnSendReport.ForeColor = Color.White;
            btnSendReport.Location = new Point(709, 852);
            btnSendReport.Margin = new Padding(2);
            btnSendReport.Name = "btnSendReport";
            btnSendReport.Size = new Size(112, 28);
            btnSendReport.TabIndex = 2;
            btnSendReport.Text = "Send Report";
            btnSendReport.UseVisualStyleBackColor = false;
            btnSendReport.Click += SendReportBtn_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(128, 128, 128);
            btnClose.Cursor = Cursors.Hand;
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(580, 852);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 28);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(885, 937);
            Controls.Add(panMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReportForm";
            Padding = new Padding(16);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Property Inspection Report";
            panMain.ResumeLayout(false);
            panMain.PerformLayout();
            ResumeLayout(false);
        }

        #region Controls
        private TextBox txtReport;
        #endregion

        private Panel panMain;
        private Label lblHeader;
        private Button btnSendReport;
        private Button btnClose;
    }
}
