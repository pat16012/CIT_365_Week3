namespace MegaDesk_Paton
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.NewQuote = new System.Windows.Forms.Button();
            this.ViewQuote = new System.Windows.Forms.Button();
            this.SearchQuote = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewQuote
            // 
            this.NewQuote.Location = new System.Drawing.Point(32, 35);
            this.NewQuote.Name = "NewQuote";
            this.NewQuote.Size = new System.Drawing.Size(278, 85);
            this.NewQuote.TabIndex = 0;
            this.NewQuote.Text = "Add New Quote";
            this.NewQuote.UseVisualStyleBackColor = true;
            this.NewQuote.Click += new System.EventHandler(this.NewQuote_Click);
            // 
            // ViewQuote
            // 
            this.ViewQuote.Location = new System.Drawing.Point(32, 145);
            this.ViewQuote.Name = "ViewQuote";
            this.ViewQuote.Size = new System.Drawing.Size(278, 69);
            this.ViewQuote.TabIndex = 1;
            this.ViewQuote.Text = "View Quotes";
            this.ViewQuote.UseVisualStyleBackColor = true;
            this.ViewQuote.Click += new System.EventHandler(this.ViewQuote_Click);
            // 
            // SearchQuote
            // 
            this.SearchQuote.Location = new System.Drawing.Point(32, 242);
            this.SearchQuote.Name = "SearchQuote";
            this.SearchQuote.Size = new System.Drawing.Size(278, 75);
            this.SearchQuote.TabIndex = 2;
            this.SearchQuote.Text = "Search Quotes";
            this.SearchQuote.UseVisualStyleBackColor = true;
            this.SearchQuote.Click += new System.EventHandler(this.SearchQuote_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(32, 345);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(278, 72);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SearchQuote);
            this.Controls.Add(this.ViewQuote);
            this.Controls.Add(this.NewQuote);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk_Paton";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewQuote;
        private System.Windows.Forms.Button ViewQuote;
        private System.Windows.Forms.Button SearchQuote;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

