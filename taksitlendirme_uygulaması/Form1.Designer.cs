namespace taksitlendirme_uygulaması
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
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.tbTaksit = new System.Windows.Forms.TrackBar();
            this.lblTaksit = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbTaksit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(62, 222);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(130, 24);
            this.lblSonuc.TabIndex = 4;
            this.lblSonuc.Text = "Taksit Tutar :";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.OliveDrab;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(66, 288);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(292, 56);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // tbTaksit
            // 
            this.tbTaksit.Location = new System.Drawing.Point(66, 86);
            this.tbTaksit.Name = "tbTaksit";
            this.tbTaksit.Size = new System.Drawing.Size(240, 45);
            this.tbTaksit.TabIndex = 6;
            this.tbTaksit.Scroll += new System.EventHandler(this.tbTaksit_Scroll);
            // 
            // lblTaksit
            // 
            this.lblTaksit.AutoSize = true;
            this.lblTaksit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaksit.Location = new System.Drawing.Point(337, 86);
            this.lblTaksit.Name = "lblTaksit";
            this.lblTaksit.Size = new System.Drawing.Size(21, 24);
            this.lblTaksit.TabIndex = 7;
            this.lblTaksit.Text = "0";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(66, 162);
            this.txtTutar.Multiline = true;
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(126, 31);
            this.txtTutar.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(399, 415);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lblTaksit);
            this.Controls.Add(this.tbTaksit);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblSonuc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbTaksit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TrackBar tbTaksit;
        private System.Windows.Forms.Label lblTaksit;
        private System.Windows.Forms.TextBox txtTutar;
    }
}

