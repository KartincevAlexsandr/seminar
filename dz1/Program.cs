using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Какую работу запустить: 2,4,6,8");
            int num = Convert.ToInt32(Console.ReadLine()) ;
            switch (num)
            {
                case 2:
                    task2();
                    break;
                case 4:
                    task4();
                    break;
                case 6:
                    task6();
                    break;
                case 8:
                    task8();
                    break;
                
                default:
                    Console.WriteLine("Вы ввели неправильное число");
                    break;
            }

            void task2(){
                Console.WriteLine("Запущена задача 2");
                Console.WriteLine("Ведите число 1");
                int number_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число 2");
                int number_2 = Convert.ToInt32(Console.ReadLine());
                if(number_1 > number_2){
                    Console.WriteLine($"Число 1 - '{number_1}', больше чем число 2 '{number_2}'");
                }else if(number_1< number_2){
                    Console.WriteLine($"Число 2 - '{number_2}', больше чем число 1 '{number_1}'");
                }else{
                    Console.WriteLine($"Числа 1 и 2 равны");
                }

            };

            void task4(){
                Console.WriteLine("Запущена задача 4");
               
                Console.WriteLine("Ведите число 1");
                int number_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число 2");
                int number_2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число 3");
                int number_3 = Convert.ToInt32(Console.ReadLine());

                if(number_1 == number_2 && number_1 == number_3){
                    Console.WriteLine($"Числа равны");
                }else if(number_1 > number_2 && number_1 > number_3){
                    Console.WriteLine($"Число 1 - '{number_1}' самое большое");
                }else if(number_2 > number_1 && number_2 > number_3){
                    Console.WriteLine($"Число 2 - '{number_2}' самое большое");
                }else{
                    Console.WriteLine($"Число 3 - '{number_3}' самое большое");
                }
            };

            void task6(){
                Console.WriteLine("Запущена задача 6");
                Console.WriteLine("Ведите число");
                int number = Convert.ToInt32(Console.ReadLine());
                if(number%2 == 0){
                    Console.WriteLine("Число четное");
                }else{
                    Console.WriteLine("Число не четное");
                }


            };

            void task8(){
                Console.WriteLine("Запущена задача 8");
            };
        }

        
    }
}
