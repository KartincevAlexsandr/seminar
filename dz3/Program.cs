using System;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine(@"Какую задачу запустить, укажите номер: 
            1. Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
            2. Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            3. Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            4. На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти. Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.
            5. Даны 4 точки a, b, c, d. Пересекаются ли вектора AB и CD?
            6. Дан массив средних температур (массив заполняется случайно) за последние 10 лет. На ввод подают номер месяца и год начали и конца.
Определить самые высокие и низкие температуры для лета, осени, зимы и весны в заданном промежутке. Если таких температур нет, сообщить, что определить не удалось.
            7. На вход подаётся число n > 4, указывающее длину пароля. Создайте метод, генерирующий пароль заданной длины. В пароле обязательно использовать цифру, букву и специальный знак.");
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
                Console.WriteLine("Ведите число");
                string number = Console.ReadLine();

                for(int i=0, j = number.Length-1; i<j; i++,j--){
                    if(number[i] != number[j]){
                        Console.WriteLine("Число не полиморф");
                        return ;
                    }
                }
                Console.WriteLine("Число полиморф");

            };

            void task2(){
                Console.WriteLine("Ведите через точку . кординаты первой точки x.y.z");
                string dot1 = Console.ReadLine();
                Console.WriteLine("Ведите через точку . кординаты второй точки x.y.z");
                string dot2 = Console.ReadLine();

                double [] dot1xyz = Array.ConvertAll(dot1.Split('.'), double.Parse);
                double [] dot2xyz = Array.ConvertAll(dot2.Split('.'), double.Parse);
                double line = Math.Sqrt( Math.Pow((dot1xyz[0]-dot2xyz[0]),2) + Math.Pow((dot1xyz[1]-dot2xyz[1]),2) + Math.Pow((dot1xyz[2]-dot2xyz[2]),2));
                Console.WriteLine($"Расстояние между точками {line}");
             
            };

            void task3(){
                Console.WriteLine("Ведите число");
                int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                for(int i = 1; i<= number; i++){
                    Console.Write($" {Math.Pow(i,3)}," );
                }

            };

            void task4(){
                // //Решаем жадным алгоритмом
                //     double MeasuringLine(int[] a,int[]b){
                //         return Math.Sqrt( Math.Pow((a[0]-b[0]),2) + Math.Pow((a[1]-b[1]),2) );
                //     }
                //     Random rand = new Random();
                //     Console.WriteLine("Укажите четверть. 1-4");
                //     int quarter = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                //     Console.WriteLine("Укажите кол-во точек");
                //     int countDot = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                //     int x,y =1 ;
                //     switch (quarter){
                //         case 1:
                //             x = 1;
                //             y = 1;
                //             break;
                //         case 2:
                //             x = -1;
                //             y = 1;
                //             break;
                //         case 3:
                //             x = -1;
                //             y = -1;
                //             break;
                //         case 4:
                //             x = 1;
                //             y = -1;
                //             break;
                //         default:
                //             Console.WriteLine("Неправильная четверть");
                //             break;
                //     }
                    
                //     ArrayList [] dots = {};
                //     //Генерируем точки
                //     for(int i =0;i<=countDot;i++){
                //         dots.Add(new int[x*rand.Next(1,128), y*rand.Next(1,128)]);
                //     }
                //     int [] points = {1}; // Порядок точек
                //     int [] lastPoint = dots[0]; // Последняя точка
                //     int [] tempPoint = dots[1]; //Сюда будем записывать точку к котор крайчайший маршрут
                //     double tempLen = MeasuringLine(lastPoint,tempPoint)  ; //Временный маршрут

                //     for(int i =1;i<=dots.Length;i++){
                //         int ourPoint;
                //         for(int j =1;j<=dots.Length;j++){
                            
                //         }

                //     }

            }
            
            void task5(){


                }

               
            
            void task6(){
               
                }

               
            
            void task7(){
              
                }

               
            
        }

        
    }
}
