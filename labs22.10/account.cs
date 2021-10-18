using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace labs22._10
{
    public enum BankAccountType
    { corrent, saving }

    public class Account
    {
        private Guid id;
        private decimal valueOfMoney;
        private BankAccountType type;

        
        public void DepositMoney(decimal depositValue)
        {
            valueOfMoney += depositValue;
        }
        public void WithdrawMoney(decimal withdrawValue)
        {
            if (withdrawValue>= valueOfMoney)
            {
                valueOfMoney -= withdrawValue;
            }
            else
            {
                Console.WriteLine("insufficient funds");
            }
            
        }
        public void FillTheDataOfSavingType(decimal newValue)
        {
            
            type = BankAccountType.saving;
            id = Guid.NewGuid();
            valueOfMoney = newValue;
               
        }
        public void FillTheDataOfCorrentType(decimal newValue)
        {

            type = BankAccountType.corrent;
            id = Guid.NewGuid();
            valueOfMoney = newValue;

        }
        public void WriteTheDataOfCorrentType()
        {
            Console.WriteLine($"Type:{type} \n ID : {id} \n Value of money : {valueOfMoney}");
        }
        public void WriteTheDataOfSavingType()
        {
            Console.WriteLine($"Type:{type} \n ID : {id} \n Value of money : {valueOfMoney}");
        }
    }
}
