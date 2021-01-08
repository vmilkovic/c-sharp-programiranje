namespace Pomodoro {
    partial class PomodoroForm {
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
            this.components = new System.ComponentModel.Container();
            this.lblRad = new System.Windows.Forms.Label();
            this.tbRad = new System.Windows.Forms.TextBox();
            this.tbOdmor = new System.Windows.Forms.TextBox();
            this.lblOdmor = new System.Windows.Forms.Label();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tmrOdbrojavanje = new System.Windows.Forms.Timer(this.components);
            this.lblPrikazRad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRad
            // 
            this.lblRad.AutoSize = true;
            this.lblRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRad.Location = new System.Drawing.Point(75, 40);
            this.lblRad.Name = "lblRad";
            this.lblRad.Size = new System.Drawing.Size(43, 20);
            this.lblRad.TabIndex = 0;
            this.lblRad.Text = "Rad:";
            // 
            // tbRad
            // 
            this.tbRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbRad.Location = new System.Drawing.Point(44, 72);
            this.tbRad.Name = "tbRad";
            this.tbRad.Size = new System.Drawing.Size(100, 26);
            this.tbRad.TabIndex = 1;
            this.tbRad.Text = "25";
            // 
            // tbOdmor
            // 
            this.tbOdmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOdmor.Location = new System.Drawing.Point(320, 72);
            this.tbOdmor.Name = "tbOdmor";
            this.tbOdmor.Size = new System.Drawing.Size(100, 26);
            this.tbOdmor.TabIndex = 3;
            this.tbOdmor.Text = "5";
            // 
            // lblOdmor
            // 
            this.lblOdmor.AutoSize = true;
            this.lblOdmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdmor.Location = new System.Drawing.Point(340, 40);
            this.lblOdmor.Name = "lblOdmor";
            this.lblOdmor.Size = new System.Drawing.Size(61, 20);
            this.lblOdmor.TabIndex = 2;
            this.lblOdmor.Text = "Odmor:";
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVrijeme.Location = new System.Drawing.Point(44, 145);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(376, 42);
            this.lblVrijeme.TabIndex = 4;
            this.lblVrijeme.Text = "25:00";
            this.lblVrijeme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(44, 236);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(100, 40);
            this.btnStartStop.TabIndex = 6;
            this.btnStartStop.Text = "Start / Stop";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(320, 236);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 40);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tmrOdbrojavanje
            // 
            this.tmrOdbrojavanje.Interval = 1000;
            this.tmrOdbrojavanje.Tick += new System.EventHandler(this.tmrOdbrojavanje_Tick);
            // 
            // lblPrikazRad
            // 
            this.lblPrikazRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrikazRad.Location = new System.Drawing.Point(44, 103);
            this.lblPrikazRad.Name = "lblPrikazRad";
            this.lblPrikazRad.Size = new System.Drawing.Size(376, 42);
            this.lblPrikazRad.TabIndex = 8;
            this.lblPrikazRad.Text = "RAD";
            this.lblPrikazRad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 315);
            this.Controls.Add(this.lblPrikazRad);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lblVrijeme);
            this.Controls.Add(this.tbOdmor);
            this.Controls.Add(this.lblOdmor);
            this.Controls.Add(this.tbRad);
            this.Controls.Add(this.lblRad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pomodoro";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRad;
        private System.Windows.Forms.TextBox tbRad;
        private System.Windows.Forms.TextBox tbOdmor;
        private System.Windows.Forms.Label lblOdmor;
        private System.Windows.Forms.Label lblVrijeme;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer tmrOdbrojavanje;
        private System.Windows.Forms.Label lblPrikazRad;
    }
}

