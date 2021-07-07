using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement_Amrit.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
