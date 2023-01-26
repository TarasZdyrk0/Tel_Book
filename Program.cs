using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tel_Book.Services;

namespace Tel_Book
{
    internal class Program
    {
    static void Main(string[] args)
        {
            ContactsService ContactsService = new ContactsService();
            Console.OutputEncoding = Encoding.GetEncoding(1251);

            Console.WriteLine("Дай Боже!!\nЦе вроді як телефонна книга\n");

            ContactsService.Contacts["nePidar"] = new List<string>() { "+380 68 300 4550", "123" };

            ContactsService Cs = new ContactsService();

            while (true) 
            {
                Console.WriteLine("\n\t1 - переглянути\n" +
                "\t2 - додати\n" +
                "\t3 - видалити\n" +
                "\t4 - редагувати\n" +
                "\t0 - Вихід");
                Console.Write("\nОберіть опцію: ");
                char option = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (option == '1')
                    Cs.PrintContacts();
                else if (option == '2')
                    Cs.AddContact();
                else if (option == '3')
                    Cs.RemoveContact();
                else if (option == '4')
                    Cs.ContactUpdate();
                else if (option == '0')
                    break;
                else
                    Console.WriteLine("Ви ввлели зуєту");
            }
            Console.WriteLine();
        } 
    }
}
