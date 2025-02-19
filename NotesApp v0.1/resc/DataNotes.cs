using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp_v0._1
{
    public class DataNotes
    {
        public string Name { get; set; }
        public string NumberPhone { get; set; }

        public DataNotes(string name, string numberPhone)
        {
            Name = name;
            NumberPhone = numberPhone;
        }
    }
}
