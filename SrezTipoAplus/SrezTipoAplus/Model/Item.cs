using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SrezTipoAplus.Model
{
    [Table("Projects")]
    public class Item
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID { get; set; }
        [Unique]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
    }
}
