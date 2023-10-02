namespace button._12
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltoplam = new System.Windows.Forms.Label();
            this.lblcarpım = new System.Windows.Forms.Label();
            this.lblfark = new System.Windows.Forms.Label();
            this.lblbolum = new System.Windows.Forms.Label();
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.txtsayi2 = new System.Windows.Forms.TextBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Sayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Sayı";
            // 
            // lbltoplam
            // 
            this.lbltoplam.AutoSize = true;
            this.lbltoplam.Location = new System.Drawing.Point(263, 186);
            this.lbltoplam.Name = "lbltoplam";
            this.lbltoplam.Size = new System.Drawing.Size(42, 13);
            this.lbltoplam.TabIndex = 2;
            this.lbltoplam.Text = "Toplam";
            // 
            // lblcarpım
            // 
            this.lblcarpım.AutoSize = true;
            this.lblcarpım.Location = new System.Drawing.Point(263, 263);
            this.lblcarpım.Name = "lblcarpım";
            this.lblcarpım.Size = new System.Drawing.Size(39, 13);
            this.lblcarpım.TabIndex = 3;
            this.lblcarpım.Text = "Çarpım";
            // 
            // lblfark
            // 
            this.lblfark.AutoSize = true;
            this.lblfark.Location = new System.Drawing.Point(263, 219);
            this.lblfark.Name = "lblfark";
            this.lblfark.Size = new System.Drawing.Size(28, 13);
            this.lblfark.TabIndex = 3;
            this.lblfark.Text = "Fark";
            // 
            // lblbolum
            // 
            this.lblbolum.AutoSize = true;
            this.lblbolum.Location = new System.Drawing.Point(263, 300);
            this.lblbolum.Name = "lblbolum";
            this.lblbolum.Size = new System.Drawing.Size(36, 13);
            this.lblbolum.TabIndex = 4;
            this.lblbolum.Text = "Bölüm";
            // 
            // txtsayi1
            // 
            this.txtsayi1.Location = new System.Drawing.Point(117, 63);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(100, 20);
            this.txtsayi1.TabIndex = 5;
            this.txtsayi1.TextChanged += new System.EventHandler(this.txtsayi1_TextChanged);
            // 
            // txtsayi2
            // 
            this.txtsayi2.Location = new System.Drawing.Point(117, 119);
            this.txtsayi2.Name = "txtsayi2";
            this.txtsayi2.Size = new System.Drawing.Size(100, 20);
            this.txtsayi2.TabIndex = 6;
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(117, 180);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(73, 67);
            this.btnhesapla.TabIndex = 7;
            this.btnhesapla.Text = "HESAPLA";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 426);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.txtsayi2);
            this.Controls.Add(this.txtsayi1);
            this.Controls.Add(this.lblbolum);
            this.Controls.Add(this.lblfark);
            this.Controls.Add(this.lblcarpım);
            this.Controls.Add(this.lbltoplam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltoplam;
        private System.Windows.Forms.Label lblcarpım;
        private System.Windows.Forms.Label lblfark;
        private System.Windows.Forms.Label lblbolum;
        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.TextBox txtsayi2;
        private System.Windows.Forms.Button btnhesapla;
    }
}

