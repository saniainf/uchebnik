using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chapter2
{
    class Chapter2
    {
        // ограничение на базовый класс
        public Chapter2()
        {
            // этот код ОК так как Friend наследуется от PhoneNumber 
            PhoneList<Friend> plist = new PhoneList<Friend>();
            plist.Add(new Friend("Tom", "555-1234", true));
            plist.Add(new Friend("Gary", "555-6756", true));
            plist.Add(new Friend("Matt", "555-9254", false));

            try
            {
                // вернуть номер по имени
                Friend frnd = plist.FindByName("Gary");

                Console.Write(frnd.Name + ": " + frnd.Number);

                if (frnd.IsWorkNumber)
                    Console.WriteLine(" (work)");
                else
                    Console.WriteLine();
            }
            catch (NotFoundException)
            {
                Console.WriteLine("Not Found");
            }

            Console.WriteLine();

            // код ОК так как Supplier наследуется от PhoneNumber
            PhoneList<Supplier> plist2 = new PhoneList<Supplier>();
            plist2.Add(new Supplier("Global Hardware", "555-8834"));
            plist2.Add(new Supplier("Computer Warehouse", "555-9256"));
            plist2.Add(new Supplier("NetworkCity", "555-2564"));

            try
            {
                // вернуть номер по имени 
                Supplier sp = plist2.FindByNumber("555-2564");
                Console.WriteLine(sp.Name + ": " + sp.Number);
            }
            catch (NotFoundException)
            {
                Console.WriteLine("Not Found");
            }

            // код BAD EmailFriend не наследуется и не пройдет ограничение
            //    PhoneList<EmailFriend> plist3 = 
            //        new PhoneList<EmailFriend>(); // Error! 
        }
    }

    // исключение для ненайденного номера
    class NotFoundException : Exception
    {
        public NotFoundException() : base() { }
        public NotFoundException(string message) : base(message) { }
        public NotFoundException(string message, Exception innerException) :
            base(message, innerException) { }
        protected NotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) :
            base(info, context) { }
    }

    // базовый класс содержащий имя и номер
    class PhoneNumber
    {

        public PhoneNumber(string n, string num)
        {
            Name = n;
            Number = num;
        }

        public string Number { get; set; }
        public string Name { get; set; }

    }

    // класс для тел друзей, наследуется от PhoneNumber
    class Friend : PhoneNumber
    {

        public Friend(string n, string num, bool wk) :
            base(n, num)
        {
            IsWorkNumber = wk;
        }

        public bool IsWorkNumber { get; private set; }

        // ... 
    }

    // класс для тел поставщиков, наследуется от PhoneNumber
    class Supplier : PhoneNumber
    {
        public Supplier(string n, string num) :
            base(n, num) { }

        // ... 
    }

    // этот клас не наследут базовый и неможет быть параметром type
    class EmailFriend
    {
        // ... 
    }

    // класс для управления списками, ограничение базового класса PhoneNumber
    class PhoneList<Tkey> where Tkey : PhoneNumber
    {
        Tkey[] phList;
        int end;

        public PhoneList()
        {
            phList = new Tkey[10];
            end = 0;
        }

        // добавить в список 
        public bool Add(Tkey newEntry)
        {
            if (end == 10) return false;

            phList[end] = newEntry;
            end++;

            return true;
        }

        // вернуть сведения по имени
        public Tkey FindByName(string name)
        {

            for (int i = 0; i < end; i++)
            {
                // Name доступно так как есть в базовом классе 
                if (phList[i].Name == name)
                    return phList[i];
            }

            // имени в списке нет, сгенерить исключение
            throw new NotFoundException();
        }

        // вернуть сведения по номеру
        public Tkey FindByNumber(string number)
        {

            for (int i = 0; i < end; i++)
            {
                // Number доступно так как есть в базовом классе
                if (phList[i].Number == number)
                    return phList[i];
            }

            // номера в списке нет, сгенерить исключение
            throw new NotFoundException();
        }

        // ... 
    }
}
