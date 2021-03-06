﻿using SQLite;

namespace BrainShare.Database
{
    [Table("Subject")]
    class Subject
    {
        [PrimaryKey]
        public int SubjectId { get; set; }
        public string name { get; set; }
        public string thumb { get; set; }
        public Subject() { }
        public Subject(int id, string _name, string _thumbnail)
        {
            SubjectId = id;
            name = _name;
            thumb = _thumbnail;
        }
    }
}
