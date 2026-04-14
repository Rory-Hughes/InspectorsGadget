namespace InspectorsGadget.forms
{
    partial class StartupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panHeader = new Panel();
            lblHeaderSub = new Label();
            lblHeaderTitle = new Label();
            panChoice = new Panel();
            lblError = new Label();
            btnLoad = new Button();
            btnNew = new Button();
            lblChoice = new Label();
            panNew = new Panel();
            btnStart = new Button();
            btnBack = new Button();
            txtInspector = new TextBox();
            lblInspector = new Label();
            btnBrowse = new Button();
            txtFile = new TextBox();
            lblFile = new Label();
            label1 = new Label();
            lblNewTitle = new Label();
            panHeader.SuspendLayout();
            panChoice.SuspendLayout();
            panNew.SuspendLayout();
            SuspendLayout();
            // 
            // panHeader
            // 
            panHeader.BackColor = Color.FromArgb(0, 105, 111);
            panHeader.Controls.Add(lblHeaderSub);
            panHeader.Controls.Add(lblHeaderTitle);
            panHeader.Dock = DockStyle.Top;
            panHeader.Location = new Point(0, 0);
            panHeader.Name = "panHeader";
            panHeader.Size = new Size(520, 88);
            panHeader.TabIndex = 0;
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.AutoSize = true;
            lblHeaderSub.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeaderSub.ForeColor = Color.FromArgb(180, 220, 222);
            lblHeaderSub.Location = new Point(26, 52);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(266, 23);
            lblHeaderSub.TabIndex = 1;
            lblHeaderSub.Text = "Property Inspection Management";
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(24, 14);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(274, 41);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Inspectors Gadget";
            // 
            // panChoice
            // 
            panChoice.BackColor = Color.Transparent;
            panChoice.Controls.Add(lblError);
            panChoice.Controls.Add(btnLoad);
            panChoice.Controls.Add(btnNew);
            panChoice.Controls.Add(lblChoice);
            panChoice.Location = new Point(0, 88);
            panChoice.Margin = new Padding(0);
            panChoice.Name = "panChoice";
            panChoice.Size = new Size(520, 332);
            panChoice.TabIndex = 1;
            // 
            // lblError
            // 
            lblError.ForeColor = Color.FromArgb(161, 44, 123);
            lblError.Location = new Point(24, 222);
            lblError.Name = "lblError";
            lblError.Size = new Size(472, 52);
            lblError.TabIndex = 5;
            lblError.Visible = false;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.White;
            btnLoad.Cursor = Cursors.Hand;
            btnLoad.FlatAppearance.BorderColor = Color.FromArgb(0, 105, 111);
            btnLoad.FlatAppearance.BorderSize = 2;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.FromArgb(0, 105, 111);
            btnLoad.Location = new Point(276, 80);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(220, 120);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Open Existing\r\nReport";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(0, 105, 111);
            btnNew.Cursor = Cursors.Hand;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(24, 80);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(220, 120);
            btnNew.TabIndex = 3;
            btnNew.Text = "+ New Inspection\r\nReport";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // lblChoice
            // 
            lblChoice.AutoSize = true;
            lblChoice.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChoice.ForeColor = Color.FromArgb(40, 37, 29);
            lblChoice.Location = new Point(24, 32);
            lblChoice.Name = "lblChoice";
            lblChoice.Size = new Size(269, 25);
            lblChoice.TabIndex = 2;
            lblChoice.Text = "How would you like to proceed?";
            // 
            // panNew
            // 
            panNew.Controls.Add(btnStart);
            panNew.Controls.Add(btnBack);
            panNew.Controls.Add(txtInspector);
            panNew.Controls.Add(lblInspector);
            panNew.Controls.Add(btnBrowse);
            panNew.Controls.Add(txtFile);
            panNew.Controls.Add(lblFile);
            panNew.Controls.Add(label1);
            panNew.Controls.Add(lblNewTitle);
            panNew.Location = new Point(0, 88);
            panNew.Margin = new Padding(0);
            panNew.Name = "panNew";
            panNew.Size = new Size(520, 332);
            panNew.TabIndex = 6;
            panNew.Visible = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(0, 105, 111);
            btnStart.Cursor = Cursors.Hand;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(344, 262);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(152, 32);
            btnStart.TabIndex = 9;
            btnStart.Text = "Start Inspection →";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(237, 234, 229);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(212, 209, 202);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(24, 262);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 32);
            btnBack.TabIndex = 8;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtInspector
            // 
            txtInspector.Location = new Point(24, 160);
            txtInspector.Name = "txtInspector";
            txtInspector.PlaceholderText = "Full name of the inspector signing this report.";
            txtInspector.Size = new Size(472, 27);
            txtInspector.TabIndex = 7;
            // 
            // lblInspector
            // 
            lblInspector.AutoSize = true;
            lblInspector.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInspector.ForeColor = Color.FromArgb(40, 37, 29);
            lblInspector.Location = new Point(24, 138);
            lblInspector.Name = "lblInspector";
            lblInspector.Size = new Size(121, 20);
            lblInspector.TabIndex = 6;
            lblInspector.Text = "Inspector Name";
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(237, 234, 229);
            btnBrowse.Cursor = Cursors.Hand;
            btnBrowse.FlatAppearance.BorderColor = Color.FromArgb(212, 209, 202);
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Location = new Point(416, 91);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(80, 29);
            btnBrowse.TabIndex = 5;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtFile
            // 
            txtFile.Location = new Point(24, 92);
            txtFile.Name = "txtFile";
            txtFile.PlaceholderText = "Enter a filename...";
            txtFile.Size = new Size(384, 27);
            txtFile.TabIndex = 4;
            // 
            // lblFile
            // 
            lblFile.Anchor = AnchorStyles.None;
            lblFile.AutoSize = true;
            lblFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFile.ForeColor = Color.FromArgb(40, 37, 29);
            lblFile.Location = new Point(24, 70);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(115, 20);
            lblFile.TabIndex = 3;
            lblFile.Text = "Save Report As";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.FromArgb(212, 209, 202);
            label1.Location = new Point(24, 54);
            label1.Name = "label1";
            label1.Size = new Size(472, 1);
            label1.TabIndex = 2;
            // 
            // lblNewTitle
            // 
            lblNewTitle.Anchor = AnchorStyles.None;
            lblNewTitle.AutoSize = true;
            lblNewTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewTitle.ForeColor = Color.FromArgb(40, 37, 29);
            lblNewTitle.Location = new Point(24, 24);
            lblNewTitle.Name = "lblNewTitle";
            lblNewTitle.Size = new Size(230, 28);
            lblNewTitle.TabIndex = 0;
            lblNewTitle.Text = "New Inspection Report";
            // 
            // StartupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 248, 245);
            ClientSize = new Size(520, 420);
            Controls.Add(panNew);
            Controls.Add(panChoice);
            Controls.Add(panHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StartupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inspectors Gadget";
            panHeader.ResumeLayout(false);
            panHeader.PerformLayout();
            panChoice.ResumeLayout(false);
            panChoice.PerformLayout();
            panNew.ResumeLayout(false);
            panNew.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panHeader;
        private Label lblHeaderSub;
        private Label lblHeaderTitle;
        private Panel panChoice;
        private Button btnLoad;
        private Button btnNew;
        private Label lblChoice;
        private Label lblError;
        private Panel panNew;
        private Label lblNewTitle;
        private Label label1;
        private Label lblFile;
        private TextBox txtFile;
        private Label lblInspector;
        private Button btnBrowse;
        private TextBox txtInspector;
        private Button btnBack;
        private Button btnStart;
    }
}