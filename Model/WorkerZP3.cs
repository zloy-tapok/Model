using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WorkerZP3 : Human, IZarplata //Оплата по ставке = Ставка X Количество факт отработанных дней
    {
       

            private string profession; //Разные профессии - одна категория професиий, которые входят в этот класс и считаются по 1му варианту
            private uint experience;   //Стаж измеряется в полных годах
            private uint stavka;     //Суточная ставка
            private uint numberDays;  // Количество отработанных дней
            private UInt64 zarplata; // Посчитанная зарплата хранится в объетке


            //Метод профессии
            public void ProfessionSet(string arg)
            {

                if (arg != null) profession = arg;
                else Console.WriteLine("вы не ввели профессию сотрудника");
            }
            public string ProfessionGet()
            {
                return profession;
            }

            //Метод Стажа
            public void ExperienceSet(string arg)
            {

                if (uint.TryParse(arg, out uint result) && arg != null && result < 100) experience = result;
                else Console.WriteLine("Ошибка ввода стажа сотрудника");
            }
            public uint EperienceGet()
            {
                return experience;
            }

            //Метод Ставки
            public void StavkaSet(string arg)
            {

                if (uint.TryParse(arg, out uint result) && arg != null && result < 10000) stavka = result;
                else Console.WriteLine("Ошибка ввода стоимости суточной ставки");
            }
            public uint StavkaGet()
            {
                return stavka;
            }

            //Метод Количества отработанных дней
            public void NumberDaysSet(string arg)
            {

                if (uint.TryParse(arg, out uint result) && arg != null && result < 500) numberDays = result;
                else Console.WriteLine("Ошибка ввода количества отработанных часов");
            }
            public uint NumberDaysGet()
            {
                return numberDays;
            }

            //Метод рассчета зарплаты для этого класса
            public void RaschetSet()
            {
                zarplata = stavka * numberDays;
            }

            public UInt64 RaschetGet()
            {
                return zarplata;
            }
        }
}


