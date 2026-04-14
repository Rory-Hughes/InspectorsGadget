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
            lblNotes = new Label();
            txtNotes = new TextBox();
            btnAddItem = new Button();
            btnCancel = new Button();
            panAppliance = new Panel();
            chkIsOperational = new CheckBox();
            txtAge = new TextBox();
            lblAge = new Label();
            panStructural = new Panel();
            chkHasWaterDamage = new CheckBox();
            chkHasVisibleCracks = new CheckBox();
            panElectrical = new Panel();
            chkHasGrounding = new CheckBox();
            txtAmp = new TextBox();
            lblAmp = new Label();
            panMain.SuspendLayout();
            panAppliance.SuspendLayout();
            panStructural.SuspendLayout();
            panElectrical.SuspendLayout();
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
            panMain.Controls.Add(lblNotes);
            panMain.Controls.Add(txtNotes);
            panMain.Controls.Add(btnAddItem);
            panMain.Controls.Add(btnCancel);
            panMain.Controls.Add(panElectrical);
            panMain.Controls.Add(panAppliance);
            panMain.Controls.Add(panStructural);
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
            // panAppliance
            // 
            panAppliance.AutoScroll = true;
            panAppliance.Controls.Add(chkIsOperational);
            panAppliance.Controls.Add(txtAge);
            panAppliance.Controls.Add(lblAge);
            panAppliance.Location = new Point(16, 208);
            panAppliance.Margin = new Padding(2);
            panAppliance.Name = "panAppliance";
            panAppliance.Size = new Size(509, 216);
            panAppliance.TabIndex = 6;
            // 
            // chkIsOperational
            // 
            chkIsOperational.AutoSize = true;
            chkIsOperational.Checked = true;
            chkIsOperational.CheckState = CheckState.Checked;
            chkIsOperational.Location = new Point(10, 80);
            chkIsOperational.Name = "chkIsOperational";
            chkIsOperational.Size = new Size(131, 24);
            chkIsOperational.TabIndex = 2;
            chkIsOperational.Text = "Is Operational?";
            chkIsOperational.UseVisualStyleBackColor = true;
            chkIsOperational.Visible = false;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(10, 35);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(400, 27);
            txtAge.TabIndex = 1;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(10, 10);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(94, 20);
            lblAge.TabIndex = 0;
            lblAge.Text = "Age (Years):";
            // 
            // panStructural
            // 
            panStructural.AutoScroll = true;
            panStructural.Controls.Add(chkHasWaterDamage);
            panStructural.Controls.Add(chkHasVisibleCracks);
            panStructural.Location = new Point(16, 208);
            panStructural.Margin = new Padding(2);
            panStructural.Name = "panStructural";
            panStructural.Size = new Size(509, 216);
            panStructural.TabIndex = 7;
            panStructural.Visible = false;
            // 
            // chkHasWaterDamage
            // 
            chkHasWaterDamage.AutoSize = true;
            chkHasWaterDamage.Location = new Point(10, 60);
            chkHasWaterDamage.Name = "chkHasWaterDamage";
            chkHasWaterDamage.Size = new Size(167, 24);
            chkHasWaterDamage.TabIndex = 1;
            chkHasWaterDamage.Text = "Has Water Damage?";
            chkHasWaterDamage.UseVisualStyleBackColor = true;
            // 
            // chkHasVisibleCracks
            // 
            chkHasVisibleCracks.AutoSize = true;
            chkHasVisibleCracks.Location = new Point(10, 10);
            chkHasVisibleCracks.Name = "chkHasVisibleCracks";
            chkHasVisibleCracks.Size = new Size(157, 24);
            chkHasVisibleCracks.TabIndex = 0;
            chkHasVisibleCracks.Text = "Has Visible Cracks?";
            chkHasVisibleCracks.UseVisualStyleBackColor = true;
            // 
            // panElectrical
            // 
            panElectrical.AutoScroll = true;
            panElectrical.Controls.Add(chkHasGrounding);
            panElectrical.Controls.Add(txtAmp);
            panElectrical.Controls.Add(lblAmp);
            panElectrical.Location = new Point(16, 208);
            panElectrical.Margin = new Padding(2);
            panElectrical.Name = "panElectrical";
            panElectrical.Size = new Size(509, 216);
            panElectrical.TabIndex = 7;
            panElectrical.Visible = false;
            // 
            // chkHasGrounding
            // 
            chkHasGrounding.AutoSize = true;
            chkHasGrounding.Location = new Point(10, 80);
            chkHasGrounding.Name = "chkHasGrounding";
            chkHasGrounding.Size = new Size(137, 24);
            chkHasGrounding.TabIndex = 2;
            chkHasGrounding.Text = "Has Grounding?";
            chkHasGrounding.UseVisualStyleBackColor = true;
            // 
            // txtAmp
            // 
            txtAmp.Location = new Point(10, 35);
            txtAmp.Name = "txtAmp";
            txtAmp.Size = new Size(400, 27);
            txtAmp.TabIndex = 1;
            // 
            // lblAmp
            // 
            lblAmp.AutoSize = true;
            lblAmp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmp.Location = new Point(10, 10);
            lblAmp.Name = "lblAmp";
            lblAmp.Size = new Size(97, 20);
            lblAmp.TabIndex = 0;
            lblAmp.Text = "Amp Rating:";
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
            panAppliance.ResumeLayout(false);
            panAppliance.PerformLayout();
            panStructural.ResumeLayout(false);
            panStructural.PerformLayout();
            panElectrical.ResumeLayout(false);
            panElectrical.PerformLayout();
            ResumeLayout(false);
        }

        #region Controls
        private ComboBox cboItemType;
        private TextBox txtItemName;
        private TextBox txtRepairCost;
        private TextBox txtNotes;
        private Panel panAppliance;
        #endregion

        private Panel panMain;
        private Label lblItemType;
        private Label lblItemName;
        private Label lblRepairCost;
        private Label lblNotes;
        private Button btnAddItem;
        private Button btnCancel;
        private Panel panStructural;
        private Panel panElectrical;
        private TextBox txtAmp;
        private Label lblAmp;
        private CheckBox chkHasGrounding;
        private CheckBox chkHasWaterDamage;
        private CheckBox chkHasVisibleCracks;
        private Label lblAge;
        private CheckBox chkIsOperational;
        private TextBox txtAge;
    }
}
