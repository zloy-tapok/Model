using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public class WorkerZP2: Human, IZarplata //Оплата по окладу = Оклад / Количество рабочих дней (в месяце) X Количество факт отработанных дней (в месяце) 
  {
        private string profession; //Разные профессии - одна категория професиий, которые входят в этот класс и считаются по 2му варианту
        private uint experience;   //Стаж измеряется в полных годах
        private uint oklad;        //Оклад измеряется в целом положительном числе, рублях
        private uint numberDays;   
        private uint numberFactDays;
        private uint zarplata;
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

        //Метод Оклада
        public void OkladSet(string arg)
        {

            if (uint.TryParse(arg, out uint result) && arg != null && result < 100000) oklad = result;
            else Console.WriteLine("Ошибка ввода оклада");
        }
        public uint CostHourGet()
        {
            return oklad;
        }

        //Метод Количества положенных рабочих дней в месяце
        public void NumberDaysSet(string arg)
        {

            if (uint.TryParse(arg, out uint result) && arg != null && result < 32) numberDays = result;
            else Console.WriteLine("Ошибка ввода количества положенных дней");
        }
        public uint NumberDaysGet()
        {
            return numberDays;
        }

        //Метод Количества фактических рабочих дней в месяце
        public void NumberFactDaysSet(string arg)
        {

            if (uint.TryParse(arg, out uint result) && arg != null && result < 32) numberFactDays = result;
            else Console.WriteLine("Ошибка ввода количества отработанных дней");
        }
        public uint NumberFactDaysGet()
        {
            return numberFactDays;
        }

        //Метод рассчета зарплаты для этого класса
        public void RaschetSet()
        {
            zarplata = oklad / numberDays * numberFactDays;
        }

        public UInt64 RaschetGet()
        {
            return zarplata;
        }
    }
}

