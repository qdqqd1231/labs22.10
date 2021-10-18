using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace labs22._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Account save = new Account();
            Account corrent = new Account();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Input action : fill corrent, fill save, show correct or show save,Deposit or withdraw money or exit to exit the program : ");
                string type = Console.ReadLine().ToLower();
                if (type.Equals("exit"))
                {
                    flag = false;
                }
                if (type.Equals("fill corrent"))
                {
                    Console.Write("money : ");
                    decimal money;
                    while (!decimal.TryParse(Console.ReadLine(), out money)||money<0)
                    {
                        Console.WriteLine("Incorrect input money");
                    }
                    corrent.FillTheDataOfCorrentType(money);

                }
                else if (type.Equals("fill save"))
                {
                    Console.Write("money : ");
                    decimal money;
                    while (!decimal.TryParse(Console.ReadLine(), out money) || money < 0)
                    {
                        Console.WriteLine("Incorrect input money");
                    }
                    save.FillTheDataOfSavingType(money);

                }
                else if (type.Equals("show corrent"))
                {
                    corrent.WriteTheDataOfCorrentType();
                }
                else if (type.Equals("show save"))
                {
                    save.WriteTheDataOfSavingType();
                }
                else if(type.Equals("deposit"))
                {
                    Console.Write("Choose the type of account : saving or corrent\t\t");
                    string type0 = Console.ReadLine().ToLower();
                    if (type0.Equals("saving"))
                    {
                        Console.Write("enter volue : ");
                        decimal money;
                        while (!decimal.TryParse(Console.ReadLine(), out money) || money < 0)
                        {
                            Console.WriteLine("Incorrect volue money");
                        }
                        save.DepositMoney(money);
                    }
                    else if (type0.Equals("corrent"))
                    {
                        Console.Write("enter volue : ");
                        decimal money;
                        while (!decimal.TryParse(Console.ReadLine(), out money) || money < 0)
                        {
                            Console.WriteLine("Incorrect volue money");
                        }
                        corrent.DepositMoney(money);
                    }
                   
                }
                else if (type.Equals("withdraw"))
                {
                    Console.Write("Choose the type of account : saving or corrent\t\t");
                    string type0 = Console.ReadLine().ToLower();
                    if (type0.Equals("saving"))
                    {
                        Console.Write("enter volue : ");
                        decimal money;
                        while (!decimal.TryParse(Console.ReadLine(), out money) || money < 0)
                        {
                            Console.WriteLine("Incorrect volue money");
                        }
                        save.WithdrawMoney(money);
                    }
                    else if (type0.Equals("corrent"))
                    {
                        Console.Write("enter volue : ");
                        decimal money;
                        while (!decimal.TryParse(Console.ReadLine(), out money) || money < 0)
                        {
                            Console.WriteLine("Incorrect volue money");
                        }
                        corrent.WithdrawMoney(money);
                    }

                }
            }
        }

    }
}
