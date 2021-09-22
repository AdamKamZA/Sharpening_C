using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCypher
{
    class ParentCypher
    {
        string input;
        public ParentCypher() { }
        public ParentCypher(string input)
        {
            this.Input = input;
        }

        public string Input { get => input; set => input = value; }
    }
}
