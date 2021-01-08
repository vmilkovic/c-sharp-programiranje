namespace Notes {
    partial class NotesForm {
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
            this.lbNotesList = new System.Windows.Forms.ListBox();
            this.btnNewNote = new System.Windows.Forms.Button();
            this.rtbNoteContent = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNotesList
            // 
            this.lbNotesList.FormattingEnabled = true;
            this.lbNotesList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNotesList.Location = new System.Drawing.Point(12, 12);
            this.lbNotesList.Name = "lbNotesList";
            this.lbNotesList.Size = new System.Drawing.Size(179, 355);
            this.lbNotesList.TabIndex = 0;
            this.lbNotesList.SelectedIndexChanged += new System.EventHandler(this.lbNotesList_SelectedIndexChanged);
            this.lbNotesList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbNotesList_KeyDown);
            // 
            // btnNewNote
            // 
            this.btnNewNote.Location = new System.Drawing.Point(12, 378);
            this.btnNewNote.Name = "btnNewNote";
            this.btnNewNote.Size = new System.Drawing.Size(179, 23);
            this.btnNewNote.TabIndex = 1;
            this.btnNewNote.Text = "Novi zapis";
            this.btnNewNote.UseVisualStyleBackColor = true;
            this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
            // 
            // rtbNoteContent
            // 
            this.rtbNoteContent.Location = new System.Drawing.Point(207, 12);
            this.rtbNoteContent.Name = "rtbNoteContent";
            this.rtbNoteContent.Size = new System.Drawing.Size(512, 355);
            this.rtbNoteContent.TabIndex = 2;
            this.rtbNoteContent.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(540, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Pohrani";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 413);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbNoteContent);
            this.Controls.Add(this.btnNewNote);
            this.Controls.Add(this.lbNotesList);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Notes";
            this.ShowIcon = false;
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Notes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbNotesList;
        private System.Windows.Forms.Button btnNewNote;
        private System.Windows.Forms.RichTextBox rtbNoteContent;
        private System.Windows.Forms.Button btnSave;
    }
}

