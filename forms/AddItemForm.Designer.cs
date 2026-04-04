namespace InspectorsGadget
{
    partial class AddItemForm
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
            typeLabel = new Label();
            typeComboBox = new ComboBox();
            nameLabel = new Label();
            itemNameTextBox = new TextBox();
            costLabel = new Label();
            repairCostTextBox = new TextBox();
            dynamicFieldsPanel = new Panel();
            notesLabel = new Label();
            notesTextBox = new TextBox();
            okBtn = new Button();
            cancelBtn = new Button();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.Controls.Add(typeLabel);
            mainPanel.Controls.Add(typeComboBox);
            mainPanel.Controls.Add(nameLabel);
            mainPanel.Controls.Add(itemNameTextBox);
            mainPanel.Controls.Add(costLabel);
            mainPanel.Controls.Add(repairCostTextBox);
            mainPanel.Controls.Add(dynamicFieldsPanel);
            mainPanel.Controls.Add(notesLabel);
            mainPanel.Controls.Add(notesTextBox);
            mainPanel.Controls.Add(okBtn);
            mainPanel.Controls.Add(cancelBtn);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(20, 20);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(525, 683);
            mainPanel.TabIndex = 0;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            typeLabel.Location = new Point(20, 20);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(111, 28);
            typeLabel.TabIndex = 0;
            typeLabel.Text = "Item Type:";
            // 
            // typeComboBox
            // 
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeComboBox.Items.AddRange(new object[] { "Electrical", "Structural", "Appliance" });
            typeComboBox.Location = new Point(20, 50);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(440, 33);
            typeComboBox.TabIndex = 1;
            typeComboBox.SelectedIndexChanged += TypeComboBox_SelectedIndexChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            nameLabel.Location = new Point(20, 100);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(122, 28);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Item Name:";
            // 
            // itemNameTextBox
            // 
            itemNameTextBox.Location = new Point(20, 130);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.Size = new Size(440, 31);
            itemNameTextBox.TabIndex = 3;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            costLabel.Location = new Point(20, 180);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(157, 28);
            costLabel.TabIndex = 4;
            costLabel.Text = "Repair Cost ($):";
            // 
            // repairCostTextBox
            // 
            repairCostTextBox.Location = new Point(20, 210);
            repairCostTextBox.Name = "repairCostTextBox";
            repairCostTextBox.Size = new Size(440, 31);
            repairCostTextBox.TabIndex = 5;
            // 
            // dynamicFieldsPanel
            // 
            dynamicFieldsPanel.AutoScroll = true;
            dynamicFieldsPanel.Location = new Point(20, 260);
            dynamicFieldsPanel.Name = "dynamicFieldsPanel";
            dynamicFieldsPanel.Size = new Size(440, 200);
            dynamicFieldsPanel.TabIndex = 6;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            notesLabel.Location = new Point(20, 480);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(73, 28);
            notesLabel.TabIndex = 7;
            notesLabel.Text = "Notes:";
            // 
            // notesTextBox
            // 
            notesTextBox.Location = new Point(20, 510);
            notesTextBox.Multiline = true;
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(440, 60);
            notesTextBox.TabIndex = 8;
            // 
            // okBtn
            // 
            okBtn.BackColor = Color.FromArgb(0, 105, 111);
            okBtn.Cursor = Cursors.Hand;
            okBtn.FlatStyle = FlatStyle.Flat;
            okBtn.ForeColor = Color.White;
            okBtn.Location = new Point(350, 580);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(110, 35);
            okBtn.TabIndex = 9;
            okBtn.Text = "Add Item";
            okBtn.UseVisualStyleBackColor = false;
            okBtn.Click += OkBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(128, 128, 128);
            cancelBtn.Cursor = Cursors.Hand;
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(230, 580);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(110, 35);
            cancelBtn.TabIndex = 10;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelBtn;
            ClientSize = new Size(565, 723);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddItemForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Inspection Item";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #region Controls
        private ComboBox typeComboBox;
        private TextBox itemNameTextBox;
        private TextBox repairCostTextBox;
        private TextBox notesTextBox;
        private Panel dynamicFieldsPanel;
        #endregion

        private Panel mainPanel;
        private Label typeLabel;
        private Label nameLabel;
        private Label costLabel;
        private Label notesLabel;
        private Button okBtn;
        private Button cancelBtn;
    }
}
