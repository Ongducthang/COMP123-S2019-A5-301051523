namespace COMP123_S2019_A5_301051523.Views
{
    partial class FormProductInfo
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
            this.buttonSelectAnotherProduct = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSelectAnotherProduct
            // 
            this.buttonSelectAnotherProduct.Location = new System.Drawing.Point(442, 396);
            this.buttonSelectAnotherProduct.Name = "buttonSelectAnotherProduct";
            this.buttonSelectAnotherProduct.Size = new System.Drawing.Size(310, 43);
            this.buttonSelectAnotherProduct.TabIndex = 1;
            this.buttonSelectAnotherProduct.Text = "Select another product";
            this.buttonSelectAnotherProduct.UseVisualStyleBackColor = true;
            this.buttonSelectAnotherProduct.Click += new System.EventHandler(this.ButtonSelectAnotherProduct_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(442, 458);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(310, 43);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FormProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSelectAnotherProduct);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormProductInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectAnotherProduct;
        private System.Windows.Forms.Button buttonCancel;
    }
}