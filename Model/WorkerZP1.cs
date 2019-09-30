using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WorkerZP1 : Human, IZarplata //Почасовая оплата = СтоимостьЧас X КоличествоЧасов в месяц
    {

        private string profession; //Разные профессии - одна категория професиий, которые входят в этот класс и считаются по 1му варианту
        private uint experience;   //Стаж измеряется в полных годах
        private uint costHour;     //Стоимость одного часа измеряется в полных рублях (без копеек - дробных), и обязательно больше 0
        private uint numberHours;  // Количество отработанных полных часов
        private UInt64 zarplata; // Посчитанная зарплата хранится в объетке

    
        //Метод профессии
        public void ProfessionSet (string arg)
        {

            if (arg != null) profession = arg;
            else Console.WriteLine("вы не ввели профессию сотрудника");
        }
        public string ProfessionGet()
        {
            return profession;
        }

        //Метод Стажа
        public void ExperienceSet (string arg)
        {

            if (uint.TryParse(arg, out uint result) && arg != null && result < 100) experience = result;
            else Console.WriteLine("Ошибка ввода стажа сотрудника");
        }
        public uint EperienceGet()
        {
            return experience;
        }

        //Метод Стоимости Часа
        public void CostHourSet(string arg)
        {

            if (uint.TryParse(arg, out uint result) && arg != null && result < 1000) costHour = result;
            else Console.WriteLine("Ошибка ввода стоимости часа сотрудника");
        }
        public uint CostHourGet()
        {
            return costHour;
        }

        //Метод Количества часов
        public void NumberHoursSet(string arg)
        {

            if (uint.TryParse(arg, out uint result) && arg != null && result < 500) numberHours = result;
            else Console.WriteLine("Ошибка ввода количества отработанных часов");
        }
        public uint NumberHoursGet ()
        {
            return numberHours;
        }

        //Метод рассчета зарплаты для этого класса
         public void RaschetSet()
        {
            zarplata =  costHour * numberHours;
        }

        public UInt64 RaschetGet()
        {
            return zarplata;
        }
    }
}
