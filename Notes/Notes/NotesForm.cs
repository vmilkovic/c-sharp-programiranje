using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Notes {
    public partial class NotesForm : Form {

        private int selectedNote;

        public NotesForm() {
            InitializeComponent();
        }

        private void Notes_Load(object sender, EventArgs e) {
            RefreshNotesList();
        }

        private void RefreshNotesList() {
            lbNotesList.Items.Clear();

            /*var notes = NotesModel.GetNotes();
            foreach(var note in notes) {
                lbNotesList.Items.Add(note);
            }*/
            
            using(var context = new NotesEntities()) {
                foreach(Notes note in context.Notes) {
                    lbNotesList.Items.Add(note);
                }
            }
           
           
        }

        private void btnNewNote_Click(object sender, EventArgs e) {
            string input = Interaction.InputBox("Unesite note", "Notes");
            
            /*var note = new Note(input, "");
            if(!NotesModel.AddNote(note)) {
                MessageBox.Show("Doslo je do greške prilikom unosa Nota!",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            var context = new NotesEntities();
            var newNote = new Notes() {
                name = input, text = ""
            };
            context.Notes.Add(newNote);
            context.SaveChanges();
            RefreshNotesList();
            
        }

        private void lbNotesList_SelectedIndexChanged(object sender, EventArgs e) {
            selectedNote = lbNotesList.SelectedIndex;

            /*var note = (Note)lbNotesList.Items[selectedNote];
            rtbNoteContent.Text = NotesModel.GetNoteText(note);*/

            var notes = (Notes)lbNotesList.Items[selectedNote];
            var context = new NotesEntities();
            rtbNoteContent.Text = context.Notes.First(n => n.id == notes.id).text;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            /*var note = (Note)lbNotesList.Items[selectedNote];
            note.Text = rtbNoteContent.Text;
            NotesModel.UpdateNote(note);*/

            var notes = (Notes)lbNotesList.Items[selectedNote];
            var context = new NotesEntities();
            var resultNote = context.Notes.First(n => n.id == notes.id);

            if( resultNote != null) {
                resultNote.text = rtbNoteContent.Text;
                context.SaveChanges();
            }

        }

        private void lbNotesList_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Delete) {
                if(selectedNote != -1) {
                    rtbNoteContent.Text = "";

                    /*var note = (Note)lbNotesList.Items[selectedNote];
                    NotesModel.DeleteNote(note);*/

                    var notes = (Notes)lbNotesList.Items[selectedNote];
                    Notes selectedNoteEntity = new Notes() { id = notes.id };
                    var context = new NotesEntities();
                    context.Notes.Attach(selectedNoteEntity);
                    context.Notes.Remove(selectedNoteEntity);
                    context.SaveChanges();
                    RefreshNotesList();
                }
            }
        }
    }
}
