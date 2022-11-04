//atm machine 
//ATM
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class ACCOUNT
{
    public string id { get; set; }
    public string pin { get; set; }
    public char acctype { get; set; }
    public string name { get; set; }
    public string bankname { get; set; }
      
    public double balance { get; set; } 
}
    public class ATM : ACCOUNT
    {
        public  double deposit()
    {
        Console.WriteLine("enter the amount you want to deposit : ");
        double deposit=double.Parse(Console.ReadLine());
        balance = deposit + balance;
        
        Console.ReadLine();
        return balance;

    }
        public  double  withdraw()
    {
        Console.WriteLine("enter the amount you want to deposit : ");
        double withdraw = double.Parse(Console.ReadLine());
        balance = withdraw - balance;

        Console.ReadLine();
        return balance;
    }

    }


//double balance =double.parse(console.reline




public class Program
{
    static void Main(string[] args)
    {
        // employees.Add(new employee() { id = 101, experience = 6, name = "taimoor"});

        List<ACCOUNT> acc = new List<ACCOUNT>();
        //ACCOUNT a1;

        acc.Add(new ACCOUNT() { id = "1011", pin = "1234", name = "UMER", acctype = 'S', bankname = "MEEZAN BANK",balance=95000 });
        acc.Add(new ACCOUNT() { id = "1023", pin = "1234", name = "TAIMOOR", acctype = 'S', bankname = "DUBAI ISLAMIC  BANK" ,balance=45000});
        acc.Add(new ACCOUNT() { id = "1012", pin = "1234", name = "ASAD", acctype = 'C', bankname = "ALFALAH BANK",balance=30000 }); 
        acc.Add(new ACCOUNT() { id = "1034", pin = "1234", name = "ALI", acctype = 'S', bankname = "HBL BANK" ,balance=60000});
        acc.Add(new ACCOUNT() { id = "1087", pin = "1234", name = "AHMED", acctype = 'C', bankname = "ABL BANK",balance=80000 });
        acc.Add(new ACCOUNT() { id = "1077", pin = "1234", name = "AMIR", acctype = 'C', bankname = "STANDARD CHARATED BANK" ,balance=10000});



        Console.WriteLine("--------------------------welcome to world bank atm ---------------------------- ");
        Console.WriteLine("please insert your card ");
        Console.WriteLine("processing  ");
        Console.WriteLine("..................");
        Console.WriteLine("please enter the bankid  : ");
        string debitnum = " ";
        // ACCOUNT accountuser=new ACCOUNT();
        debitnum = Console.ReadLine();
        foreach (ACCOUNT account in acc)
        {
            if (account.id == debitnum)
            {
                Console.WriteLine("your details are ---------------------------------------------- \n BANK ID:  {0} \n NAME: {1}  \n BANK NAME:  {2}\n---------------------------------   ", account.id, account.name, account.bankname);
                Console.ReadLine();
            }
        }

        Console.WriteLine("\n");
        Console.WriteLine("please enter the pin : ");
        string pin = " ";
        pin = Console.ReadLine();
        bool flag = true;
        foreach (ACCOUNT aCCOUNT in acc)
        {

            if (aCCOUNT.pin == pin)
            {
                Console.WriteLine("you have successfully entered into your bank account .");
                Console.ReadLine();
                flag = false;
                bool flag2 = false;


                while (flag2 == false)
                {
                    Console.WriteLine("enter the account type      S FOR SAving and     C FOR CURRENT : \n ");
                    char type = char.Parse(Console.ReadLine());

                    if (type == aCCOUNT.acctype)
                    {
                        flag2 = true;

                    }
                    else
                    {
                        Console.WriteLine("WRONG TYPE PLEASE TYPE AGAIN ");
                    }

                }




                if (flag == false)
                {
                    ATM a1 = new ATM();
                    int option = 0;
                    do
                    {
                        Console.WriteLine(" 1.Cash DEPOSIT");
                        Console.WriteLine(" 2.Balance Enquiry ");
                        Console.WriteLine(" 3. Cash Withdrawal ");
                        Console.WriteLine(" 4.exit ");

                        Console.WriteLine("please select what you want to do : ");



                        try
                        {
                            option = int.Parse(Console.ReadLine());
                        }
                        catch { }
                        if (option == 1)
                        {
                            double cash;
                            cash = a1.deposit();
                            aCCOUNT.balance = cash + aCCOUNT.balance;
                            Console.WriteLine("amount deposited successfully   your new balance is : \n {0}", aCCOUNT.balance);
                            Console.ReadLine();


                        }
                        if (option == 2)
                        {
                            Console.WriteLine("YOUR RECEIPT IS : ");
                            Console.WriteLine("\n");
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine("       {0}        ", aCCOUNT.bankname);
                            Console.WriteLine("NAME      : {0}", aCCOUNT.name);
                            Console.WriteLine("ID        : {0}", aCCOUNT.id);
                            // Console.WriteLine("BANK NAME : {0}", aCCOUNT.bankname);
                            Console.WriteLine("BALANCE   : {0} \n", aCCOUNT.balance);
                            Console.WriteLine("-----------------------------------");
                        }
                        if (option == 3)
                        {
                            double cash;
                            cash = a1.withdraw();
                            aCCOUNT.balance = aCCOUNT.balance - cash;
                            Console.WriteLine("amount withdrawed successfully   your new balance is : \n {0}", aCCOUNT.balance);
                            Console.ReadLine();

                        }
                        if (option == 4)
                        {
                            Console.WriteLine("THANK YOU  FOR  BANKING WITH US  ");
                            break;
                        }


                    } while (option != 4);
                }









            }
            else
            {
                Console.WriteLine("wrong password please try again by starting again ");
            }
            Console.ReadLine();
        }
       
    }
}
    







