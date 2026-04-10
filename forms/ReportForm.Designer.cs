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
            mainPanel = new Panel();
            headerLabel = new Label();
            reportTextBox = new TextBox();
            sendReportBtn = new Button();
            closeBtn = new Button();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.Controls.Add(headerLabel);
            mainPanel.Controls.Add(reportTextBox);
            mainPanel.Controls.Add(sendReportBtn);
            mainPanel.Controls.Add(closeBtn);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(16, 16);
            mainPanel.Margin = new Padding(2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1361, 905);
            mainPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            headerLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            headerLabel.ForeColor = Color.FromArgb(33, 37, 41);
            headerLabel.Location = new Point(489, 12);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(327, 32);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Property Inspection Report";
            // 
            // reportTextBox
            // 
            reportTextBox.Font = new Font("Courier New", 9F);
            reportTextBox.Location = new Point(16, 56);
            reportTextBox.Margin = new Padding(2);
            reportTextBox.Multiline = true;
            reportTextBox.Name = "reportTextBox";
            reportTextBox.ReadOnly = true;
            reportTextBox.ScrollBars = ScrollBars.Vertical;
            reportTextBox.Size = new Size(1312, 780);
            reportTextBox.TabIndex = 1;
            // 
            // sendReportBtn
            // 
            sendReportBtn.BackColor = Color.FromArgb(0, 105, 111);
            sendReportBtn.Cursor = Cursors.Hand;
            sendReportBtn.FlatStyle = FlatStyle.Flat;
            sendReportBtn.ForeColor = Color.White;
            sendReportBtn.Location = new Point(1216, 852);
            sendReportBtn.Margin = new Padding(2);
            sendReportBtn.Name = "sendReportBtn";
            sendReportBtn.Size = new Size(112, 28);
            sendReportBtn.TabIndex = 2;
            sendReportBtn.Text = "Send Report";
            sendReportBtn.UseVisualStyleBackColor = false;
            sendReportBtn.Click += SendReportBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.FromArgb(128, 128, 128);
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.DialogResult = DialogResult.Cancel;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.ForeColor = Color.White;
            closeBtn.Location = new Point(1096, 852);
            closeBtn.Margin = new Padding(2);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(112, 28);
            closeBtn.TabIndex = 3;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = false;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = closeBtn;
            ClientSize = new Size(1393, 937);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReportForm";
            Padding = new Padding(16);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Property Inspection Report";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #region Controls
        private TextBox reportTextBox;
        #endregion

        private Panel mainPanel;
        private Label headerLabel;
        private Button sendReportBtn;
        private Button closeBtn;
    }
}
