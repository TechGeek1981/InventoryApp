namespace InventoryApp
{
    partial class frmAddMod
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
            this.grpbxPartType = new System.Windows.Forms.GroupBox();
            this.rdoOutsourced = new System.Windows.Forms.RadioButton();
            this.rdoInHouse = new System.Windows.Forms.RadioButton();
            this.grpbxPartInfo = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblPartInventory = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblPrice_Cost = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtPriceCost = new System.Windows.Forms.TextBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.lblCompName = new System.Windows.Forms.Label();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpbxPartType.SuspendLayout();
            this.grpbxPartInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxPartType
            // 
            this.grpbxPartType.Controls.Add(this.rdoOutsourced);
            this.grpbxPartType.Controls.Add(this.rdoInHouse);
            this.grpbxPartType.Font = new System.Drawing.Font("High Tower Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxPartType.Location = new System.Drawing.Point(12, 12);
            this.grpbxPartType.Name = "grpbxPartType";
            this.grpbxPartType.Size = new System.Drawing.Size(276, 76);
            this.grpbxPartType.TabIndex = 18;
            this.grpbxPartType.TabStop = false;
            this.grpbxPartType.Text = "Type of Part";
            // 
            // rdoOutsourced
            // 
            this.rdoOutsourced.AutoSize = true;
            this.rdoOutsourced.Image = global::InventoryApp.Properties.Resources.icons8_factory_28;
            this.rdoOutsourced.Location = new System.Drawing.Point(135, 29);
            this.rdoOutsourced.Name = "rdoOutsourced";
            this.rdoOutsourced.Size = new System.Drawing.Size(127, 28);
            this.rdoOutsourced.TabIndex = 1;
            this.rdoOutsourced.TabStop = true;
            this.rdoOutsourced.Text = "Outsourced";
            this.rdoOutsourced.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdoOutsourced.UseVisualStyleBackColor = true;
            // 
            // rdoInHouse
            // 
            this.rdoInHouse.AutoSize = true;
            this.rdoInHouse.Image = global::InventoryApp.Properties.Resources.icons8_house_30;
            this.rdoInHouse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rdoInHouse.Location = new System.Drawing.Point(15, 29);
            this.rdoInHouse.Name = "rdoInHouse";
            this.rdoInHouse.Size = new System.Drawing.Size(114, 30);
            this.rdoInHouse.TabIndex = 0;
            this.rdoInHouse.TabStop = true;
            this.rdoInHouse.Text = "In-House";
            this.rdoInHouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rdoInHouse.UseVisualStyleBackColor = true;
            // 
            // grpbxPartInfo
            // 
            this.grpbxPartInfo.Controls.Add(this.txtID);
            this.grpbxPartInfo.Controls.Add(this.lbl_Id);
            this.grpbxPartInfo.Controls.Add(this.label2);
            this.grpbxPartInfo.Controls.Add(this.txtCompanyName);
            this.grpbxPartInfo.Controls.Add(this.lblPartInventory);
            this.grpbxPartInfo.Controls.Add(this.txtMax);
            this.grpbxPartInfo.Controls.Add(this.lblPrice_Cost);
            this.grpbxPartInfo.Controls.Add(this.txtMin);
            this.grpbxPartInfo.Controls.Add(this.lblMin);
            this.grpbxPartInfo.Controls.Add(this.txtPriceCost);
            this.grpbxPartInfo.Controls.Add(this.lblMax);
            this.grpbxPartInfo.Controls.Add(this.txtInventory);
            this.grpbxPartInfo.Controls.Add(this.lblCompName);
            this.grpbxPartInfo.Controls.Add(this.txtPartName);
            this.grpbxPartInfo.Font = new System.Drawing.Font("High Tower Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxPartInfo.Location = new System.Drawing.Point(12, 94);
            this.grpbxPartInfo.Name = "grpbxPartInfo";
            this.grpbxPartInfo.Size = new System.Drawing.Size(396, 324);
            this.grpbxPartInfo.TabIndex = 21;
            this.grpbxPartInfo.TabStop = false;
            this.grpbxPartInfo.Text = "Part Information";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(161, 39);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(142, 23);
            this.txtID.TabIndex = 8;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(23, 42);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(54, 15);
            this.lbl_Id.TabIndex = 1;
            this.lbl_Id.Text = "Part ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Part Name";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(161, 279);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(142, 23);
            this.txtCompanyName.TabIndex = 14;
            // 
            // lblPartInventory
            // 
            this.lblPartInventory.AutoSize = true;
            this.lblPartInventory.Location = new System.Drawing.Point(23, 136);
            this.lblPartInventory.Name = "lblPartInventory";
            this.lblPartInventory.Size = new System.Drawing.Size(97, 15);
            this.lblPartInventory.TabIndex = 3;
            this.lblPartInventory.Text = "Part Inventory";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(275, 230);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(61, 23);
            this.txtMax.TabIndex = 13;
            // 
            // lblPrice_Cost
            // 
            this.lblPrice_Cost.AutoSize = true;
            this.lblPrice_Cost.Location = new System.Drawing.Point(23, 183);
            this.lblPrice_Cost.Name = "lblPrice_Cost";
            this.lblPrice_Cost.Size = new System.Drawing.Size(78, 15);
            this.lblPrice_Cost.TabIndex = 4;
            this.lblPrice_Cost.Text = "Price/Cost";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(161, 230);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(61, 23);
            this.txtMin.TabIndex = 12;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(237, 233);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(32, 15);
            this.lblMin.TabIndex = 5;
            this.lblMin.Text = "Min";
            // 
            // txtPriceCost
            // 
            this.txtPriceCost.Location = new System.Drawing.Point(161, 183);
            this.txtPriceCost.Name = "txtPriceCost";
            this.txtPriceCost.Size = new System.Drawing.Size(142, 23);
            this.txtPriceCost.TabIndex = 11;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(23, 238);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(35, 15);
            this.lblMax.TabIndex = 6;
            this.lblMax.Text = "Max";
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(161, 140);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(142, 23);
            this.txtInventory.TabIndex = 10;
            // 
            // lblCompName
            // 
            this.lblCompName.AutoSize = true;
            this.lblCompName.Location = new System.Drawing.Point(23, 282);
            this.lblCompName.Name = "lblCompName";
            this.lblCompName.Size = new System.Drawing.Size(105, 15);
            this.lblCompName.TabIndex = 7;
            this.lblCompName.Text = "Company Name";
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(161, 96);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(142, 23);
            this.txtPartName.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::InventoryApp.Properties.Resources.icons8_save_as_32;
            this.btnSave.Location = new System.Drawing.Point(12, 424);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 46);
            this.btnSave.TabIndex = 19;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InventoryApp.Properties.Resources.icons8_cancel_32;
            this.btnCancel.Location = new System.Drawing.Point(348, 424);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 46);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 481);
            this.Controls.Add(this.grpbxPartType);
            this.Controls.Add(this.grpbxPartInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmAddMod";
            this.Text = "AddPart";
            this.Load += new System.EventHandler(this.AddPart_Load);
            this.grpbxPartType.ResumeLayout(false);
            this.grpbxPartType.PerformLayout();
            this.grpbxPartInfo.ResumeLayout(false);
            this.grpbxPartInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxPartType;
        private System.Windows.Forms.RadioButton rdoOutsourced;
        private System.Windows.Forms.RadioButton rdoInHouse;
        private System.Windows.Forms.GroupBox grpbxPartInfo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblPartInventory;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label lblPrice_Cost;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox txtPriceCost;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.Label lblCompName;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}