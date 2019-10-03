namespace MegaDesk_Paton
{
    partial class DisplayQuote
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
            this.MainReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainReturn
            // 
            this.MainReturn.Location = new System.Drawing.Point(636, 390);
            this.MainReturn.Name = "MainReturn";
            this.MainReturn.Size = new System.Drawing.Size(125, 30);
            this.MainReturn.TabIndex = 0;
            this.MainReturn.Text = "Main Menu";
            this.MainReturn.UseVisualStyleBackColor = true;
            this.MainReturn.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainReturn);
            this.Name = "DisplayQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainReturn;
    }
}