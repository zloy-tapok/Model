using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
 /// <summary>
 /// Базовый класс Человек, от которого будут насследоваться остальные классы.
 /// </summary>
    public class Human 
    {
        protected string FirstName; 
        protected string SecondName; 
        protected string LastName;
        protected uint age = 0;
        //public uint AgeSet
        //{
        //    get { return age; }
           
        //    set
        //    {
        //        if (uint.TryParse(value, out uint result))
        //        {
        //            age = result;
        //        }
        //        else Console.WriteLine("Ошибка ввода возраста блэт");
        //    }
        //}
        protected long phone = 0;
        public static int count = 0;
       
        //Метод Имени
        public void FirstNameSet(string arg)
        {

            if (arg != null) FirstName = arg;
            else Console.WriteLine("Вы не ввели Имя");
        }
        public string FirstNameGet()
        {
            return FirstName;
        }

        //Метод Фамилии
        public void SecondNameSet(string arg)
        {

            if (arg != null) SecondName = arg;
            else Console.WriteLine("Вы не ввели Фамилию");
        }
        public string SecondNameGet()
        {
            return SecondName;
        }

        // Метод отчества
        public void LastNameSet(string arg)
        {

            if (arg != null) LastName = arg;
            else Console.WriteLine("Вы не ввели Отчество");
        }
        public string LastNameGet()
        {
            return LastName;
        }
        //Метод возраста
        public void AgeSet(string arg)
        {
           // while (true)
         //   {
                if (uint.TryParse(arg, out uint result) && arg != null && result < 150)
                {
                    age = result;
             //       break;
                }
                else Console.WriteLine("Ошибка ввода возраста");
           // }
        }
        public uint AgeGet()
        {
            return age;
        }

        //Метод номера телефона
        public void PhoneSet(string arg)
        {

            if (Int64.TryParse(arg, out long result) && arg != null) phone = result;
            else Console.WriteLine("Ошибка ввода номера телефона");
        }
        public long PhoneGet()
        {
            return phone;
        }
    }
        
           
}
