namespace COMP123_S2019_A5_301051523.Views
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.buttonToFormSelect = new System.Windows.Forms.Button();
            this.ProductInfo = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonToFormSelect
            // 
            this.buttonToFormSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToFormSelect.Location = new System.Drawing.Point(24, 160);
            this.buttonToFormSelect.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonToFormSelect.Name = "buttonToFormSelect";
            this.buttonToFormSelect.Size = new System.Drawing.Size(388, 70);
            this.buttonToFormSelect.TabIndex = 0;
            this.buttonToFormSelect.Text = "Select a product";
            this.buttonToFormSelect.UseVisualStyleBackColor = true;
            this.buttonToFormSelect.Click += new System.EventHandler(this.ButtonToFormSelect_Click);
            // 
            // ProductInfo
            // 
            this.ProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductInfo.Location = new System.Drawing.Point(24, 249);
            this.ProductInfo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ProductInfo.Name = "ProductInfo";
            this.ProductInfo.Size = new System.Drawing.Size(388, 67);
            this.ProductInfo.TabIndex = 1;
            this.ProductInfo.Text = "Saved orders";
            this.ProductInfo.UseVisualStyleBackColor = true;
            this.ProductInfo.Click += new System.EventHandler(this.ProductInfo_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(24, 333);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(388, 67);
            this.buttonQuit.TabIndex = 2;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COMP123_S2019_A5_301051523.Properties.Resources.logo2;
            this.pictureBox1.InitialImage = global::COMP123_S2019_A5_301051523.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(420, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.ProductInfo);
            this.Controls.Add(this.buttonToFormSelect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStart";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonToFormSelect;
        private System.Windows.Forms.Button ProductInfo;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}