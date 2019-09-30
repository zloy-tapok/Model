using System;
using System.Collections.Generic;
using Model;

namespace ConsoleModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько вы хотите добавить человек в программу: ");
            string Squantity = Console.ReadLine();
            uint Qcycle = 0;
            if (uint.TryParse(Squantity, out uint Uquantity) && Squantity != null && Uquantity < 101) Qcycle = Uquantity;
            else Console.WriteLine("Либо неверный формат, либо хотите больше 100 человек добавить - это очень сложно");
            var SpisokHumans = new List <Human>();

            for(int i = 0 ;i < Qcycle; i++)  //заполняем базовый список коллекцию ФизЛицами
            {
                SpisokHumans.Add(new Human());
                Console.WriteLine("Введите Имя");
                SpisokHumans[i].FirstNameSet(Console.ReadLine());
                Console.WriteLine("Введите фамилию");
                SpisokHumans[i].SecondNameSet(Console.ReadLine());
                Console.WriteLine("Введите отчество");
                SpisokHumans[i].LastNameSet(Console.ReadLine());
                Console.WriteLine("Введите возраст");
                SpisokHumans[i].AgeSet(Console.ReadLine());
                Console.WriteLine("Введите номер телефона");
                SpisokHumans[i].PhoneSet(Console.ReadLine());
                Human.count++;
                Console.WriteLine("Проверьте введенные данные:");
                Console.WriteLine("Имя = " + SpisokHumans[i].FirstNameGet());
                Console.WriteLine("Фамилия = " + SpisokHumans[i].SecondNameGet());
                Console.WriteLine("Отчество = " + SpisokHumans[i].LastNameGet());
                Console.WriteLine("Возраст = " + SpisokHumans[i].AgeGet());
                Console.WriteLine("Телефон = " + SpisokHumans[i].PhoneGet());
                Console.WriteLine("Добавлен человек № " + Human.count);
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadLine();

            }
            Console.WriteLine("Всего добавлено {0} людей", Human.count);
            Console.ReadLine();

            //Распределяем всех ФизЛиц по 3м категориям (классам)
            for (int i = 0; i < Human.count; i++) //Нельзя расскидать по проф категориям людей больше, чем количество добавленных в список человек (Физ Лиц).
            {
                Console.Write("Начнем переводить людей в рабочие категории. Введите цифрой от 1 до 3 категорию:");
                if(int.TryParse(Console.ReadLine(), out int typeZP) && typeZP >= 1 && typeZP <= 3)
                {
                    switch (typeZP)
                    {
                        case 1:
                            {
                                var SpisokWorkersZP1 = new List<WorkerZP1>();
                                SpisokWorkersZP1.Add(new WorkerZP1());
                                int iZP1 = 0;      //Счетчик людей по рабочим классам              
                                SpisokWorkersZP1[iZP1].FirstNameSet(SpisokHumans[i].FirstNameGet());
                                SpisokWorkersZP1[iZP1].SecondNameSet(SpisokHumans[i].SecondNameGet());
                                SpisokWorkersZP1[iZP1].LastNameSet(SpisokHumans[i].LastNameGet());
                                SpisokWorkersZP1[iZP1].AgeSet(Convert.ToString(SpisokHumans[i].AgeGet()));     //Аргумент должен подаваться string, так как изначально вводится с консоли
                                SpisokWorkersZP1[iZP1].PhoneSet(Convert.ToString(SpisokHumans[i].AgeGet())); //Аргумент должен подаваться string, так как изначально вводится с консоли
                                Console.WriteLine("Введите профессию");
                                SpisokWorkersZP1[iZP1].ProfessionSet(Console.ReadLine());
                                Console.WriteLine("Введите Стаж");
                                SpisokWorkersZP1[iZP1].ExperienceSet(Console.ReadLine());
                                Console.WriteLine("Введите Стоимость часа");
                                SpisokWorkersZP1[iZP1].CostHourSet(Console.ReadLine());
                                Console.WriteLine("Введите Количество часов");
                                SpisokWorkersZP1[iZP1].NumberHoursSet(Console.ReadLine());
                                SpisokWorkersZP1[iZP1].RaschetSet();
                                Console.WriteLine("{0} {1} {2} {3} заработал {4} рублей", SpisokWorkersZP1[iZP1].ProfessionGet(), SpisokWorkersZP1[iZP1].SecondNameGet(), SpisokWorkersZP1[iZP1].FirstNameGet(), SpisokWorkersZP1[iZP1].LastNameGet(), SpisokWorkersZP1[iZP1].RaschetGet());
                                iZP1++;
                            }
                            break;

                        case 2:
                            {
                                var SpisokWorkersZP2 = new List<WorkerZP2>();
                                SpisokWorkersZP2.Add(new WorkerZP2());
                                int iZP2 = 0;
                                SpisokWorkersZP2[iZP2].FirstNameSet(SpisokHumans[i].FirstNameGet());
                                SpisokWorkersZP2[iZP2].SecondNameSet(SpisokHumans[i].SecondNameGet());
                                SpisokWorkersZP2[iZP2].LastNameSet(SpisokHumans[i].LastNameGet());
                                SpisokWorkersZP2[iZP2].AgeSet(Convert.ToString(SpisokHumans[i].AgeGet()));     //Аргумент должен подаваться string, так как изначально вводится с консоли
                                SpisokWorkersZP2[iZP2].PhoneSet(Convert.ToString(SpisokHumans[i].AgeGet())); //Аргумент должен подаваться string, так как изначально вводится с консоли
                                Console.WriteLine("Введите профессию");
                                SpisokWorkersZP2[iZP2].ProfessionSet(Console.ReadLine());
                                Console.WriteLine("Введите Стаж");
                                SpisokWorkersZP2[iZP2].ExperienceSet(Console.ReadLine());
                                Console.WriteLine("Введите месячный оклад");
                                SpisokWorkersZP2[iZP2].OkladSet(Console.ReadLine());
                                Console.WriteLine("Введите количество положенных рабочих дней");
                                SpisokWorkersZP2[iZP2].NumberDaysSet(Console.ReadLine());
                                Console.WriteLine("Введите количество фактических рабочих дней");
                                SpisokWorkersZP2[iZP2].NumberFactDaysSet(Console.ReadLine());
                                SpisokWorkersZP2[iZP2].RaschetSet();
                                Console.WriteLine("{0} {1} {2} {3} заработал {4} рублей", SpisokWorkersZP2[iZP2].ProfessionGet(), SpisokWorkersZP2[iZP2].SecondNameGet(), SpisokWorkersZP2[iZP2].FirstNameGet(), SpisokWorkersZP2[iZP2].LastNameGet(), SpisokWorkersZP2[iZP2].RaschetGet());
                                iZP2++;
                            }

                            break;

                        case 3:
                            {
                                var SpisokWorkersZP3 = new List<WorkerZP3>();
                                SpisokWorkersZP3.Add(new WorkerZP3());
                                int iZP3 = 0;
                                SpisokWorkersZP3[iZP3].FirstNameSet(SpisokHumans[i].FirstNameGet());
                                SpisokWorkersZP3[iZP3].SecondNameSet(SpisokHumans[i].SecondNameGet());
                                SpisokWorkersZP3[iZP3].LastNameSet(SpisokHumans[i].LastNameGet());
                                SpisokWorkersZP3[iZP3].AgeSet(Convert.ToString(SpisokHumans[i].AgeGet()));     //Аргумент должен подаваться string, так как изначально вводится с консоли
                                SpisokWorkersZP3[iZP3].PhoneSet(Convert.ToString(SpisokHumans[i].AgeGet())); //Аргумент должен подаваться string, так как изначально вводится с консоли
                                Console.WriteLine("Введите профессию");
                                SpisokWorkersZP3[iZP3].ProfessionSet(Console.ReadLine());
                                Console.WriteLine("Введите Стаж");
                                SpisokWorkersZP3[iZP3].ExperienceSet(Console.ReadLine());
                                Console.WriteLine("Введите Ставку");
                                SpisokWorkersZP3[iZP3].StavkaSet(Console.ReadLine());
                                Console.WriteLine("Введите Количество часов");
                                SpisokWorkersZP3[iZP3].NumberDaysSet(Console.ReadLine());
                                SpisokWorkersZP3[iZP3].RaschetSet();
                                Console.WriteLine("{0} {1} {2} {3} заработал {4} рублей", SpisokWorkersZP3[iZP3].ProfessionGet(), SpisokWorkersZP3[iZP3].SecondNameGet(), SpisokWorkersZP3[iZP3].FirstNameGet(), SpisokWorkersZP3[iZP3].LastNameGet(), SpisokWorkersZP3[iZP3].RaschetGet());
                                iZP3++;
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Вы неправильно сделали выбор класса работника");
                }
            }
          

        }
    }
}
