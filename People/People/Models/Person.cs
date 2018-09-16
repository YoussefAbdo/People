using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Models
{
    [Table("person")]
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { set; get; }
        [MaxLength(250), Unique]
        public string Name { get; set; }
    }
}
