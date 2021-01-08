namespace Vrijeme {
    partial class VrijemeForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            this.cbGradovi = new System.Windows.Forms.ComboBox();
            this.lblGrad = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblVlaga = new System.Windows.Forms.Label();
            this.lblTlak = new System.Windows.Forms.Label();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.sslblOsvjezeno = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbNajtopliji = new System.Windows.Forms.ListBox();
            this.lbNajhladniji = new System.Windows.Forms.ListBox();
            this.lblNajtopliji = new System.Windows.Forms.Label();
            this.lblNajhladniji = new System.Windows.Forms.Label();
            this.tmrOsvjezi = new System.Windows.Forms.Timer(this.components);
            this.ssStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbGradovi
            // 
            this.cbGradovi.FormattingEnabled = true;
            this.cbGradovi.Location = new System.Drawing.Point(13, 13);
            this.cbGradovi.Name = "cbGradovi";
            this.cbGradovi.Size = new System.Drawing.Size(319, 21);
            this.cbGradovi.TabIndex = 0;
            this.cbGradovi.TextChanged += new System.EventHandler(this.cbGradovi_TextChanged);
            // 
            // lblGrad
            // 
            this.lblGrad.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGrad.Location = new System.Drawing.Point(12, 55);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(320, 39);
            this.lblGrad.TabIndex = 1;
            this.lblGrad.Text = "-";
            this.lblGrad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemperatura.Location = new System.Drawing.Point(13, 116);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(319, 39);
            this.lblTemperatura.TabIndex = 2;
            this.lblTemperatura.Text = "- °C";
            this.lblTemperatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVlaga
            // 
            this.lblVlaga.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVlaga.Location = new System.Drawing.Point(13, 155);
            this.lblVlaga.Name = "lblVlaga";
            this.lblVlaga.Size = new System.Drawing.Size(319, 39);
            this.lblVlaga.TabIndex = 3;
            this.lblVlaga.Text = "- %";
            this.lblVlaga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTlak
            // 
            this.lblTlak.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTlak.Location = new System.Drawing.Point(13, 194);
            this.lblTlak.Name = "lblTlak";
            this.lblTlak.Size = new System.Drawing.Size(319, 39);
            this.lblTlak.TabIndex = 4;
            this.lblTlak.Text = "- hPa";
            this.lblTlak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslblOsvjezeno});
            this.ssStatus.Location = new System.Drawing.Point(0, 448);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(344, 22);
            this.ssStatus.TabIndex = 5;
            this.ssStatus.Text = "statusStrip1";
            // 
            // sslblOsvjezeno
            // 
            this.sslblOsvjezeno.Name = "sslblOsvjezeno";
            this.sslblOsvjezeno.Size = new System.Drawing.Size(127, 17);
            this.sslblOsvjezeno.Text = "Zadnji put osvježeno: -";
            // 
            // lbNajtopliji
            // 
            this.lbNajtopliji.FormattingEnabled = true;
            this.lbNajtopliji.Location = new System.Drawing.Point(12, 275);
            this.lbNajtopliji.Name = "lbNajtopliji";
            this.lbNajtopliji.Size = new System.Drawing.Size(149, 160);
            this.lbNajtopliji.TabIndex = 6;
            // 
            // lbNajhladniji
            // 
            this.lbNajhladniji.FormattingEnabled = true;
            this.lbNajhladniji.Location = new System.Drawing.Point(183, 275);
            this.lbNajhladniji.Name = "lbNajhladniji";
            this.lbNajhladniji.Size = new System.Drawing.Size(149, 160);
            this.lbNajhladniji.TabIndex = 7;
            // 
            // lblNajtopliji
            // 
            this.lblNajtopliji.Location = new System.Drawing.Point(13, 256);
            this.lblNajtopliji.Name = "lblNajtopliji";
            this.lblNajtopliji.Size = new System.Drawing.Size(148, 16);
            this.lblNajtopliji.TabIndex = 8;
            this.lblNajtopliji.Text = "Najtopliji gradovi:";
            this.lblNajtopliji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNajhladniji
            // 
            this.lblNajhladniji.Location = new System.Drawing.Point(184, 256);
            this.lblNajhladniji.Name = "lblNajhladniji";
            this.lblNajhladniji.Size = new System.Drawing.Size(148, 16);
            this.lblNajhladniji.TabIndex = 9;
            this.lblNajhladniji.Text = "Najhladniji gradovi:";
            this.lblNajhladniji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrOsvjezi
            // 
            this.tmrOsvjezi.Interval = 300000;
            this.tmrOsvjezi.Tick += new System.EventHandler(this.tmrOsvjezi_Tick);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 470);
            this.Controls.Add(this.lblNajhladniji);
            this.Controls.Add(this.lblNajtopliji);
            this.Controls.Add(this.lbNajhladniji);
            this.Controls.Add(this.lbNajtopliji);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.lblTlak);
            this.Controls.Add(this.lblVlaga);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.cbGradovi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vrijeme";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGradovi;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblVlaga;
        private System.Windows.Forms.Label lblTlak;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel sslblOsvjezeno;
        private System.Windows.Forms.ListBox lbNajtopliji;
        private System.Windows.Forms.ListBox lbNajhladniji;
        private System.Windows.Forms.Label lblNajtopliji;
        private System.Windows.Forms.Label lblNajhladniji;
        private System.Windows.Forms.Timer tmrOsvjezi;
    }
}

