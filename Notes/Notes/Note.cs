namespace Notes {
    class Note {

        public Note(object name, object text) {
            Name = (string) name;
            Text = (string)text;
        }

        public Note(object id, object name, object text) {
            Id = (int)id;
            Name = (string)name;
            Text = (string)text;
        }

        public override string ToString() {
            return string.Format("{0}", Name);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
    }
}
