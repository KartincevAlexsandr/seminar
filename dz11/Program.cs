using System;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine(@"Какую задачу запустить, укажите номер: 
            1.  Задача 1. На вход подуются два числа n и m, такие, что n<m. Заполните массив случайными числами из промежутка [n, m].
            2.  Задача 2. Двумерный массив заполнен случайными натуральными числами от 1 до 10. Найдите количество элементов, значение которых больше 5, и их сумму.
            3.  Задача 3. Напишите рекурсивный метод, который принимает номер года и определяет, является ли он високосным или нет.
            4.  доп Задача 1
            5.  доп Задача 2
            6.  доп Задача 3
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
                
                default:
                    Console.WriteLine("Вы ввели неправильное число");
                    break;
            }
                ///Герерация масива
             int[,] GenerateRandomArray(){
                    Random rnd = new Random();  
                    int lenArray1 = rnd.Next(4,40); 
                    int lenArray2 = rnd.Next(4,40); 
                    int[,] newArray = new int[lenArray1,lenArray2];
                    for(int i = 0 ; i < lenArray1; i++){
                        for(int j = 0 ; j < lenArray2; j++){
                            newArray[i,j] = rnd.Next(0,11);

                        }
                        
                }
                return newArray;
                };
              
            ///печать двухмерного массива
            void printMatrch(int[,] matrch){
                for(int i = 0; i < matrch.GetLength(0); i++){
                    for(int j = 0; j < matrch.GetLength(1); j ++){
                        Console.Write(" {0,3}", matrch[i, j]);
                    }
                    Console.WriteLine("");
                }
            }


             void task1(){
                 Random rnd = new Random();
                Console.Write("Ведите число n: ");
                int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("");
                Console.Write("Ведите число m: ");
                int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("");
                if(n>m){
                    Console.WriteLine("Число n не может быть больше числа m");
                    return;
                }
                int [] mass = new int [rnd.Next(4,10)]; 
                for(int i = 0; i< mass.Length;i++){
                    mass[i] = rnd.Next(n,m);
                }
                Console.WriteLine("Последовательность:");
                for(int i = 0; i< mass.Length;i++){
                    Console.Write($"{mass[i]},");
                }

            

            };

             void task2(){
               
                int[,] newArray = GenerateRandomArray();
                Console.WriteLine("Последовательность:");
                printMatrch(newArray);
                 Dictionary<int,int> countNumber = new Dictionary<int,int>();

                for(int i = 0 ; i < newArray.GetLength(0); i++){
                    for(int j = 0 ; j < newArray.GetLength(1); j++){
                        if(newArray[i,j]<=5){
                            continue;
                        }
                        if(countNumber.ContainsKey(newArray[i,j])){
                            countNumber[newArray[i,j]]++;
                        }else{
                            countNumber[newArray[i,j]] =1;
                        }

                    }
                }
                foreach (var item in countNumber)
                {
                    //Console.WriteLine($"Чило {item[0]} встречается ");
                    Console.WriteLine($"Чило {item.Key} встречается {item.Value} раз и их сумма {item.Key*item.Value}");
                    
                }

                
            };

             void task3(){
                 string recYerV(int year, int step = 1){
                     if(year%100==0 && year%400==0){
                         return "високосный";
                     }else if(step>25){
                         return "не високосный";
                     }else if(year%100==4*step){
                         return "високосный";
                     }else{
                         step++;
                         return recYerV(year, step);
                     }
                 }

                Console.Write("Ведите год: ");
                int year = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("");
                Console.WriteLine($"Год {year} являентся {recYerV(year)}");


                  

            };

             void task4(){
               
               

            };
            
             void task5(){
                

            };

             void task6(){
               

               
            };

           
               
            
           }



               
            
        

        
    }
}
