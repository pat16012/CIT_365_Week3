namespace MegaDesk_Paton
{
    partial class AddQuote
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
            this.Cancel = new System.Windows.Forms.Button();
            this.CustomerName = new System.Windows.Forms.Label();
            this.DeskWidth = new System.Windows.Forms.Label();
            this.NumberDrawers = new System.Windows.Forms.Label();
            this.DesktopMaterial = new System.Windows.Forms.Label();
            this.RushOrder = new System.Windows.Forms.Label();
            this.DisplayQuote = new System.Windows.Forms.Button();
            this.DesktopMaterialSelect = new System.Windows.Forms.ComboBox();
            this.RushOrderSelect = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown3 = new System.Windows.Forms.DomainUpDown();
            this.DeskDepth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(636, 538);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(112, 35);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(100, 77);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(227, 35);
            this.CustomerName.TabIndex = 1;
            this.CustomerName.Text = "Customer Name";
            this.CustomerName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // DeskWidth
            // 
            this.DeskWidth.AutoSize = true;
            this.DeskWidth.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidth.Location = new System.Drawing.Point(100, 161);
            this.DeskWidth.Name = "DeskWidth";
            this.DeskWidth.Size = new System.Drawing.Size(168, 35);
            this.DeskWidth.TabIndex = 2;
            this.DeskWidth.Text = "Desk Width";
            this.DeskWidth.Click += new System.EventHandler(this.DeskWidthDepth_Click);
            // 
            // NumberDrawers
            // 
            this.NumberDrawers.AutoSize = true;
            this.NumberDrawers.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberDrawers.Location = new System.Drawing.Point(100, 244);
            this.NumberDrawers.Name = "NumberDrawers";
            this.NumberDrawers.Size = new System.Drawing.Size(224, 35);
            this.NumberDrawers.TabIndex = 3;
            this.NumberDrawers.Text = "Enter # Drawers";
            // 
            // DesktopMaterial
            // 
            this.DesktopMaterial.AutoSize = true;
            this.DesktopMaterial.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesktopMaterial.Location = new System.Drawing.Point(100, 329);
            this.DesktopMaterial.Name = "DesktopMaterial";
            this.DesktopMaterial.Size = new System.Drawing.Size(370, 35);
            this.DesktopMaterial.TabIndex = 4;
            this.DesktopMaterial.Text = "Desktop Material Selection";
            // 
            // RushOrder
            // 
            this.RushOrder.AutoSize = true;
            this.RushOrder.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrder.Location = new System.Drawing.Point(100, 436);
            this.RushOrder.Name = "RushOrder";
            this.RushOrder.Size = new System.Drawing.Size(290, 35);
            this.RushOrder.TabIndex = 5;
            this.RushOrder.Text = "Rush Order Selection";
            // 
            // DisplayQuote
            // 
            this.DisplayQuote.Location = new System.Drawing.Point(408, 538);
            this.DisplayQuote.Name = "DisplayQuote";
            this.DisplayQuote.Size = new System.Drawing.Size(157, 35);
            this.DisplayQuote.TabIndex = 7;
            this.DisplayQuote.Text = "Display Quote";
            this.DisplayQuote.UseVisualStyleBackColor = true;
            this.DisplayQuote.Click += new System.EventHandler(this.CalcQuote_Click);
            // 
            // DesktopMaterialSelect
            // 
            this.DesktopMaterialSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesktopMaterialSelect.FormattingEnabled = true;
            this.DesktopMaterialSelect.Items.AddRange(new object[] {
            "Oak             ($200)",
            "Laminate    ($100)",
            "Rosewood ($300)",
            "Veneer       ($125)",
            "Pine            ($ 50)"});
            this.DesktopMaterialSelect.Location = new System.Drawing.Point(106, 376);
            this.DesktopMaterialSelect.Name = "DesktopMaterialSelect";
            this.DesktopMaterialSelect.Size = new System.Drawing.Size(221, 33);
            this.DesktopMaterialSelect.TabIndex = 5;
            this.DesktopMaterialSelect.Text = "Oak ($200)";
            this.DesktopMaterialSelect.SelectedIndexChanged += new System.EventHandler(this.DesktopMaterialSelect_SelectedIndexChanged);
            // 
            // RushOrderSelect
            // 
            this.RushOrderSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderSelect.FormattingEnabled = true;
            this.RushOrderSelect.Items.AddRange(new object[] {
            "Normal (14 Days)",
            "3 Days",
            "5 Days",
            "7 Days"});
            this.RushOrderSelect.Location = new System.Drawing.Point(106, 474);
            this.RushOrderSelect.Name = "RushOrderSelect";
            this.RushOrderSelect.Size = new System.Drawing.Size(221, 33);
            this.RushOrderSelect.TabIndex = 6;
            this.RushOrderSelect.Text = "Normal (14 Days)";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(106, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 35);
            this.textBox1.TabIndex = 1;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDown1.Items.Add("7 ($350)");
            this.domainUpDown1.Items.Add("6 ($300)");
            this.domainUpDown1.Items.Add("5 ($250)");
            this.domainUpDown1.Items.Add("4 ($200)");
            this.domainUpDown1.Items.Add("3 ($150)");
            this.domainUpDown1.Items.Add("2 ($100)");
            this.domainUpDown1.Items.Add("1 ($50)");
            this.domainUpDown1.Items.Add("0 ($0)");
            this.domainUpDown1.Location = new System.Drawing.Point(106, 282);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(221, 35);
            this.domainUpDown1.TabIndex = 4;
            this.domainUpDown1.Text = "0";
            this.domainUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDown2.Location = new System.Drawing.Point(167, 199);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(70, 35);
            this.domainUpDown2.TabIndex = 9;
            this.domainUpDown2.Text = "24\"";
            // 
            // domainUpDown3
            // 
            this.domainUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDown3.Items.Add("48");
            this.domainUpDown3.Items.Add("47");
            this.domainUpDown3.Items.Add("46");
            this.domainUpDown3.Items.Add("45");
            this.domainUpDown3.Items.Add("44");
            this.domainUpDown3.Items.Add("43");
            this.domainUpDown3.Items.Add("42");
            this.domainUpDown3.Items.Add("41");
            this.domainUpDown3.Items.Add("40");
            this.domainUpDown3.Items.Add("39");
            this.domainUpDown3.Items.Add("38");
            this.domainUpDown3.Items.Add("37");
            this.domainUpDown3.Items.Add("36");
            this.domainUpDown3.Items.Add("35");
            this.domainUpDown3.Items.Add("34");
            this.domainUpDown3.Items.Add("33");
            this.domainUpDown3.Items.Add("32");
            this.domainUpDown3.Items.Add("31");
            this.domainUpDown3.Items.Add("30");
            this.domainUpDown3.Items.Add("29");
            this.domainUpDown3.Items.Add("28");
            this.domainUpDown3.Items.Add("27");
            this.domainUpDown3.Items.Add("26");
            this.domainUpDown3.Items.Add("25");
            this.domainUpDown3.Items.Add("24");
            this.domainUpDown3.Items.Add("23");
            this.domainUpDown3.Items.Add("22");
            this.domainUpDown3.Items.Add("21");
            this.domainUpDown3.Items.Add("20");
            this.domainUpDown3.Items.Add("19");
            this.domainUpDown3.Items.Add("18");
            this.domainUpDown3.Items.Add("17");
            this.domainUpDown3.Items.Add("16");
            this.domainUpDown3.Items.Add("15");
            this.domainUpDown3.Items.Add("14");
            this.domainUpDown3.Items.Add("13");
            this.domainUpDown3.Items.Add("12");
            this.domainUpDown3.Location = new System.Drawing.Point(424, 199);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.Size = new System.Drawing.Size(70, 35);
            this.domainUpDown3.TabIndex = 10;
            this.domainUpDown3.Text = "12\"";
            // 
            // DeskDepth
            // 
            this.DeskDepth.AutoSize = true;
            this.DeskDepth.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepth.Location = new System.Drawing.Point(354, 161);
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.Size = new System.Drawing.Size(168, 35);
            this.DeskDepth.TabIndex = 11;
            this.DeskDepth.Text = "Desk Depth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Min 24\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Max 96\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Min 12\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Min 48\"";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 646);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeskDepth);
            this.Controls.Add(this.domainUpDown3);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RushOrderSelect);
            this.Controls.Add(this.DesktopMaterialSelect);
            this.Controls.Add(this.DisplayQuote);
            this.Controls.Add(this.RushOrder);
            this.Controls.Add(this.DesktopMaterial);
            this.Controls.Add(this.NumberDrawers);
            this.Controls.Add(this.DeskWidth);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.Cancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newQuote";
            this.Load += new System.EventHandler(this.AddNewQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label DeskWidth;
        private System.Windows.Forms.Label NumberDrawers;
        private System.Windows.Forms.Label DesktopMaterial;
        private System.Windows.Forms.Label RushOrder;
        private System.Windows.Forms.Button DisplayQuote;
        private System.Windows.Forms.ComboBox DesktopMaterialSelect;
        private System.Windows.Forms.ComboBox RushOrderSelect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.DomainUpDown domainUpDown3;
        private System.Windows.Forms.Label DeskDepth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}