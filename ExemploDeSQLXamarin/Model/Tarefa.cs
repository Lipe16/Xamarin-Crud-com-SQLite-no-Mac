using System;
using SQLite;

namespace ExemploDeSQLXamarin.Model
{
    [Table("Tarefa")]
    public class Tarefa
    {   
        [PrimaryKey, AutoIncrement]// semelhante a anotation do hibernate
        public int id { get; set; }

        public string nome { get; set; }
        public bool finalizado { get; set; }
    }
}
