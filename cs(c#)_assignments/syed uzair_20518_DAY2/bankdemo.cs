using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concepts
{
    public class bank
    {
        string name;
        int accno;
        int balance;
        public bank(string nam ,int acc)
        {
            name = nam;
            accno = acc;
            balance = 500;
        }
        public bank(string nam, int acc, int bal)
        {
            name = nam;
            accno = acc;
            balance = bal;
        }
        public string CustName()
        {
            return name;
        }
        public int AccNO()
        {
            return accno;
        }
        public int CustBal()
        {
            return balance;
        }


    }
    class bankdemo
    {
        public static void Main1()
        {
            bank b1 = new bank("syed", 100);
            Console.WriteLine("for example name is given as syed and account number as 100 and the balance is not given then ");
            Console.WriteLine("name-"+b1.CustName()+" account number-"+b1.AccNO()+" balance-"+b1.CustBal());
            Console.WriteLine("second example will be user input");
            Console.WriteLine("Please enter the name");
            string n = Console.ReadLine();
            Console.WriteLine("Please enter the Account number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter balance");
            int b = int.Parse(Console.ReadLine());
            bank b2 = new bank(n,a,b);
            Console.WriteLine("name-" + b2.CustName() + " account number-" + b2.AccNO() + " balance-" + b2.CustBal());

        }
    }
}
