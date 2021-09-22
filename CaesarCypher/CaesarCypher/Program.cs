using System;

namespace CaesarCypher
{
    class Program
    {
        enum Menu
        {
            encrypt=1,
            decrypt,
            viewBoth,
            Exit
        }
        static void Main(string[] args)
        {
            //get user input 
            //run encrypt and display, then provide option to decrypt
            bool flag = true;
            Caesar encObj = new Caesar();
            do
            {
                Console.WriteLine("1. Encrypt\n2. Decrypt\n3. View Both\n4. Exit");
                int choice = int.Parse(Console.ReadLine());
                Menu uChoice = (Menu)choice;
                
                switch (uChoice)
                {
                    case Menu.encrypt:
                        Console.WriteLine("Please enter a string to encrypted");
                        string word = Console.ReadLine();
                        encObj.Input = word;
                        encObj.encrypt();
                        Console.WriteLine($"Your encrypted string is: {encObj.Encrypted}");
                        break;
                    case Menu.decrypt:
                        encObj.decrypt();
                        Console.WriteLine($"Your encrypted string is: {encObj.Decrypted}");
                        break;
                    case Menu.viewBoth:
                        Console.WriteLine($"Entered String: {encObj.Input}");
                        Console.WriteLine($"Encrypted String: {encObj.Encrypted}");
                        Console.WriteLine($"Decrypted String: {encObj.Decrypted}");
                        break;
                    case Menu.Exit:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please enter valid input");
                        break;
                }
            } while (flag);
           
        }    

    }
}
