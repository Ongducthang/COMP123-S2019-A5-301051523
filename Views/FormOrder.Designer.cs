namespace COMP123_S2019_A5_301051523
{
    partial class FormOrder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.printFormProduct = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.menuStripFormOrder = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxSystemComponents = new System.Windows.Forms.GroupBox();
            this.LabelRAM = new System.Windows.Forms.Label();
            this.LabelHDD = new System.Windows.Forms.Label();
            this.LabelCPUBrand = new System.Windows.Forms.Label();
            this.LabelCPUNumber = new System.Windows.Forms.Label();
            this.LabelGPUType = new System.Windows.Forms.Label();
            this.LabelCPUSpeed = new System.Windows.Forms.Label();
            this.LabelCPUType = new System.Windows.Forms.Label();
            this.LabelModelData = new System.Windows.Forms.TextBox();
            this.LabelPlatformData = new System.Windows.Forms.TextBox();
            this.LabelBrandData = new System.Windows.Forms.TextBox();
            this.LabelModel = new System.Windows.Forms.Label();
            this.LabelConditionData = new System.Windows.Forms.TextBox();
            this.LabelBrand = new System.Windows.Forms.Label();
            this.LabelPlatform = new System.Windows.Forms.Label();
            this.LabelCondition = new System.Windows.Forms.Label();
            this.GroupBoxYourPrice = new System.Windows.Forms.GroupBox();
            this.LabelPriceData = new System.Windows.Forms.TextBox();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelTotalData = new System.Windows.Forms.TextBox();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.LabelTaxData = new System.Windows.Forms.TextBox();
            this.LabelTax = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonFinish = new System.Windows.Forms.Button();
            this.PictureBoxOrderProduct = new System.Windows.Forms.PictureBox();
            this.LabelOtherSpecsData = new System.Windows.Forms.Label();
            this.menuStripFormOrder.SuspendLayout();
            this.GroupBoxSystemComponents.SuspendLayout();
            this.GroupBoxYourPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxOrderProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // printFormProduct
            // 
            this.printFormProduct.DocumentName = "document";
            this.printFormProduct.Form = this;
            this.printFormProduct.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printFormProduct.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printFormProduct.PrinterSettings")));
            this.printFormProduct.PrintFileName = null;
            // 
            // menuStripFormOrder
            // 
            this.menuStripFormOrder.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripFormOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripFormOrder.Location = new System.Drawing.Point(0, 0);
            this.menuStripFormOrder.Name = "menuStripFormOrder";
            this.menuStripFormOrder.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStripFormOrder.Size = new System.Drawing.Size(778, 25);
            this.menuStripFormOrder.TabIndex = 0;
            this.menuStripFormOrder.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(148, 30);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.selectAllToolStripMenuItem.Text = "Back";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // GroupBoxSystemComponents
            // 
            this.GroupBoxSystemComponents.Controls.Add(this.LabelOtherSpecsData);
            this.GroupBoxSystemComponents.Controls.Add(this.LabelRAM);
            this.GroupBoxSystemComponents.Controls.Add(this.LabelHDD);
            this.GroupBoxSystemComponents.Controls.Add(this.LabelCPUBrand);
            this.GroupBoxSystemComponents.Controls.Add(this.LabelCPUNumber);
            this.GroupBoxSystemComponents.Controls.Add(this.LabelGPUType);
            this.GroupBoxSystemComponents.Controls.Add(this.LabelCPUSpeed);
            this.GroupBoxSystemComponents.Controls.Add(this.LabelCPUType);
            this.GroupBoxSystemComponents.Controls.Add(this.LabelModelData);
            this.GroupBoxSystemComponents.Controls.Add(this.LabelPlatformData);
            this.GroupBoxSystemComponents.Controls.Add(this.LabelBrandData);
            this.GroupBoxSystemComponents.Controls.Add(this.LabelModel);
            this.GroupBoxSystemComponents.Controls.Add(this.LabelConditionData);
            this.GroupBoxSystemComponents.Controls.Add(this.LabelBrand);
            this.GroupBoxSystemComponents.Controls.Add(this.LabelPlatform);
            this.GroupBoxSystemComponents.Controls.Add(this.LabelCondition);
            this.GroupBoxSystemComponents.Location = new System.Drawing.Point(23, 50);
            this.GroupBoxSystemComponents.Name = "GroupBoxSystemComponents";
            this.GroupBoxSystemComponents.Size = new System.Drawing.Size(446, 482);
            this.GroupBoxSystemComponents.TabIndex = 4;
            this.GroupBoxSystemComponents.TabStop = false;
            this.GroupBoxSystemComponents.Text = "System Components";
            // 
            // LabelRAM
            // 
            this.LabelRAM.AutoSize = true;
            this.LabelRAM.Location = new System.Drawing.Point(6, 168);
            this.LabelRAM.Name = "LabelRAM";
            this.LabelRAM.Size = new System.Drawing.Size(45, 20);
            this.LabelRAM.TabIndex = 15;
            this.LabelRAM.Text = "RAM";
            this.LabelRAM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelHDD
            // 
            this.LabelHDD.AutoSize = true;
            this.LabelHDD.Location = new System.Drawing.Point(6, 209);
            this.LabelHDD.Name = "LabelHDD";
            this.LabelHDD.Size = new System.Drawing.Size(45, 20);
            this.LabelHDD.TabIndex = 14;
            this.LabelHDD.Text = "HDD";
            this.LabelHDD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelCPUBrand
            // 
            this.LabelCPUBrand.AutoSize = true;
            this.LabelCPUBrand.Location = new System.Drawing.Point(6, 251);
            this.LabelCPUBrand.Name = "LabelCPUBrand";
            this.LabelCPUBrand.Size = new System.Drawing.Size(89, 20);
            this.LabelCPUBrand.TabIndex = 13;
            this.LabelCPUBrand.Text = "CPU Brand";
            this.LabelCPUBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelCPUNumber
            // 
            this.LabelCPUNumber.AutoSize = true;
            this.LabelCPUNumber.Location = new System.Drawing.Point(6, 294);
            this.LabelCPUNumber.Name = "LabelCPUNumber";
            this.LabelCPUNumber.Size = new System.Drawing.Size(51, 20);
            this.LabelCPUNumber.TabIndex = 12;
            this.LabelCPUNumber.Text = "CPU#";
            this.LabelCPUNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelGPUType
            // 
            this.LabelGPUType.AutoSize = true;
            this.LabelGPUType.Location = new System.Drawing.Point(6, 414);
            this.LabelGPUType.Name = "LabelGPUType";
            this.LabelGPUType.Size = new System.Drawing.Size(82, 20);
            this.LabelGPUType.TabIndex = 11;
            this.LabelGPUType.Text = "GPU Type";
            this.LabelGPUType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelCPUSpeed
            // 
            this.LabelCPUSpeed.AutoSize = true;
            this.LabelCPUSpeed.Location = new System.Drawing.Point(6, 375);
            this.LabelCPUSpeed.Name = "LabelCPUSpeed";
            this.LabelCPUSpeed.Size = new System.Drawing.Size(93, 20);
            this.LabelCPUSpeed.TabIndex = 11;
            this.LabelCPUSpeed.Text = "CPU Speed";
            this.LabelCPUSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelCPUType
            // 
            this.LabelCPUType.AutoSize = true;
            this.LabelCPUType.Location = new System.Drawing.Point(6, 333);
            this.LabelCPUType.Name = "LabelCPUType";
            this.LabelCPUType.Size = new System.Drawing.Size(80, 20);
            this.LabelCPUType.TabIndex = 11;
            this.LabelCPUType.Text = "CPU Type";
            this.LabelCPUType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelModelData
            // 
            this.LabelModelData.Location = new System.Drawing.Point(258, 97);
            this.LabelModelData.Name = "LabelModelData";
            this.LabelModelData.ReadOnly = true;
            this.LabelModelData.Size = new System.Drawing.Size(166, 26);
            this.LabelModelData.TabIndex = 10;
            // 
            // LabelPlatformData
            // 
            this.LabelPlatformData.Location = new System.Drawing.Point(296, 45);
            this.LabelPlatformData.Name = "LabelPlatformData";
            this.LabelPlatformData.ReadOnly = true;
            this.LabelPlatformData.Size = new System.Drawing.Size(100, 26);
            this.LabelPlatformData.TabIndex = 10;
            // 
            // LabelBrandData
            // 
            this.LabelBrandData.Location = new System.Drawing.Point(60, 97);
            this.LabelBrandData.Name = "LabelBrandData";
            this.LabelBrandData.ReadOnly = true;
            this.LabelBrandData.Size = new System.Drawing.Size(112, 26);
            this.LabelBrandData.TabIndex = 10;
            // 
            // LabelModel
            // 
            this.LabelModel.AutoSize = true;
            this.LabelModel.Location = new System.Drawing.Point(206, 100);
            this.LabelModel.Name = "LabelModel";
            this.LabelModel.Size = new System.Drawing.Size(52, 20);
            this.LabelModel.TabIndex = 9;
            this.LabelModel.Text = "Model";
            this.LabelModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelConditionData
            // 
            this.LabelConditionData.Location = new System.Drawing.Point(84, 42);
            this.LabelConditionData.Name = "LabelConditionData";
            this.LabelConditionData.ReadOnly = true;
            this.LabelConditionData.Size = new System.Drawing.Size(120, 26);
            this.LabelConditionData.TabIndex = 10;
            // 
            // LabelBrand
            // 
            this.LabelBrand.AutoSize = true;
            this.LabelBrand.Location = new System.Drawing.Point(6, 100);
            this.LabelBrand.Name = "LabelBrand";
            this.LabelBrand.Size = new System.Drawing.Size(52, 20);
            this.LabelBrand.TabIndex = 9;
            this.LabelBrand.Text = "Brand";
            this.LabelBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelPlatform
            // 
            this.LabelPlatform.AutoSize = true;
            this.LabelPlatform.Location = new System.Drawing.Point(227, 48);
            this.LabelPlatform.Name = "LabelPlatform";
            this.LabelPlatform.Size = new System.Drawing.Size(68, 20);
            this.LabelPlatform.TabIndex = 9;
            this.LabelPlatform.Text = "Platform";
            this.LabelPlatform.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelCondition
            // 
            this.LabelCondition.AutoSize = true;
            this.LabelCondition.Location = new System.Drawing.Point(6, 48);
            this.LabelCondition.Name = "LabelCondition";
            this.LabelCondition.Size = new System.Drawing.Size(76, 20);
            this.LabelCondition.TabIndex = 9;
            this.LabelCondition.Text = "Condition";
            this.LabelCondition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GroupBoxYourPrice
            // 
            this.GroupBoxYourPrice.Controls.Add(this.LabelPriceData);
            this.GroupBoxYourPrice.Controls.Add(this.LabelPrice);
            this.GroupBoxYourPrice.Controls.Add(this.LabelTotalData);
            this.GroupBoxYourPrice.Controls.Add(this.LabelTotal);
            this.GroupBoxYourPrice.Controls.Add(this.LabelTaxData);
            this.GroupBoxYourPrice.Controls.Add(this.LabelTax);
            this.GroupBoxYourPrice.Controls.Add(this.shapeContainer1);
            this.GroupBoxYourPrice.Location = new System.Drawing.Point(484, 233);
            this.GroupBoxYourPrice.Name = "GroupBoxYourPrice";
            this.GroupBoxYourPrice.Size = new System.Drawing.Size(282, 179);
            this.GroupBoxYourPrice.TabIndex = 5;
            this.GroupBoxYourPrice.TabStop = false;
            this.GroupBoxYourPrice.Text = "Your Price";
            // 
            // LabelPriceData
            // 
            this.LabelPriceData.Location = new System.Drawing.Point(118, 40);
            this.LabelPriceData.Name = "LabelPriceData";
            this.LabelPriceData.ReadOnly = true;
            this.LabelPriceData.Size = new System.Drawing.Size(132, 26);
            this.LabelPriceData.TabIndex = 10;
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(44, 43);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(44, 20);
            this.LabelPrice.TabIndex = 9;
            this.LabelPrice.Text = "Price";
            this.LabelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelTotalData
            // 
            this.LabelTotalData.Location = new System.Drawing.Point(118, 132);
            this.LabelTotalData.Name = "LabelTotalData";
            this.LabelTotalData.ReadOnly = true;
            this.LabelTotalData.Size = new System.Drawing.Size(132, 26);
            this.LabelTotalData.TabIndex = 10;
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Location = new System.Drawing.Point(44, 135);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(44, 20);
            this.LabelTotal.TabIndex = 9;
            this.LabelTotal.Text = "Total";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelTaxData
            // 
            this.LabelTaxData.Location = new System.Drawing.Point(118, 79);
            this.LabelTaxData.Name = "LabelTaxData";
            this.LabelTaxData.ReadOnly = true;
            this.LabelTaxData.Size = new System.Drawing.Size(132, 26);
            this.LabelTaxData.TabIndex = 10;
            // 
            // LabelTax
            // 
            this.LabelTax.AutoSize = true;
            this.LabelTax.Location = new System.Drawing.Point(44, 82);
            this.LabelTax.Name = "LabelTax";
            this.LabelTax.Size = new System.Drawing.Size(34, 20);
            this.LabelTax.TabIndex = 9;
            this.LabelTax.Text = "Tax";
            this.LabelTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 22);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(276, 154);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 276;
            this.lineShape1.Y1 = 90;
            this.lineShape1.Y2 = 90;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(494, 430);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(75, 63);
            this.ButtonBack.TabIndex = 7;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Location = new System.Drawing.Point(593, 430);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 63);
            this.ButtonCancel.TabIndex = 7;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ButtonFinish
            // 
            this.ButtonFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFinish.Location = new System.Drawing.Point(691, 430);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new System.Drawing.Size(75, 63);
            this.ButtonFinish.TabIndex = 7;
            this.ButtonFinish.Text = "Finish";
            this.ButtonFinish.UseVisualStyleBackColor = true;
            this.ButtonFinish.Click += new System.EventHandler(this.ButtonFinish_Click);
            // 
            // PictureBoxOrderProduct
            // 
            this.PictureBoxOrderProduct.Image = global::COMP123_S2019_A5_301051523.Properties.Resources.laptop_min;
            this.PictureBoxOrderProduct.Location = new System.Drawing.Point(484, 64);
            this.PictureBoxOrderProduct.Name = "PictureBoxOrderProduct";
            this.PictureBoxOrderProduct.Size = new System.Drawing.Size(199, 150);
            this.PictureBoxOrderProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxOrderProduct.TabIndex = 6;
            this.PictureBoxOrderProduct.TabStop = false;
            // 
            // LabelOtherSpecsData
            // 
            this.LabelOtherSpecsData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelOtherSpecsData.BackColor = System.Drawing.Color.LightGray;
            this.LabelOtherSpecsData.Location = new System.Drawing.Point(105, 168);
            this.LabelOtherSpecsData.Name = "LabelOtherSpecsData";
            this.LabelOtherSpecsData.Size = new System.Drawing.Size(319, 272);
            this.LabelOtherSpecsData.TabIndex = 16;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonFinish);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.PictureBoxOrderProduct);
            this.Controls.Add(this.GroupBoxYourPrice);
            this.Controls.Add(this.GroupBoxSystemComponents);
            this.Controls.Add(this.menuStripFormOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripFormOrder;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
            this.Activated += new System.EventHandler(this.FormOrder_Activated);
            this.menuStripFormOrder.ResumeLayout(false);
            this.menuStripFormOrder.PerformLayout();
            this.GroupBoxSystemComponents.ResumeLayout(false);
            this.GroupBoxSystemComponents.PerformLayout();
            this.GroupBoxYourPrice.ResumeLayout(false);
            this.GroupBoxYourPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxOrderProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printFormProduct;
        private System.Windows.Forms.MenuStrip menuStripFormOrder;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox PictureBoxOrderProduct;
        private System.Windows.Forms.GroupBox GroupBoxYourPrice;
        private System.Windows.Forms.GroupBox GroupBoxSystemComponents;
        private System.Windows.Forms.TextBox LabelPriceData;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.TextBox LabelTotalData;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.TextBox LabelTaxData;
        private System.Windows.Forms.Label LabelTax;
        private System.Windows.Forms.Label LabelRAM;
        private System.Windows.Forms.Label LabelHDD;
        private System.Windows.Forms.Label LabelCPUBrand;
        private System.Windows.Forms.Label LabelCPUNumber;
        private System.Windows.Forms.Label LabelGPUType;
        private System.Windows.Forms.Label LabelCPUSpeed;
        private System.Windows.Forms.Label LabelCPUType;
        private System.Windows.Forms.TextBox LabelModelData;
        private System.Windows.Forms.TextBox LabelPlatformData;
        private System.Windows.Forms.TextBox LabelBrandData;
        private System.Windows.Forms.Label LabelModel;
        private System.Windows.Forms.TextBox LabelConditionData;
        private System.Windows.Forms.Label LabelBrand;
        private System.Windows.Forms.Label LabelPlatform;
        private System.Windows.Forms.Label LabelCondition;
        private System.Windows.Forms.Button ButtonFinish;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonBack;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label LabelOtherSpecsData;
    }
}

