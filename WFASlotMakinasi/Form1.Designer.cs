namespace WFASlotMakinasi
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
            this.pbCheckPoint1 = new System.Windows.Forms.PictureBox();
            this.pbCheckPoint2 = new System.Windows.Forms.PictureBox();
            this.pbCheckPoint3 = new System.Windows.Forms.PictureBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblMusteriJeton = new System.Windows.Forms.Label();
            this.lblKazanmaSansi = new System.Windows.Forms.Label();
            this.lblKazanmaDurumu = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblKasadakiJeton = new System.Windows.Forms.Label();
            this.pbKol = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckPoint1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckPoint2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckPoint3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKol)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCheckPoint1
            // 
            this.pbCheckPoint1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCheckPoint1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbCheckPoint1.Location = new System.Drawing.Point(91, 206);
            this.pbCheckPoint1.Name = "pbCheckPoint1";
            this.pbCheckPoint1.Size = new System.Drawing.Size(145, 168);
            this.pbCheckPoint1.TabIndex = 0;
            this.pbCheckPoint1.TabStop = false;
            // 
            // pbCheckPoint2
            // 
            this.pbCheckPoint2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCheckPoint2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbCheckPoint2.Location = new System.Drawing.Point(264, 206);
            this.pbCheckPoint2.Name = "pbCheckPoint2";
            this.pbCheckPoint2.Size = new System.Drawing.Size(150, 168);
            this.pbCheckPoint2.TabIndex = 0;
            this.pbCheckPoint2.TabStop = false;
            // 
            // pbCheckPoint3
            // 
            this.pbCheckPoint3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCheckPoint3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbCheckPoint3.Location = new System.Drawing.Point(440, 206);
            this.pbCheckPoint3.Name = "pbCheckPoint3";
            this.pbCheckPoint3.Size = new System.Drawing.Size(144, 168);
            this.pbCheckPoint3.TabIndex = 0;
            this.pbCheckPoint3.TabStop = false;
            // 
            // lblDurum
            // 
            this.lblDurum.BackColor = System.Drawing.Color.Silver;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(68, 546);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(532, 62);
            this.lblDurum.TabIndex = 2;
            this.lblDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMusteriJeton
            // 
            this.lblMusteriJeton.BackColor = System.Drawing.Color.Transparent;
            this.lblMusteriJeton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMusteriJeton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriJeton.ForeColor = System.Drawing.Color.White;
            this.lblMusteriJeton.Location = new System.Drawing.Point(539, 411);
            this.lblMusteriJeton.Name = "lblMusteriJeton";
            this.lblMusteriJeton.Size = new System.Drawing.Size(46, 41);
            this.lblMusteriJeton.TabIndex = 3;
            this.lblMusteriJeton.Text = "0";
            this.lblMusteriJeton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMusteriJeton.Click += new System.EventHandler(this.lblMusteriJeton_Click);
            // 
            // lblKazanmaSansi
            // 
            this.lblKazanmaSansi.AutoSize = true;
            this.lblKazanmaSansi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKazanmaSansi.ForeColor = System.Drawing.Color.DarkRed;
            this.lblKazanmaSansi.Location = new System.Drawing.Point(301, 410);
            this.lblKazanmaSansi.Name = "lblKazanmaSansi";
            this.lblKazanmaSansi.Size = new System.Drawing.Size(24, 25);
            this.lblKazanmaSansi.TabIndex = 3;
            this.lblKazanmaSansi.Text = "0";
            // 
            // lblKazanmaDurumu
            // 
            this.lblKazanmaDurumu.AutoSize = true;
            this.lblKazanmaDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKazanmaDurumu.ForeColor = System.Drawing.Color.DarkRed;
            this.lblKazanmaDurumu.Location = new System.Drawing.Point(86, 406);
            this.lblKazanmaDurumu.Name = "lblKazanmaDurumu";
            this.lblKazanmaDurumu.Size = new System.Drawing.Size(191, 29);
            this.lblKazanmaDurumu.TabIndex = 3;
            this.lblKazanmaDurumu.Text = "Kazanma Şansı";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::WFASlotMakinasi.Properties.Resources.minimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(604, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImage = global::WFASlotMakinasi.Properties.Resources.exit;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(635, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(25, 25);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblKasadakiJeton
            // 
            this.lblKasadakiJeton.AutoSize = true;
            this.lblKasadakiJeton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasadakiJeton.ForeColor = System.Drawing.Color.DarkRed;
            this.lblKasadakiJeton.Location = new System.Drawing.Point(394, 406);
            this.lblKasadakiJeton.Name = "lblKasadakiJeton";
            this.lblKasadakiJeton.Size = new System.Drawing.Size(0, 13);
            this.lblKasadakiJeton.TabIndex = 3;
            this.lblKasadakiJeton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbKol
            // 
            this.pbKol.BackColor = System.Drawing.Color.Transparent;
            this.pbKol.BackgroundImage = global::WFASlotMakinasi.Properties.Resources.handle;
            this.pbKol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKol.Location = new System.Drawing.Point(606, 356);
            this.pbKol.Name = "pbKol";
            this.pbKol.Size = new System.Drawing.Size(74, 283);
            this.pbKol.TabIndex = 5;
            this.pbKol.TabStop = false;
            this.pbKol.Click += new System.EventHandler(this.pbKol_Click);
            this.pbKol.DoubleClick += new System.EventHandler(this.pbKol_DoubleClick);
            this.pbKol.MouseEnter += new System.EventHandler(this.pbKol_MouseEnter);
            this.pbKol.MouseLeave += new System.EventHandler(this.pbKol_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(242, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WFASlotMakinasi.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 637);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbKol);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.lblKazanmaDurumu);
            this.Controls.Add(this.lblKasadakiJeton);
            this.Controls.Add(this.lblKazanmaSansi);
            this.Controls.Add(this.lblMusteriJeton);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.pbCheckPoint3);
            this.Controls.Add(this.pbCheckPoint2);
            this.Controls.Add(this.pbCheckPoint1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Tomato;
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckPoint1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckPoint2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckPoint3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCheckPoint1;
        private System.Windows.Forms.PictureBox pbCheckPoint2;
        private System.Windows.Forms.PictureBox pbCheckPoint3;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblMusteriJeton;
        private System.Windows.Forms.Label lblKazanmaSansi;
        private System.Windows.Forms.Label lblKazanmaDurumu;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label lblKasadakiJeton;
        private System.Windows.Forms.PictureBox pbKol;
        private System.Windows.Forms.Label label2;
    }
}

