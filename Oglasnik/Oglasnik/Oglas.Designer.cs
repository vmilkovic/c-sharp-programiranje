namespace Oglasnik {
    partial class Oglas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblNaslovOglasa = new System.Windows.Forms.Label();
            this.txtNaslovOglasa = new System.Windows.Forms.TextBox();
            this.txtTekstOglasa = new System.Windows.Forms.RichTextBox();
            this.lblTekstOglasa = new System.Windows.Forms.Label();
            this.checkBoxSlika = new System.Windows.Forms.CheckBox();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.checkBoxVideo = new System.Windows.Forms.CheckBox();
            this.txtVideo = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblOglasi = new System.Windows.Forms.Label();
            this.txtOglasi = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblNaslovOglasa
            // 
            this.lblNaslovOglasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslovOglasa.Location = new System.Drawing.Point(12, 25);
            this.lblNaslovOglasa.Name = "lblNaslovOglasa";
            this.lblNaslovOglasa.Size = new System.Drawing.Size(110, 35);
            this.lblNaslovOglasa.TabIndex = 0;
            this.lblNaslovOglasa.Text = "Naslov oglasa:";
            this.lblNaslovOglasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNaslovOglasa
            // 
            this.txtNaslovOglasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.txtNaslovOglasa.Location = new System.Drawing.Point(15, 65);
            this.txtNaslovOglasa.Name = "txtNaslovOglasa";
            this.txtNaslovOglasa.Size = new System.Drawing.Size(200, 19);
            this.txtNaslovOglasa.TabIndex = 1;
            // 
            // txtTekstOglasa
            // 
            this.txtTekstOglasa.Location = new System.Drawing.Point(15, 140);
            this.txtTekstOglasa.Name = "txtTekstOglasa";
            this.txtTekstOglasa.Size = new System.Drawing.Size(200, 200);
            this.txtTekstOglasa.TabIndex = 2;
            this.txtTekstOglasa.Text = "";
            // 
            // lblTekstOglasa
            // 
            this.lblTekstOglasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTekstOglasa.Location = new System.Drawing.Point(12, 100);
            this.lblTekstOglasa.Name = "lblTekstOglasa";
            this.lblTekstOglasa.Size = new System.Drawing.Size(110, 35);
            this.lblTekstOglasa.TabIndex = 3;
            this.lblTekstOglasa.Text = "Tekst oglasa:";
            this.lblTekstOglasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxSlika
            // 
            this.checkBoxSlika.AutoSize = true;
            this.checkBoxSlika.Location = new System.Drawing.Point(15, 360);
            this.checkBoxSlika.Name = "checkBoxSlika";
            this.checkBoxSlika.Size = new System.Drawing.Size(91, 17);
            this.checkBoxSlika.TabIndex = 4;
            this.checkBoxSlika.Text = "Slikovni oglas";
            this.checkBoxSlika.UseVisualStyleBackColor = true;
            this.checkBoxSlika.Click += new System.EventHandler(this.checkBoxSlika_Click);
            // 
            // txtSlika
            // 
            this.txtSlika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.txtSlika.Location = new System.Drawing.Point(15, 390);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(200, 19);
            this.txtSlika.TabIndex = 5;
            // 
            // checkBoxVideo
            // 
            this.checkBoxVideo.AutoSize = true;
            this.checkBoxVideo.Location = new System.Drawing.Point(15, 430);
            this.checkBoxVideo.Name = "checkBoxVideo";
            this.checkBoxVideo.Size = new System.Drawing.Size(81, 17);
            this.checkBoxVideo.TabIndex = 6;
            this.checkBoxVideo.Text = "Video oglas";
            this.checkBoxVideo.UseVisualStyleBackColor = true;
            this.checkBoxVideo.Click += new System.EventHandler(this.checkBoxVideo_Click);
            // 
            // txtVideo
            // 
            this.txtVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.txtVideo.Location = new System.Drawing.Point(15, 460);
            this.txtVideo.Name = "txtVideo";
            this.txtVideo.Size = new System.Drawing.Size(200, 19);
            this.txtVideo.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(15, 505);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(200, 35);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj oglas";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblOglasi
            // 
            this.lblOglasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOglasi.Location = new System.Drawing.Point(257, 25);
            this.lblOglasi.Name = "lblOglasi";
            this.lblOglasi.Size = new System.Drawing.Size(110, 35);
            this.lblOglasi.TabIndex = 9;
            this.lblOglasi.Text = "Oglasi:";
            this.lblOglasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOglasi
            // 
            this.txtOglasi.Location = new System.Drawing.Point(260, 65);
            this.txtOglasi.Name = "txtOglasi";
            this.txtOglasi.Size = new System.Drawing.Size(291, 475);
            this.txtOglasi.TabIndex = 10;
            this.txtOglasi.Text = "";
            // 
            // Oglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 654);
            this.Controls.Add(this.txtOglasi);
            this.Controls.Add(this.lblOglasi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtVideo);
            this.Controls.Add(this.checkBoxVideo);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.checkBoxSlika);
            this.Controls.Add(this.lblTekstOglasa);
            this.Controls.Add(this.txtTekstOglasa);
            this.Controls.Add(this.txtNaslovOglasa);
            this.Controls.Add(this.lblNaslovOglasa);
            this.Name = "Oglas";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslovOglasa;
        private System.Windows.Forms.TextBox txtNaslovOglasa;
        private System.Windows.Forms.RichTextBox txtTekstOglasa;
        private System.Windows.Forms.Label lblTekstOglasa;
        private System.Windows.Forms.CheckBox checkBoxSlika;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.CheckBox checkBoxVideo;
        private System.Windows.Forms.TextBox txtVideo;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblOglasi;
        private System.Windows.Forms.RichTextBox txtOglasi;
    }
}

