
namespace VendingMachine
{
    partial class Prouduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Product = new System.Windows.Forms.Button();
            this.Lbl_PriceText = new System.Windows.Forms.Label();
            this.Lbl_Price = new System.Windows.Forms.Label();
            this.NUD_CountProduct = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CountProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Product
            // 
            this.Btn_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(180)))), ((int)(((byte)(153)))));
            this.Btn_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Product.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(109)))), ((int)(((byte)(132)))));
            this.Btn_Product.Location = new System.Drawing.Point(5, 6);
            this.Btn_Product.Name = "Btn_Product";
            this.Btn_Product.Size = new System.Drawing.Size(65, 62);
            this.Btn_Product.TabIndex = 0;
            this.Btn_Product.Text = "Product";
            this.Btn_Product.UseVisualStyleBackColor = false;
            // 
            // Lbl_PriceText
            // 
            this.Lbl_PriceText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_PriceText.Location = new System.Drawing.Point(5, 71);
            this.Lbl_PriceText.Name = "Lbl_PriceText";
            this.Lbl_PriceText.Size = new System.Drawing.Size(37, 19);
            this.Lbl_PriceText.TabIndex = 1;
            this.Lbl_PriceText.Text = "Price:";
            // 
            // Lbl_Price
            // 
            this.Lbl_Price.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Price.Location = new System.Drawing.Point(39, 71);
            this.Lbl_Price.Name = "Lbl_Price";
            this.Lbl_Price.Size = new System.Drawing.Size(31, 15);
            this.Lbl_Price.TabIndex = 2;
            this.Lbl_Price.Text = "0";
            this.Lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NUD_CountProduct
            // 
            this.NUD_CountProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(213)))), ((int)(((byte)(192)))));
            this.NUD_CountProduct.Enabled = false;
            this.NUD_CountProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(109)))), ((int)(((byte)(132)))));
            this.NUD_CountProduct.Location = new System.Drawing.Point(5, 88);
            this.NUD_CountProduct.Name = "NUD_CountProduct";
            this.NUD_CountProduct.Size = new System.Drawing.Size(65, 26);
            this.NUD_CountProduct.TabIndex = 3;
            this.NUD_CountProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUD_CountProduct.ValueChanged += new System.EventHandler(this.NUD_CountProduct_ValueChanged);
            // 
            // Prouduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(213)))), ((int)(((byte)(192)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.NUD_CountProduct);
            this.Controls.Add(this.Lbl_Price);
            this.Controls.Add(this.Lbl_PriceText);
            this.Controls.Add(this.Btn_Product);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(109)))), ((int)(((byte)(132)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(75, 119);
            this.MinimumSize = new System.Drawing.Size(75, 119);
            this.Name = "Prouduct";
            this.Size = new System.Drawing.Size(73, 117);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Prouduct_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CountProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Product;
        private System.Windows.Forms.Label Lbl_PriceText;
        private System.Windows.Forms.Label Lbl_Price;
        private System.Windows.Forms.NumericUpDown NUD_CountProduct;
    }
}
