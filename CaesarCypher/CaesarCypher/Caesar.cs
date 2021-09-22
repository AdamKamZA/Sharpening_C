using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCypher
{
    class Caesar:ParentCypher
    {
        //Hex code '!' to '~'
        byte start=33, end=126;
        string encrypted, decrypted;

        public string Encrypted { get => encrypted; set => encrypted = value; }
        public string Decrypted { get => decrypted; set => decrypted = value; }

        public Caesar() { }
        public Caesar(string input) : base(input) { }

        public void encrypt()
        {
            string temp = this.Input;
            string encrypt = "";
            //take each digit and shift its ascii value by one
            for(int i = 0; i < temp.Length; i++)
            {
                int ascii = (3 - (temp[i] + 1).ToString().Length);
                int val = temp[i] + 1;
                if (val > end)
                {
                    val = start;
                    ascii = 3-val.ToString().Length;
                }

                //formatting to correct length -000-
                StringBuilder str = new StringBuilder();
                str.Append('0', ascii);

                encrypt = string.Format($"{encrypt}{(str.ToString() + val)}");
            }
            this.Encrypted= encrypt;
        }

        public void decrypt()
        {
            try
            {
                string encrpyted = this.Encrypted;
                string decrypted = "";
                //split into 3's
                for (int i = 0; i < encrpyted.Length; i += 3)
                {
                    int temp = int.Parse(encrpyted.Substring(i, 3));
                    int val = temp - 1;
                    if (val < start)
                    {
                        val = end;
                    }

                    decrypted = string.Format($"{decrypted}{(char)(val)}");
                }
                this.Decrypted= decrypted;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Please make sure your word has been encrytped already");
                return;
            }
            
        }
    }
}
