namespace InventoryApp
{
    partial class frmMain
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblParts = new System.Windows.Forms.Label();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnDetele = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripDropDownButton();
            this.partsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.partsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(731, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(403, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(269, 33);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "ACME INVENTORY";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProducts);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.lblParts);
            this.groupBox1.Controls.Add(this.dgvParts);
            this.groupBox1.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1050, 543);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parts and Products";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(303, 294);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(444, 26);
            this.lblProducts.TabIndex = 6;
            this.lblProducts.Text = "Products Inventory List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 199);
            this.dataGridView1.TabIndex = 5;
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParts.Location = new System.Drawing.Point(335, 16);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(381, 26);
            this.lblParts.TabIndex = 4;
            this.lblParts.Text = "Parts Inventory List";
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.AllowUserToDeleteRows = false;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(16, 53);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.Size = new System.Drawing.Size(1024, 199);
            this.dgvParts.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.toolStripSeparator1,
            this.tsbtnEdit,
            this.toolStripSeparator2,
            this.tsbtnDetele,
            this.toolStripSeparator3,
            this.tsbtnSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1074, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnDetele
            // 
            this.tsbtnDetele.Image = global::InventoryApp.Properties.Resources.icons8_trash_can_64;
            this.tsbtnDetele.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDetele.Name = "tsbtnDetele";
            this.tsbtnDetele.Size = new System.Drawing.Size(131, 22);
            this.tsbtnDetele.Text = "Delete Part/Product";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnSearch
            // 
            this.tsbtnSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnSearch.Image = global::InventoryApp.Properties.Resources.icons8_search_64;
            this.tsbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(62, 22);
            this.tsbtnSearch.Text = "Search";
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partsToolStripMenuItem,
            this.productToolStripMenuItem});
            this.tsbtnAdd.Image = global::InventoryApp.Properties.Resources.icons8_create_64;
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(58, 22);
            this.tsbtnAdd.Text = "Add";
            this.tsbtnAdd.Click += new System.EventHandler(this.TsbtnAdd_Click);
            // 
            // partsToolStripMenuItem
            // 
            this.partsToolStripMenuItem.Name = "partsToolStripMenuItem";
            this.partsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.partsToolStripMenuItem.Text = "Parts";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // tsbtnEdit
            // 
            this.tsbtnEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partsToolStripMenuItem1,
            this.productsToolStripMenuItem});
            this.tsbtnEdit.Image = global::InventoryApp.Properties.Resources.icons8_edit_64;
            this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEdit.Name = "tsbtnEdit";
            this.tsbtnEdit.Size = new System.Drawing.Size(74, 22);
            this.tsbtnEdit.Text = "Modify";
            // 
            // partsToolStripMenuItem1
            // 
            this.partsToolStripMenuItem1.Name = "partsToolStripMenuItem1";
            this.partsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.partsToolStripMenuItem1.Text = "Parts";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 636);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearch);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnDetele;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnAdd;
        private System.Windows.Forms.ToolStripMenuItem partsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnEdit;
        private System.Windows.Forms.ToolStripMenuItem partsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
    }
}

