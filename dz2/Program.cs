using System;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine(@"Какую задачу запустить, укажите номер: 
            1. Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе выводит перевёрнутое число.
            2. Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            3. Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Доп задачи 
            4. Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.

            5. Задача 2. На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 февраля 2022 года.

            6. Задача 3. Иван в январе года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев.

            7. Задача 4. Дано натуральное число, в котором все цифры различны. Определить, какая цифра расположена в нем левее: максимальная или минимальная.
");
            int num = Convert.ToInt32(Console.ReadLine()) ;
            switch (num)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                case 5:
                    task5();
                    break;
                case 6:
                    task6();
                    break;
                case 7:
                    task7();
                    break;
                
                default:
                    Console.WriteLine("Вы ввели неправильное число");
                    break;
            }

            void task1(){
                // В пайтоне в 1 строку =) print(str(input("Введите число"))[::-1])  
               Console.WriteLine("Ведите число");
            //    Вариант1
            //    string stringNumer = Console.ReadLine();
            //    char [] number = stringNumer.ToCharArray();
            //    Array.Reverse(number);
            //    stringNumer = new string(number);
            //    Console.WriteLine(stringNumer);

            //    Вариант2
            string stringNumer = Console.ReadLine();
            for(var i = stringNumer.Length - 1 ; i >= 0; i--){
                Console.Write(stringNumer[i]);
            }

            };

            void task2(){
               Console.WriteLine("Ведите число");
               int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
               if(number>99){
                   string numberString = number.ToString();
                   Console.WriteLine($"3- число = {numberString[2]}");
               }else{
                    Console.WriteLine("3-го числа нет");
               }
            };

            void task3(){
                Console.WriteLine("Укажите день недели, цифрой от 1 до 7, где 1 - это понедельник, а 7 -Воскресенье");
               int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
               if(number == 6 || number == 7){               
                   Console.WriteLine("Ура, сегодня выходной");
               }else if(number >= 1 && number < 6){
                   Console.WriteLine("Эххх, сегодня на работу");
               }else{
                   Console.WriteLine("День недели указан неправильно");
               }

            };

            void task4(){

                Console.WriteLine("Ведите число длину стороны a");
                int side_a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число длину стороны b");
                int side_b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число длину стороны c");
                int side_c = Convert.ToInt32(Console.ReadLine());
                if(side_a == side_b || side_b == side_c || side_a == side_c){
                    Console.WriteLine("Треугодбник равнобедренный");
                }else{
                    Console.WriteLine("Треугодбник не равнобедренный");
                }
                }

               
            
            void task5(){
                //вариант1
                Console.WriteLine("вариант1");
                string rePattern = @"\d{2}\.\d{2}\.\d{4}";

                Console.WriteLine("Ведите дату рождения в формате дд.мм.гггг");
                string birthDate = Console.ReadLine();
                string [] matches = Regex.Matches(birthDate, rePattern, RegexOptions.IgnoreCase)
                                                .Cast<Match>()
                                                .Select(m => m.Value)
                                                .ToArray();
                if(matches.Length == 1){
                    // Проверяем на дату 01.02.2022 при том если др выпадает на 1 февраля, то считаем его как исполнившееся
                    string [] dates = matches[0].Split('.');
                   
                    if(Convert.ToInt32(dates[1]) < 2){
                        Console.WriteLine($"Возраст {2022-Convert.ToInt32(dates[2])}");
                    }else if(Convert.ToInt32(dates[1]) > 2){
                        Console.WriteLine($"Возраст {2022-Convert.ToInt32(dates[2])-1}");
                    }
                }else{
                    Console.WriteLine("Вы ввели дату в неправильном формате");
                }

                //вариант2 
                // Console.WriteLine("вариант2");
                // DateTime dateNow = new DateTime(2022,2,1);

                // Console.WriteLine("Ведите дату рождения в формате дд.мм.гггг");
                // string birthDate = Console.ReadLine();
                // DateTime birthDate2 = DateTime.ParseExact(birthDate, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                // TimeSpan timeDelta= dateNow.Subtract(birthDate2) ;
                // //Console.WriteLine(timeDelta.);

                // Console.WriteLine(birthDate2.ToString());

                }

               
            
            void task6(){
                    double procRecFunc(int mouth, double summ){
                        if(mouth>1){
                            summ += summ * 0.015;
                            mouth--;
                            return procRecFunc(mouth,summ);
                        }else{
                            summ += summ * 0.015;
                            return summ;
                        }
                    }
                    Console.WriteLine("Ведите Кол-во месяцев");
                    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                    int capital = Convert.ToInt32(procRecFunc(number, 1000.0));
                    Console.WriteLine($"Сумма из 1000р, через {number} месяцев будет составлять {capital}");

                }

               
            
            void task7(){
              
                }

               
            
        }

        
    }
}
