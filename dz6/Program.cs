using System;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine(@"Какую задачу запустить, укажите номер: 
            1.  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
            2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
                    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
            3. Написать перевод десятичного числа в двоичное, используя рекурсию.
            4. На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”. Используя рекурсию, подсчитайте, сколько в поговорке гласных букв.
            5. Дано число N. Используя рекурсию, определите, что оно является степенью числа 3.
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
                
                
                
                default:
                    Console.WriteLine("Вы ввели неправильное число");
                    break;
            }

            async void task1(){
               Console.WriteLine("Ведите числа, через запятую");
                string number = Console.ReadLine();
                string[] numberList = number.Split(',');
                int counPolNumber= 0;
                foreach (var item in numberList)
                {
                    if(Convert.ToInt32(item) >0 ){
                        counPolNumber ++;
                    }
                }
                Console.WriteLine($" Вы ввели {counPolNumber} чисел больше 0");
            };

            void task2(){
                Console.WriteLine("Ведите число b1");
                int numberB1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ведите число k1");
                int numberK1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ведите число b2");
                int numberB2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ведите число k2");
                int numberK2 = Convert.ToInt32(Console.ReadLine());
                double peremen1 = numberB2 - numberB1;
                double peremen2 = numberK1-numberK2;
                double y = peremen1/peremen2;
                Console.WriteLine($"Точка пересечения будет ({y},{y})");
                
            };

            async void task3(){
                string ConvectDecimal(int num){
                    if(num > 2){
                        return ConvectDecimal(num/2) + $"{num % 2}" ;
                    }
                    return $"{num % 2}";
                    
                }
                Console.WriteLine("Ведите число");
                int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine(ConvectDecimal(number));
            };

            async void task4(){
                char[] glasAbc = {'а', 'у', 'о', 'ы', 'и', 'э', 'я', 'ю', 'ё', 'е'};


                int countGlasAbc(string stroca){
                    int count = 0;
                    if(Array.IndexOf(glasAbc,stroca[0])>=0){
                        count++;
                    }

                    if(stroca.Length>1){
                        return count + countGlasAbc(stroca.Remove(0,1));
                    }
                    return count;
                }
               
                
                string predlogenie = "без труда не выловишь и рыбку из пруда";
                Console.WriteLine(countGlasAbc(predlogenie));

            }
            
            async void task5(){
                bool recurs(int num){
                    if (num == 3){
                        return true;
                    }
                    else if(num< 3 ){
                        return false;
                    }else if(num%3>0){
                        return false;
                    }
                    return recurs(num/3);

                }




                Console.WriteLine("Ведите число");
                int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                if(recurs(number)){
                    Console.WriteLine("Число является степенью числа 3");
                }else{
                    Console.WriteLine("Число не является степенью числа 3");
                }

                }

               
            
           }



               
            
        

        
    }
}
