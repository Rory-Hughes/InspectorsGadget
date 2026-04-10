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
            mainPanel.Location = new Point(16, 16);
            mainPanel.Margin = new Padding(2, 2, 2, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(543, 689);
            mainPanel.TabIndex = 0;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            typeLabel.Location = new Point(16, 16);
            typeLabel.Margin = new Padding(2, 0, 2, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(95, 23);
            typeLabel.TabIndex = 0;
            typeLabel.Text = "Item Type:";
            // 
            // typeComboBox
            // 
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeComboBox.Items.AddRange(new object[] { "Electrical", "Structural", "Appliance" });
            typeComboBox.Location = new Point(16, 40);
            typeComboBox.Margin = new Padding(2, 2, 2, 2);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(509, 28);
            typeComboBox.TabIndex = 1;
            typeComboBox.SelectedIndexChanged += TypeComboBox_SelectedIndexChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            nameLabel.Location = new Point(16, 80);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(104, 23);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Item Name:";
            // 
            // itemNameTextBox
            // 
            itemNameTextBox.Location = new Point(16, 104);
            itemNameTextBox.Margin = new Padding(2, 2, 2, 2);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.Size = new Size(509, 27);
            itemNameTextBox.TabIndex = 3;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            costLabel.Location = new Point(16, 144);
            costLabel.Margin = new Padding(2, 0, 2, 0);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(134, 23);
            costLabel.TabIndex = 4;
            costLabel.Text = "Repair Cost ($):";
            // 
            // repairCostTextBox
            // 
            repairCostTextBox.Location = new Point(16, 168);
            repairCostTextBox.Margin = new Padding(2, 2, 2, 2);
            repairCostTextBox.Name = "repairCostTextBox";
            repairCostTextBox.Size = new Size(509, 27);
            repairCostTextBox.TabIndex = 5;
            // 
            // dynamicFieldsPanel
            // 
            dynamicFieldsPanel.AutoScroll = true;
            dynamicFieldsPanel.Location = new Point(16, 208);
            dynamicFieldsPanel.Margin = new Padding(2, 2, 2, 2);
            dynamicFieldsPanel.Name = "dynamicFieldsPanel";
            dynamicFieldsPanel.Size = new Size(509, 216);
            dynamicFieldsPanel.TabIndex = 6;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            notesLabel.Location = new Point(16, 444);
            notesLabel.Margin = new Padding(2, 0, 2, 0);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(61, 23);
            notesLabel.TabIndex = 7;
            notesLabel.Text = "Notes:";
            // 
            // notesTextBox
            // 
            notesTextBox.Location = new Point(16, 468);
            notesTextBox.Margin = new Padding(2, 2, 2, 2);
            notesTextBox.Multiline = true;
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(509, 145);
            notesTextBox.TabIndex = 8;
            // 
            // okBtn
            // 
            okBtn.BackColor = Color.FromArgb(0, 105, 111);
            okBtn.Cursor = Cursors.Hand;
            okBtn.FlatStyle = FlatStyle.Flat;
            okBtn.ForeColor = Color.White;
            okBtn.Location = new Point(437, 642);
            okBtn.Margin = new Padding(2, 2, 2, 2);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(88, 28);
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
            cancelBtn.Location = new Point(341, 642);
            cancelBtn.Margin = new Padding(2, 2, 2, 2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(88, 28);
            cancelBtn.TabIndex = 10;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelBtn;
            ClientSize = new Size(575, 721);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddItemForm";
            Padding = new Padding(16, 16, 16, 16);
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
