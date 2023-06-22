using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontChat
{
    internal class Contato
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private Contato()
        {

        }

        public Contato(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
