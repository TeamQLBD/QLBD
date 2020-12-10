
namespace QLBanDay
{
    partial class fProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvShowProduct = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchProduct = new FontAwesome.Sharp.IconPictureBox();
            this.btnAddProduct = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowProduct)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.dgvShowProduct);
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 551);
            this.panel1.TabIndex = 5;
            // 
            // dgvShowProduct
            // 
            this.dgvShowProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(45)))));
            this.dgvShowProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.nameProduct,
            this.count,
            this.priceProduct,
            this.statusProduct,
            this.descriptionProduct});
            this.dgvShowProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvShowProduct.Name = "dgvShowProduct";
            this.dgvShowProduct.Size = new System.Drawing.Size(1079, 551);
            this.dgvShowProduct.TabIndex = 0;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // nameProduct
            // 
            this.nameProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameProduct.HeaderText = "Tên sản phẩm";
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.ReadOnly = true;
            // 
            // count
            // 
            this.count.HeaderText = "Số lượng";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // priceProduct
            // 
            this.priceProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceProduct.HeaderText = "Giá";
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.ReadOnly = true;
            // 
            // statusProduct
            // 
            this.statusProduct.HeaderText = "Trạng thái";
            this.statusProduct.Name = "statusProduct";
            this.statusProduct.ReadOnly = true;
            // 
            // descriptionProduct
            // 
            this.descriptionProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionProduct.HeaderText = "Mô tả";
            this.descriptionProduct.Name = "descriptionProduct";
            this.descriptionProduct.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.btnSearchProduct);
            this.panel2.Controls.Add(this.btnAddProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 50);
            this.panel2.TabIndex = 6;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnSearchProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchProduct.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchProduct.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchProduct.Location = new System.Drawing.Point(895, 13);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(32, 32);
            this.btnSearchProduct.TabIndex = 1;
            this.btnSearchProduct.TabStop = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnAddProduct.CausesValidation = false;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddProduct.IconColor = System.Drawing.Color.White;
            this.btnAddProduct.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAddProduct.IconSize = 25;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(760, 12);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(113, 33);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Thêm mới";
            this.btnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(857, -44);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // fProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 607);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.fProduct_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvShowProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionProduct;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnAddProduct;
        private FontAwesome.Sharp.IconPictureBox btnSearchProduct;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}