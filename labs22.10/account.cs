using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs22._10
{
    public class Account
    {
        private Guid id;
        private decimal valueOfMoney;
        private BankAccountType type;

        
        public  Account FillTheDataOfSavingType(decimal valueOfMoney)
        {
            var acc = new Account();
            acc.type = BankAccountType.corrent;
            acc.id = new Guid();
            acc.valueOfMoney = Decimal.Parse(Console.ReadLine());
            return acc ;    
        }
        public  Account FillTheDataOfCorrentType(decimal valueOfMoney)
        {
            var acc = new Account();
            acc.type = BankAccountType.corrent;
            acc.id = new Guid();
            acc.valueOfMoney = Decimal.Parse(Console.ReadLine());
            return acc;
        }

        public void WriteTheDataOfCorrentType(Account FillTheDataOfCorrentType)
        {
            Console.WriteLine($"Type:{type} \n ID : {id} \n Value of money : {valueOfMoney}");           
        }
    }




}
