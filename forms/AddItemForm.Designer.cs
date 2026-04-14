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
            panMain = new Panel();
            lblItemType = new Label();
            cboItemType = new ComboBox();
            lblItemName = new Label();
            txtItemName = new TextBox();
            lblRepairCost = new Label();
            txtRepairCost = new TextBox();
            panDynamicFields = new Panel();
            lblNotes = new Label();
            txtNotes = new TextBox();
            btnAddItem = new Button();
            btnCancel = new Button();
            panMain.SuspendLayout();
            SuspendLayout();
            // 
            // panMain
            // 
            panMain.AutoScroll = true;
            panMain.Controls.Add(lblItemType);
            panMain.Controls.Add(cboItemType);
            panMain.Controls.Add(lblItemName);
            panMain.Controls.Add(txtItemName);
            panMain.Controls.Add(lblRepairCost);
            panMain.Controls.Add(txtRepairCost);
            panMain.Controls.Add(panDynamicFields);
            panMain.Controls.Add(lblNotes);
            panMain.Controls.Add(txtNotes);
            panMain.Controls.Add(btnAddItem);
            panMain.Controls.Add(btnCancel);
            panMain.Dock = DockStyle.Fill;
            panMain.Location = new Point(16, 16);
            panMain.Margin = new Padding(2);
            panMain.Name = "panMain";
            panMain.Size = new Size(543, 689);
            panMain.TabIndex = 0;
            // 
            // lblItemType
            // 
            lblItemType.AutoSize = true;
            lblItemType.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblItemType.Location = new Point(16, 16);
            lblItemType.Margin = new Padding(2, 0, 2, 0);
            lblItemType.Name = "lblItemType";
            lblItemType.Size = new Size(95, 23);
            lblItemType.TabIndex = 0;
            lblItemType.Text = "Item Type:";
            // 
            // cboItemType
            // 
            cboItemType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboItemType.Items.AddRange(new object[] { "Electrical", "Structural", "Appliance" });
            cboItemType.Location = new Point(16, 40);
            cboItemType.Margin = new Padding(2);
            cboItemType.Name = "cboItemType";
            cboItemType.Size = new Size(509, 28);
            cboItemType.TabIndex = 1;
            cboItemType.SelectedIndexChanged += TypeComboBox_SelectedIndexChanged;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblItemName.Location = new Point(16, 80);
            lblItemName.Margin = new Padding(2, 0, 2, 0);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(104, 23);
            lblItemName.TabIndex = 2;
            lblItemName.Text = "Item Name:";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(16, 104);
            txtItemName.Margin = new Padding(2);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(509, 27);
            txtItemName.TabIndex = 3;
            // 
            // lblRepairCost
            // 
            lblRepairCost.AutoSize = true;
            lblRepairCost.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRepairCost.Location = new Point(16, 144);
            lblRepairCost.Margin = new Padding(2, 0, 2, 0);
            lblRepairCost.Name = "lblRepairCost";
            lblRepairCost.Size = new Size(134, 23);
            lblRepairCost.TabIndex = 4;
            lblRepairCost.Text = "Repair Cost ($):";
            // 
            // txtRepairCost
            // 
            txtRepairCost.Location = new Point(16, 168);
            txtRepairCost.Margin = new Padding(2);
            txtRepairCost.Name = "txtRepairCost";
            txtRepairCost.Size = new Size(509, 27);
            txtRepairCost.TabIndex = 5;
            // 
            // panDynamicFields
            // 
            panDynamicFields.AutoScroll = true;
            panDynamicFields.Location = new Point(16, 208);
            panDynamicFields.Margin = new Padding(2);
            panDynamicFields.Name = "panDynamicFields";
            panDynamicFields.Size = new Size(509, 216);
            panDynamicFields.TabIndex = 6;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNotes.Location = new Point(16, 444);
            lblNotes.Margin = new Padding(2, 0, 2, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(61, 23);
            lblNotes.TabIndex = 7;
            lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(16, 468);
            txtNotes.Margin = new Padding(2);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(509, 145);
            txtNotes.TabIndex = 8;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(0, 105, 111);
            btnAddItem.Cursor = Cursors.Hand;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.ForeColor = Color.White;
            btnAddItem.Location = new Point(437, 642);
            btnAddItem.Margin = new Padding(2);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(88, 28);
            btnAddItem.TabIndex = 9;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += OkBtn_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(128, 128, 128);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(341, 642);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 28);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(575, 721);
            Controls.Add(panMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddItemForm";
            Padding = new Padding(16);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Inspection Item";
            panMain.ResumeLayout(false);
            panMain.PerformLayout();
            ResumeLayout(false);
        }

        #region Controls
        private ComboBox cboItemType;
        private TextBox txtItemName;
        private TextBox txtRepairCost;
        private TextBox txtNotes;
        private Panel panDynamicFields;
        #endregion

        private Panel panMain;
        private Label lblItemType;
        private Label lblItemName;
        private Label lblRepairCost;
        private Label lblNotes;
        private Button btnAddItem;
        private Button btnCancel;
    }
}
