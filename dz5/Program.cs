using System;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine(@"Какую задачу запустить, укажите номер: 
            1.  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
            2. Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
            3. Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            4. Дополнительне задание 1
            5. Дополнительне задание 2
            6. Дополнительне задание 3");
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

            async void task1(){
                Random rnd = new Random();
                int [] mass = new int[rnd.Next(1,99)];
                int countChet = 0;
                for(int i=0; i< mass.Length; i++){
                    mass[i] = rnd.Next(100,999);
                    if(mass[i]%2 == 0){
                        countChet++;
                    }
                }

                Console.WriteLine($"В массиве {countChet} четных чисел");
            };

            void task2(){
                Random rnd = new Random();
                int [] mass = new int[rnd.Next(1000)];
                int sum = 0;
                for(int i=0; i< mass.Length; i++){
                    mass[i] = rnd.Next(1000);
                    if(i%2 == 1){
                        
                        sum = sum + mass[i];
                    }
                }

                Console.WriteLine($"В массиве {sum} сумма всех чисел чтоящих на нечетных позициях");
            };

            async void task3(){
                Random rnd = new Random();
                double [] mass = new double[rnd.Next(100)];
                double max = .0;
                double min = 1.0;
                for(int i=0; i< mass.Length; i++){
                    mass[i] = rnd.NextDouble();
                    if(mass[i] > max){
                        max = mass[i];
                    }else if(mass[i] < min){
                        min = mass[i];
                    }
                }
                Console.WriteLine($"Самое большое число {max}, самое маленькое {min}, разница {max-min}");
                    
            };

            async void task4(){
                Random rnd = new Random();
                int [] mass = new int[rnd.Next(15)];
                int sum = 0;
                for(int i=0; i< mass.Length; i++){
                    mass[i] = rnd.Next(10);
                }
                Console.WriteLine("Ведите число");
                int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                if(String.Join("",mass).Contains($"{number}")){
                    Console.WriteLine("Да");
                }else{
                    Console.WriteLine("Нет");
                }
                
                

            }
            
            async void task5(){
                Console.WriteLine("Ведите число 1");
                string number1 = Console.ReadLine();
                Console.WriteLine("Ведите число 2");
                string number2 = Console.ReadLine();
                List<int> listProiz= new List<int>();

               


                for(int i = 0 ; i< number1.Length; i++){
                    for(int j =0; j < number2.Length; j++){
                        char n1 = number2[j];
                        listProiz.Add(Math.Abs(Convert.ToInt32( ""+number1[i])) * Math.Abs(Convert.ToInt32(""+number2[j])));
                    }
                }

                foreach (int item in listProiz)
                {
                    Console.WriteLine(item);
                }
                

                }

               
            
            async void task6(){
                 int prozv(int iteger){
                    string number = $"{iteger}";
                    int prozvedenie = 1;
                    for(int i = 0; i< number.Length;i++){
                        prozvedenie = prozvedenie * Convert.ToInt32( ""+number[i]);
                    }
                    return prozvedenie;

                }
                 int summ3(int iteger){
                    string number = $"{iteger}";
                    int summNumber = 0;
                    for(int i = 0; i< number.Length;i++){
                        summNumber = summNumber + Convert.ToInt32( ""+number[i]);
                    }
                    return summNumber*3;

                }
               List<int> listInt= new List<int>();

               for(int i =0 ; i < 1000000; i++){
                   if(prozv(i) > summ3(i)){
                       listInt.Add(i);
                   }
                  
               }
               Console.WriteLine(listInt.Count);


                }

               
            
          

               
            
        }

        
    }
}
