using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glava19
{
    class Chapter2
    {
        public Chapter2()
        {
            // данные 
            Account[] accounts = { new Account("Tom", "Smith", "132", 100.23), 
                           new Account("Tom", "Smith", "132", 100.00), 
                           new Account("Ralph", "Jones", "436", -123.85), 
                           new Account("Ralph", "Jones", "454", 987.132), 
                           new Account("Ted", "Krammer", "436", 323.19), 
                           new Account("Ralph", "Jones", "132", -123.32), 
                           new Account("Sara", "Smith", "454", 501.40), 
                           new Account("Sara", "Smith", "436", 349.79), 
                           new Account("Sara", "Smith", "132", -345.00),  
                           new Account("Albert", "Smith", "454", -213.67), 
                           new Account("Betty", "Krammer","968", 546.67), 
                           new Account("Carl", "Smith", "132", -155.99), 
                           new Account("Jenny", "Jones", "968", 10.98) 
                         };

            #region запрос с сортировкой

            // сортировка по last name, first name, balance. 
            var accInfo = from acc in accounts
                          orderby acc.LastName, acc.FirstName, acc.AccountNumber, acc.Balance
                          select acc;

            Console.WriteLine("аккаунты в сортированном порядке: ");

            // выполнить запрос и вывести результат
            foreach (Account acc in accInfo)
            {
                // отступ у групп имен
                //if (str != acc.FirstName)
                //{
                //    Console.WriteLine();
                //    str = acc.FirstName;
                //}
                Console.WriteLine("{0}, {1}\tAcc#: {2}, {3,10:C}",
                                  acc.LastName, acc.FirstName,
                                  acc.AccountNumber, acc.Balance);
            }

            #endregion

            Console.WriteLine();

            #region запрос с созданием объекта

            // сортировка и вывод с созданием объекта
            var accName = from acc in accounts
                          orderby acc.AccountNumber
                          select new NameClient(acc.FirstName, acc.LastName, acc.AccountNumber);

            Console.WriteLine("имена аккаунта");

            foreach (NameClient acc in accName)
            {
                Console.WriteLine("{0} -  {1} {2}", acc.accNumber, acc.FirstName, acc.LastName);
            }

            #endregion

            Console.WriteLine();

            #region запрос группой group

            var accGroup = from acc in accounts
                           group acc by acc.AccountNumber;

            foreach (var account in accGroup)
            {
                Console.WriteLine("аккаунты с индексом: " + account.Key);
                foreach (var acc in account)
                {
                    Console.WriteLine("  " + acc.FirstName + " " + acc.LastName);
                }

            }

            #endregion

            Console.WriteLine();

            #region запрос группой group с продолжением into

            var accGroup2 = from acc in accounts
                            group acc by acc.AccountNumber
                                into acc2 // продолжить
                                where acc2.Count() > 2
                                select acc2
                                    into acc3 // продолжить
                                    where acc3.Count() > 3
                                    select acc3;


            foreach (var account in accGroup2)
            {
                Console.WriteLine("аккаунты с индексом: " + account.Key);
                foreach (var acc in account)
                {
                    Console.WriteLine("  " + acc.FirstName + " " + acc.LastName);
                }

            }

            #endregion
        }
    }
}

class Account
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public double Balance { get; private set; }
    public string AccountNumber { get; private set; }

    public Account(string fn, string ln, string accnum, double b)
    {
        FirstName = fn;
        LastName = ln;
        AccountNumber = accnum;
        Balance = b;
    }
}

class NameClient
{
    public string FirstName;
    public string LastName;
    public string accNumber;

    public NameClient(string fName, string lName, string i)
    {
        FirstName = fName;
        LastName = lName;
        accNumber = i;
    }
}
