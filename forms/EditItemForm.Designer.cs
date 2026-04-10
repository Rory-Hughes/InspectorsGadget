using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace InspectorsGadget.forms
{
    partial class EditItemForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            mainPanel = new System.Windows.Forms.Panel();
            typeLabel = new System.Windows.Forms.Label();
            typeComboBox = new System.Windows.Forms.ComboBox();
            nameLabel = new System.Windows.Forms.Label();
            itemNameTextBox = new System.Windows.Forms.TextBox();
            costLabel = new System.Windows.Forms.Label();
            repairCostTextBox = new System.Windows.Forms.TextBox();
            dynamicFieldsPanel = new System.Windows.Forms.Panel();
            notesLabel = new System.Windows.Forms.Label();
            notesTextBox = new System.Windows.Forms.TextBox();
            okBtn = new System.Windows.Forms.Button();
            cancelBtn = new System.Windows.Forms.Button();
            mainPanel.SuspendLayout();
            SuspendLayout();

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
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(16, 16);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(543, 689);
            mainPanel.TabIndex = 0;

            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            typeLabel.Location = new System.Drawing.Point(16, 16);
            typeLabel.Name = "typeLabel";
            typeLabel.TabIndex = 0;
            typeLabel.Text = "Item Type:";

            // Type is locked during editing — no SelectedIndexChanged wired here.
            typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            typeComboBox.Items.AddRange(new object[] { "Electrical", "Structural", "Appliance" });
            typeComboBox.Location = new System.Drawing.Point(16, 40);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new System.Drawing.Size(509, 28);
            typeComboBox.TabIndex = 1;

            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            nameLabel.Location = new System.Drawing.Point(16, 80);
            nameLabel.Name = "nameLabel";
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Item Name:";

            itemNameTextBox.Location = new System.Drawing.Point(16, 104);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.Size = new System.Drawing.Size(509, 27);
            itemNameTextBox.TabIndex = 3;

            costLabel.AutoSize = true;
            costLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            costLabel.Location = new System.Drawing.Point(16, 144);
            costLabel.Name = "costLabel";
            costLabel.TabIndex = 4;
            costLabel.Text = "Repair Cost ($):";

            repairCostTextBox.Location = new System.Drawing.Point(16, 168);
            repairCostTextBox.Name = "repairCostTextBox";
            repairCostTextBox.Size = new System.Drawing.Size(509, 27);
            repairCostTextBox.TabIndex = 5;

            dynamicFieldsPanel.AutoScroll = true;
            dynamicFieldsPanel.Location = new System.Drawing.Point(16, 208);
            dynamicFieldsPanel.Name = "dynamicFieldsPanel";
            dynamicFieldsPanel.Size = new System.Drawing.Size(509, 216);
            dynamicFieldsPanel.TabIndex = 6;

            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            notesLabel.Location = new System.Drawing.Point(16, 444);
            notesLabel.Name = "notesLabel";
            notesLabel.TabIndex = 7;
            notesLabel.Text = "Notes:";

            notesTextBox.Location = new System.Drawing.Point(16, 468);
            notesTextBox.Multiline = true;
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new System.Drawing.Size(509, 145);
            notesTextBox.TabIndex = 8;

            okBtn.BackColor = System.Drawing.Color.FromArgb(0, 105, 111);
            okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            okBtn.ForeColor = System.Drawing.Color.White;
            okBtn.Location = new System.Drawing.Point(421, 642);
            okBtn.Name = "okBtn";
            okBtn.Size = new System.Drawing.Size(104, 28);
            okBtn.TabIndex = 9;
            okBtn.Text = "Save Changes";
            okBtn.UseVisualStyleBackColor = false;
            okBtn.Click += OkBtn_Click;

            cancelBtn.BackColor = System.Drawing.Color.FromArgb(128, 128, 128);
            cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cancelBtn.ForeColor = System.Drawing.Color.White;
            cancelBtn.Location = new System.Drawing.Point(325, 642);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new System.Drawing.Size(88, 28);
            cancelBtn.TabIndex = 10;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;

            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = cancelBtn;
            ClientSize = new System.Drawing.Size(575, 721);
            Controls.Add(mainPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditItemForm";
            Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Edit Inspection Item";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #region Controls
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox repairCostTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Panel dynamicFieldsPanel;
        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}
