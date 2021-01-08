using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Notes {
    class NotesModel {

        public static List<Note> GetNotes() {
            List<Note> notes = new List<Note>();
            string query = "SELECT * FROM Notes";

            using(SqlConnection sqlConnection = new SqlConnection(Database.DatabaseConnectionString())) {
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                foreach(DataRow row in ds.Tables[0].Rows) {
                    notes.Add(new Note(
                        row["id"],
                        row["name"],
                        row["text"]
                    ));
                }
            }
            return notes;
        }

        public static bool AddNote(Note note) {
            string query = "INSERT INTO Notes (name, text) VALUES (@name, @text)";
            System.Console.WriteLine(Database.DatabaseConnectionString());
            using(SqlConnection sqlConnection = new SqlConnection(Database.DatabaseConnectionString())) {
                using(SqlCommand command = new SqlCommand(query, sqlConnection)) {
                    command.Parameters.AddWithValue("@name", note.Name);
                    command.Parameters.AddWithValue("@text", note.Text);

                    sqlConnection.Open();
                    int result = command.ExecuteNonQuery();
                    if(result < 0) {
                        return false;
                    }
                }
            }
            return true;
        }

        public static string GetNoteText(Note note) {
            string text;
            string query = "SELECT text FROM Notes where id = @Id";

            using(SqlConnection sqlConnection = new SqlConnection(Database.DatabaseConnectionString())) {
                using(SqlCommand command = new SqlCommand(query, sqlConnection)) {
                    command.Parameters.AddWithValue("@Id", note.Id);
                    sqlConnection.Open();
                    using(SqlDataReader reader = command.ExecuteReader()){
                        reader.Read();
                        text = (string)reader["text"];
                    };
                    
                }
               
               
            }
            return text;
        }

        public static bool UpdateNote(Note note) {
            string query = "UPDATE Notes SET name = @Name, text = @Text WHERE id = @Id";

            using(SqlConnection sqlConnection = new SqlConnection(Database.DatabaseConnectionString())) {
                using(SqlCommand command = new SqlCommand(query, sqlConnection)) {
                    command.Parameters.AddWithValue("@Id", note.Id);
                    command.Parameters.AddWithValue("@Name", note.Name);
                    command.Parameters.AddWithValue("@Text", note.Text);

                    sqlConnection.Open();
                    int result = command.ExecuteNonQuery();
                    if(result < 0) {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool DeleteNote(Note note) {
            string query = "DELETE FROM Notes WHERE Id = @Id";

            using(SqlConnection sqlConnection = new SqlConnection(Database.DatabaseConnectionString())) {
                using(SqlCommand command = new SqlCommand(query, sqlConnection)) {
                    command.Parameters.AddWithValue("@Id", note.Id);

                    sqlConnection.Open();
                    int result = command.ExecuteNonQuery();
                    if(result < 0) {
                        return false;
                    }
                }
            }
            return true;
        }
    }   
}
