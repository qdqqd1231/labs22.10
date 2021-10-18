using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs22._10
{
    public enum BankAccountType
    { corrent, saving }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input action : fill correct, fill save, show correct or show save ");
            string type = Console.ReadLine().ToLower();
            Account save = new Account();
            Account corrent = new Account();
            while (!type.Equals("exit"))
            {
                if (type.Equals("fill corrent"))
                {
                    Console.WriteLine("money : ");
                    decimal money = decimal.Parse(Console.ReadLine());
                    corrent.FillTheDataOfCorrentType(money);

                }
                else if (type.Equals("fill save"))
                {
                    Console.WriteLine("money : ");
                    decimal money = decimal.Parse(Console.ReadLine());
                    save.FillTheDataOfSavingType(money);

                }
                if (type.Equals("show corrent"))
                {
                    corrent.WriteTheDataOfCorrentType();
                }
                else if (type.Equals("show save"))
                {
                    save.WriteTheDataOfSavingType();
                }
            }

        }
    }
}
