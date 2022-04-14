using System;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine(@"Какую задачу запустить, укажите номер: 
            1.  Дано число n. Получите число, записанное в обратном порядке.
            2.  Дана монотонная последовательность, в которой каждое натуральное число n встречается ровно n раз: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ... Дано число m. Выведите первые m членов этой последовательности.
            3.  Дано натульное число n > 1. Вывести все простые множители данного числа.
            4.  Даны два числа a, b. Сложите их, используя только операции инкремента и декремента.
            5.  Дана последовательность натуральных чисел. Определите значение второго по величине элемента в этой последовательности.
            6.  Дан массив, состоящий из случайных целых чисел. Дано число M. Выведите случайное подмножество массива, сумма элементов в котором не превосходит M.
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

                int [] generationRandomList(){
                    //генерируем последовательность
                    Random rnd = new Random();
                    int [] mass = new int[rnd.Next(10,40)];
                    for(int i=0; i< mass.Length; i++){
                        mass[i] = rnd.Next(100);
                    }
                    return mass;
                }
           



             void task1(){
                int recRever(int number){
                    if(number<10){
                        return number;
                    }else{
                        return Convert.ToInt32($"{number%10}" + $"{recRever(number/10)}");
                    }
                }

                 Console.Write("Ведите первое число: ");
                int number1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("");
                Console.WriteLine($"Число в обратном порядке: {recRever(number1)}");
                

            };

             void task2(){
                 string generationList(int len, int step=1, int number=1){
                     if(len == 0){
                         return $"{number}";
                     }else if(step == 0){
                         number++;
                         step = number-1;
                         len--;
                         return $"{number}" + " ,"+generationList(len, step, number);
                     }else{
                         step--;
                         len--;
                         return $"{number}" + " ,"+ generationList(len, step, number);
                     }
                 }

                Console.Write("Ведите число: ");
                int len = Math.Abs(Convert.ToInt32(Console.ReadLine()));


                Console.Write($"{generationList(len)}");

                
            };

             void task3(){

                 string findDel(int number){
                     for(int i =2; i <10; i++){
                         if(i == number){
                             return $"{number}";
                        }else if(number == i){
                             return $"{i}";
                         }else if(number%i == 0){
                             return $"{i}, " + findDel(number/i);
                         }
                     }
                     return $"{number}";
                 }

                Console.Write("Ведите число: ");
                Console.WriteLine("");
                int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine(findDel(number));


                  

            };

             void task4(){
                 int sumRec(int a, int b){
                     if(b == 0){
                         return a;
                     }else{
                         a++;
                         b--;
                        return sumRec(a,b);
                     }
                 }

                Console.Write("Ведите первое число: ");
                int number1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("");
                Console.Write("Ведите второе число: ");
                int number2 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("");
                Console.WriteLine($"Сумма чисел равна {sumRec(number1,number2)}");
               

            };
            
             void task5(){
                 //получеам последовательность
                 int [] mass = generationRandomList();
                 Console.WriteLine("Последовательность:");
                 for(int i=0; i< mass.Length; i++){
                    Console.Write($" {mass[i]},");
                }
    
                Console.WriteLine("");
                ///получаем список уникальных значений
                List<int> listUnic= new List<int>();
                for(int i= 0 ; i<mass.Length;i++){
                    if(listUnic.IndexOf(mass[i])>=0){
                        continue;
                    }
                    listUnic.Add(mass[i]);
                }
                Console.WriteLine("Уникальная последовательность:");
                for(int i=0; i< listUnic.Count; i++){
                    Console.Write($" {listUnic[i]},");
                }
                Console.WriteLine("");
                ////Сортируем по убыванию
                for(int i= 0 ; i<listUnic.Count;i++){
                    for(int j= 1 ; j<listUnic.Count;j++){
                        if(listUnic[j]>listUnic[j-1]){
                            (listUnic[j],listUnic[j-1]) = (listUnic[j-1],listUnic[j]);
                        }
                    }
                }
                Console.WriteLine("Отсортированная уникальная последовательность:");
                for(int i=0; i< listUnic.Count; i++){
                    Console.Write($" {listUnic[i]},");
                }
                Console.WriteLine("");
                //Выводим 2 элемент
                Console.WriteLine($"Второй по возрастанию элемент {listUnic[1]}");

            };

             void task6(){
                 //получеам последовательность
                 int [] mass = generationRandomList();
                 Console.WriteLine("Последовательность:");
                 for(int i=0; i< mass.Length; i++){
                    Console.Write($" {mass[i]},");
                }
                Console.WriteLine("");



                 string findSum(int number,int[] mass){
                     Random rnd = new Random();

                     for(int i = 0 ; i < mass.Length; i++){
                         int randomNumber = mass[rnd.Next(mass.Length)];
                         if(randomNumber==0){
                             continue;
                         }

                         if(number> randomNumber){
                             Array.Clear(mass,Array.IndexOf(mass,randomNumber),1);
                             return $" {randomNumber}," + findSum(number-randomNumber,mass);
                         }else if(number == randomNumber){
                             return $" {randomNumber}";
                         }
                     }
                     return "";
                 }
                Console.WriteLine("");
                Console.Write("Ведите число: ");
                Console.WriteLine("");
                int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine(findSum(number,mass));

               
            };

           
               
            
           }



               
            
        

        
    }
}
