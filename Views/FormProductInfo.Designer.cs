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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductInfo));
            this.buttonSelectAnotherProduct = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxProductInfo = new System.Windows.Forms.GroupBox();
            this.LabelModelData = new System.Windows.Forms.TextBox();
            this.LabelBrandData = new System.Windows.Forms.TextBox();
            this.LabelOSData = new System.Windows.Forms.TextBox();
            this.LabelPlatformData = new System.Windows.Forms.TextBox();
            this.LabelOS = new System.Windows.Forms.Label();
            this.LabelModel = new System.Windows.Forms.Label();
            this.LabelBrand = new System.Windows.Forms.Label();
            this.LabelPlatform = new System.Windows.Forms.Label();
            this.GroupBoxTechSpecs = new System.Windows.Forms.GroupBox();
            this.LabelHDDData = new System.Windows.Forms.TextBox();
            this.LabelGPUTypeData = new System.Windows.Forms.TextBox();
            this.LabelCPUTypeData = new System.Windows.Forms.TextBox();
            this.LabelCPUSpeedData = new System.Windows.Forms.TextBox();
            this.LabelCPUNumberData = new System.Windows.Forms.TextBox();
            this.LabelCPUBrandData = new System.Windows.Forms.TextBox();
            this.LabelRAMData = new System.Windows.Forms.TextBox();
            this.LabelGPUType = new System.Windows.Forms.Label();
            this.LabelCPUSpeed = new System.Windows.Forms.Label();
            this.LabelCPUNumber = new System.Windows.Forms.Label();
            this.LabelCPUType = new System.Windows.Forms.Label();
            this.LabelHDD = new System.Windows.Forms.Label();
            this.LabelCPUBrand = new System.Windows.Forms.Label();
            this.LabelRAM = new System.Windows.Forms.Label();
            this.LabelCondition = new System.Windows.Forms.Label();
            this.LabelProductID = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.LabelCostData = new System.Windows.Forms.TextBox();
            this.LabelConditionData = new System.Windows.Forms.TextBox();
            this.LabelProductIDData = new System.Windows.Forms.TextBox();
            this.SaveFileDialogProductInfo = new System.Windows.Forms.SaveFileDialog();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenFileDialogProductInfo = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.GroupBoxProductInfo.SuspendLayout();
            this.GroupBoxTechSpecs.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelectAnotherProduct
            // 
            this.buttonSelectAnotherProduct.Location = new System.Drawing.Point(483, 391);
            this.buttonSelectAnotherProduct.Name = "buttonSelectAnotherProduct";
            this.buttonSelectAnotherProduct.Size = new System.Drawing.Size(270, 43);
            this.buttonSelectAnotherProduct.TabIndex = 1;
            this.buttonSelectAnotherProduct.Text = "Select another product";
            this.buttonSelectAnotherProduct.UseVisualStyleBackColor = true;
            this.buttonSelectAnotherProduct.Click += new System.EventHandler(this.ButtonSelectAnotherProduct_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(483, 440);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(270, 43);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(483, 489);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(270, 43);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.selectAnotherProductToolStripMenuItem.Text = "Select another product";
            // 
            // GroupBoxProductInfo
            // 
            this.GroupBoxProductInfo.Controls.Add(this.LabelModelData);
            this.GroupBoxProductInfo.Controls.Add(this.LabelBrandData);
            this.GroupBoxProductInfo.Controls.Add(this.LabelOSData);
            this.GroupBoxProductInfo.Controls.Add(this.LabelPlatformData);
            this.GroupBoxProductInfo.Controls.Add(this.LabelOS);
            this.GroupBoxProductInfo.Controls.Add(this.LabelModel);
            this.GroupBoxProductInfo.Controls.Add(this.LabelBrand);
            this.GroupBoxProductInfo.Controls.Add(this.LabelPlatform);
            this.GroupBoxProductInfo.Location = new System.Drawing.Point(12, 47);
            this.GroupBoxProductInfo.Name = "GroupBoxProductInfo";
            this.GroupBoxProductInfo.Size = new System.Drawing.Size(451, 185);
            this.GroupBoxProductInfo.TabIndex = 5;
            this.GroupBoxProductInfo.TabStop = false;
            this.GroupBoxProductInfo.Text = "Product Info";
            // 
            // LabelModelData
            // 
            this.LabelModelData.Location = new System.Drawing.Point(130, 134);
            this.LabelModelData.Name = "LabelModelData";
            this.LabelModelData.ReadOnly = true;
            this.LabelModelData.Size = new System.Drawing.Size(194, 35);
            this.LabelModelData.TabIndex = 8;
            // 
            // LabelBrandData
            // 
            this.LabelBrandData.Location = new System.Drawing.Point(330, 41);
            this.LabelBrandData.Name = "LabelBrandData";
            this.LabelBrandData.ReadOnly = true;
            this.LabelBrandData.Size = new System.Drawing.Size(100, 35);
            this.LabelBrandData.TabIndex = 8;
            // 
            // LabelOSData
            // 
            this.LabelOSData.Location = new System.Drawing.Point(130, 91);
            this.LabelOSData.Name = "LabelOSData";
            this.LabelOSData.ReadOnly = true;
            this.LabelOSData.Size = new System.Drawing.Size(194, 35);
            this.LabelOSData.TabIndex = 8;
            // 
            // LabelPlatformData
            // 
            this.LabelPlatformData.Location = new System.Drawing.Point(130, 44);
            this.LabelPlatformData.Name = "LabelPlatformData";
            this.LabelPlatformData.ReadOnly = true;
            this.LabelPlatformData.Size = new System.Drawing.Size(100, 35);
            this.LabelPlatformData.TabIndex = 8;
            // 
            // LabelOS
            // 
            this.LabelOS.AutoSize = true;
            this.LabelOS.Location = new System.Drawing.Point(24, 91);
            this.LabelOS.Name = "LabelOS";
            this.LabelOS.Size = new System.Drawing.Size(48, 29);
            this.LabelOS.TabIndex = 7;
            this.LabelOS.Text = "OS";
            this.LabelOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelModel
            // 
            this.LabelModel.AutoSize = true;
            this.LabelModel.Location = new System.Drawing.Point(24, 137);
            this.LabelModel.Name = "LabelModel";
            this.LabelModel.Size = new System.Drawing.Size(81, 29);
            this.LabelModel.TabIndex = 7;
            this.LabelModel.Text = "Model";
            this.LabelModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelBrand
            // 
            this.LabelBrand.AutoSize = true;
            this.LabelBrand.Location = new System.Drawing.Point(247, 44);
            this.LabelBrand.Name = "LabelBrand";
            this.LabelBrand.Size = new System.Drawing.Size(77, 29);
            this.LabelBrand.TabIndex = 7;
            this.LabelBrand.Text = "Brand";
            // 
            // LabelPlatform
            // 
            this.LabelPlatform.AutoSize = true;
            this.LabelPlatform.Location = new System.Drawing.Point(24, 47);
            this.LabelPlatform.Name = "LabelPlatform";
            this.LabelPlatform.Size = new System.Drawing.Size(102, 29);
            this.LabelPlatform.TabIndex = 7;
            this.LabelPlatform.Text = "Platform";
            this.LabelPlatform.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GroupBoxTechSpecs
            // 
            this.GroupBoxTechSpecs.Controls.Add(this.LabelHDDData);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelGPUTypeData);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelCPUTypeData);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelCPUSpeedData);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelCPUNumberData);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelCPUBrandData);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelRAMData);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelGPUType);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelCPUSpeed);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelCPUNumber);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelCPUType);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelHDD);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelCPUBrand);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelRAM);
            this.GroupBoxTechSpecs.Location = new System.Drawing.Point(12, 238);
            this.GroupBoxTechSpecs.Name = "GroupBoxTechSpecs";
            this.GroupBoxTechSpecs.Size = new System.Drawing.Size(451, 294);
            this.GroupBoxTechSpecs.TabIndex = 6;
            this.GroupBoxTechSpecs.TabStop = false;
            this.GroupBoxTechSpecs.Text = "Tech Specs";
            // 
            // LabelHDDData
            // 
            this.LabelHDDData.Location = new System.Drawing.Point(296, 42);
            this.LabelHDDData.Name = "LabelHDDData";
            this.LabelHDDData.ReadOnly = true;
            this.LabelHDDData.Size = new System.Drawing.Size(100, 35);
            this.LabelHDDData.TabIndex = 8;
            // 
            // LabelGPUTypeData
            // 
            this.LabelGPUTypeData.Location = new System.Drawing.Point(146, 248);
            this.LabelGPUTypeData.Name = "LabelGPUTypeData";
            this.LabelGPUTypeData.ReadOnly = true;
            this.LabelGPUTypeData.Size = new System.Drawing.Size(286, 35);
            this.LabelGPUTypeData.TabIndex = 8;
            // 
            // LabelCPUTypeData
            // 
            this.LabelCPUTypeData.Location = new System.Drawing.Point(20, 199);
            this.LabelCPUTypeData.Name = "LabelCPUTypeData";
            this.LabelCPUTypeData.ReadOnly = true;
            this.LabelCPUTypeData.Size = new System.Drawing.Size(166, 35);
            this.LabelCPUTypeData.TabIndex = 8;
            // 
            // LabelCPUSpeedData
            // 
            this.LabelCPUSpeedData.Location = new System.Drawing.Point(222, 199);
            this.LabelCPUSpeedData.Name = "LabelCPUSpeedData";
            this.LabelCPUSpeedData.ReadOnly = true;
            this.LabelCPUSpeedData.Size = new System.Drawing.Size(166, 35);
            this.LabelCPUSpeedData.TabIndex = 8;
            // 
            // LabelCPUNumberData
            // 
            this.LabelCPUNumberData.Location = new System.Drawing.Point(222, 121);
            this.LabelCPUNumberData.Name = "LabelCPUNumberData";
            this.LabelCPUNumberData.ReadOnly = true;
            this.LabelCPUNumberData.Size = new System.Drawing.Size(166, 35);
            this.LabelCPUNumberData.TabIndex = 8;
            // 
            // LabelCPUBrandData
            // 
            this.LabelCPUBrandData.Location = new System.Drawing.Point(20, 121);
            this.LabelCPUBrandData.Name = "LabelCPUBrandData";
            this.LabelCPUBrandData.ReadOnly = true;
            this.LabelCPUBrandData.Size = new System.Drawing.Size(166, 35);
            this.LabelCPUBrandData.TabIndex = 8;
            // 
            // LabelRAMData
            // 
            this.LabelRAMData.Location = new System.Drawing.Point(86, 42);
            this.LabelRAMData.Name = "LabelRAMData";
            this.LabelRAMData.ReadOnly = true;
            this.LabelRAMData.Size = new System.Drawing.Size(100, 35);
            this.LabelRAMData.TabIndex = 8;
            // 
            // LabelGPUType
            // 
            this.LabelGPUType.AutoSize = true;
            this.LabelGPUType.Location = new System.Drawing.Point(15, 251);
            this.LabelGPUType.Name = "LabelGPUType";
            this.LabelGPUType.Size = new System.Drawing.Size(125, 29);
            this.LabelGPUType.TabIndex = 7;
            this.LabelGPUType.Text = "GPU Type";
            // 
            // LabelCPUSpeed
            // 
            this.LabelCPUSpeed.AutoSize = true;
            this.LabelCPUSpeed.Location = new System.Drawing.Point(217, 167);
            this.LabelCPUSpeed.Name = "LabelCPUSpeed";
            this.LabelCPUSpeed.Size = new System.Drawing.Size(141, 29);
            this.LabelCPUSpeed.TabIndex = 7;
            this.LabelCPUSpeed.Text = "CPU Speed";
            // 
            // LabelCPUNumber
            // 
            this.LabelCPUNumber.AutoSize = true;
            this.LabelCPUNumber.Location = new System.Drawing.Point(217, 89);
            this.LabelCPUNumber.Name = "LabelCPUNumber";
            this.LabelCPUNumber.Size = new System.Drawing.Size(82, 29);
            this.LabelCPUNumber.TabIndex = 7;
            this.LabelCPUNumber.Text = "CPU #";
            // 
            // LabelCPUType
            // 
            this.LabelCPUType.AutoSize = true;
            this.LabelCPUType.Location = new System.Drawing.Point(16, 167);
            this.LabelCPUType.Name = "LabelCPUType";
            this.LabelCPUType.Size = new System.Drawing.Size(124, 29);
            this.LabelCPUType.TabIndex = 7;
            this.LabelCPUType.Text = "CPU Type";
            // 
            // LabelHDD
            // 
            this.LabelHDD.AutoSize = true;
            this.LabelHDD.Location = new System.Drawing.Point(226, 45);
            this.LabelHDD.Name = "LabelHDD";
            this.LabelHDD.Size = new System.Drawing.Size(64, 29);
            this.LabelHDD.TabIndex = 7;
            this.LabelHDD.Text = "HDD";
            // 
            // LabelCPUBrand
            // 
            this.LabelCPUBrand.AutoSize = true;
            this.LabelCPUBrand.Location = new System.Drawing.Point(16, 89);
            this.LabelCPUBrand.Name = "LabelCPUBrand";
            this.LabelCPUBrand.Size = new System.Drawing.Size(133, 29);
            this.LabelCPUBrand.TabIndex = 7;
            this.LabelCPUBrand.Text = "CPU Brand";
            // 
            // LabelRAM
            // 
            this.LabelRAM.AutoSize = true;
            this.LabelRAM.Location = new System.Drawing.Point(15, 48);
            this.LabelRAM.Name = "LabelRAM";
            this.LabelRAM.Size = new System.Drawing.Size(65, 29);
            this.LabelRAM.TabIndex = 7;
            this.LabelRAM.Text = "RAM";
            // 
            // LabelCondition
            // 
            this.LabelCondition.AutoSize = true;
            this.LabelCondition.Location = new System.Drawing.Point(497, 138);
            this.LabelCondition.Name = "LabelCondition";
            this.LabelCondition.Size = new System.Drawing.Size(116, 29);
            this.LabelCondition.TabIndex = 7;
            this.LabelCondition.Text = "Condition";
            // 
            // LabelProductID
            // 
            this.LabelProductID.AutoSize = true;
            this.LabelProductID.Location = new System.Drawing.Point(497, 64);
            this.LabelProductID.Name = "LabelProductID";
            this.LabelProductID.Size = new System.Drawing.Size(125, 29);
            this.LabelProductID.TabIndex = 7;
            this.LabelProductID.Text = "Product ID";
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Location = new System.Drawing.Point(497, 214);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(62, 29);
            this.LabelCost.TabIndex = 7;
            this.LabelCost.Text = "Cost";
            // 
            // LabelCostData
            // 
            this.LabelCostData.Location = new System.Drawing.Point(502, 246);
            this.LabelCostData.Name = "LabelCostData";
            this.LabelCostData.ReadOnly = true;
            this.LabelCostData.Size = new System.Drawing.Size(166, 35);
            this.LabelCostData.TabIndex = 8;
            // 
            // LabelConditionData
            // 
            this.LabelConditionData.Location = new System.Drawing.Point(502, 170);
            this.LabelConditionData.Name = "LabelConditionData";
            this.LabelConditionData.ReadOnly = true;
            this.LabelConditionData.Size = new System.Drawing.Size(166, 35);
            this.LabelConditionData.TabIndex = 8;
            // 
            // LabelProductIDData
            // 
            this.LabelProductIDData.Location = new System.Drawing.Point(502, 96);
            this.LabelProductIDData.Name = "LabelProductIDData";
            this.LabelProductIDData.ReadOnly = true;
            this.LabelProductIDData.Size = new System.Drawing.Size(166, 35);
            this.LabelProductIDData.TabIndex = 8;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // OpenFileDialogProductInfo
            // 
            this.OpenFileDialogProductInfo.FileName = "OpenFileDialogProductInfo";
            // 
            // FormProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.LabelCost);
            this.Controls.Add(this.LabelProductID);
            this.Controls.Add(this.LabelCondition);
            this.Controls.Add(this.LabelProductIDData);
            this.Controls.Add(this.LabelConditionData);
            this.Controls.Add(this.LabelCostData);
            this.Controls.Add(this.GroupBoxTechSpecs);
            this.Controls.Add(this.GroupBoxProductInfo);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSelectAnotherProduct);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormProductInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Info";
            this.Activated += new System.EventHandler(this.FormProductInfo_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupBoxProductInfo.ResumeLayout(false);
            this.GroupBoxProductInfo.PerformLayout();
            this.GroupBoxTechSpecs.ResumeLayout(false);
            this.GroupBoxTechSpecs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectAnotherProduct;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.GroupBox GroupBoxProductInfo;
        private System.Windows.Forms.GroupBox GroupBoxTechSpecs;
        private System.Windows.Forms.Label LabelOS;
        private System.Windows.Forms.Label LabelModel;
        private System.Windows.Forms.Label LabelBrand;
        private System.Windows.Forms.Label LabelPlatform;
        private System.Windows.Forms.Label LabelCPUSpeed;
        private System.Windows.Forms.Label LabelCPUNumber;
        private System.Windows.Forms.Label LabelCPUType;
        private System.Windows.Forms.Label LabelCPUBrand;
        private System.Windows.Forms.Label LabelRAM;
        private System.Windows.Forms.Label LabelGPUType;
        private System.Windows.Forms.Label LabelHDD;
        private System.Windows.Forms.Label LabelCondition;
        private System.Windows.Forms.Label LabelProductID;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.TextBox LabelModelData;
        private System.Windows.Forms.TextBox LabelOSData;
        private System.Windows.Forms.TextBox LabelPlatformData;
        private System.Windows.Forms.TextBox LabelHDDData;
        private System.Windows.Forms.TextBox LabelGPUTypeData;
        private System.Windows.Forms.TextBox LabelCPUTypeData;
        private System.Windows.Forms.TextBox LabelCPUBrandData;
        private System.Windows.Forms.TextBox LabelRAMData;
        private System.Windows.Forms.TextBox LabelCostData;
        private System.Windows.Forms.TextBox LabelConditionData;
        private System.Windows.Forms.TextBox LabelProductIDData;
        private System.Windows.Forms.TextBox LabelBrandData;
        private System.Windows.Forms.TextBox LabelCPUSpeedData;
        private System.Windows.Forms.TextBox LabelCPUNumberData;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialogProductInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogProductInfo;
    }
}