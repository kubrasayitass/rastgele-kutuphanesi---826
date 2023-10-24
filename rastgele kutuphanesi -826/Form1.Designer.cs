namespace rastgele_kutuphanesi__826
{
    partial class Form1
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
            this.lbNotlar = new System.Windows.Forms.ListBox();
            this.btnUret = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNotlar
            // 
            this.lbNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbNotlar.ForeColor = System.Drawing.Color.Black;
            this.lbNotlar.FormattingEnabled = true;
            this.lbNotlar.ItemHeight = 20;
            this.lbNotlar.Location = new System.Drawing.Point(165, 26);
            this.lbNotlar.Name = "lbNotlar";
            this.lbNotlar.Size = new System.Drawing.Size(146, 284);
            this.lbNotlar.TabIndex = 0;
            // 
            // btnUret
            // 
            this.btnUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUret.ForeColor = System.Drawing.Color.Black;
            this.btnUret.Location = new System.Drawing.Point(22, 26);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(127, 50);
            this.btnUret.TabIndex = 1;
            this.btnUret.Text = "üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(376, 348);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.lbNotlar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbNotlar;
        private System.Windows.Forms.Button btnUret;
    }
}

