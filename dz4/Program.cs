using System;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine(@"Какую задачу запустить, укажите номер: 
            1. Задача 25: Напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
            2. Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            3. Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
            4. доп ДЗ_1 На вход подаётся натуральное десятичное число. Проверьте, является ли оно палиндромом в двоичной записи.
            5. доп ДЗ_2 Напишите метод, который заполняет массив случайным количеством (от 1 до 100) нулей и единиц. Размер массива должен совпадать с квадратом количества единиц в нём.
            6. доп ДЗ_3 Массив на 100 элементов задаётся случайными числами от 1 до 99. Определите самый часто встречающийся элемент в массиве. Если таких элементов несколько, вывести их все.");
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
                Console.WriteLine("Ведите число");
                int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                int numberInDegree = number;
                Console.WriteLine("Ведите степень числа");
                int numberDegree = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                for(int i =1 ; i <  numberDegree; i++){
                    numberInDegree = numberInDegree * number;
                }

                Console.WriteLine($"Число {number} в степени {numberDegree} равно {numberInDegree}");

            };

            void task2(){
                Console.WriteLine("Ведите число");
                int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                int sum = 0;
                while (number > 0){
                    sum += number % 10;
                    number = number / 10;
                }
                    
                Console.WriteLine($"Сумма всех чисел равна {sum}");
            };

            async void task3(){
                Random rnd = new Random();

                int [] numberList = new int[8];
                for(int i = 0 ; i < numberList.Length ; i++){
                    numberList[i] =  rnd.Next(-50,50);
                }
                for(int i = 0; i < numberList.Length; i++){
                    for(int  j = 1; j < numberList.Length; j++){
                        if(Math.Abs(numberList[j])<Math.Abs(numberList[j-1])){
                            numberList[j] = numberList[j-1] + numberList[j]; 
                            numberList[j-1] = numberList[j] - numberList[j-1];
                            numberList[j] = numberList[j] - numberList[j-1];
                        }
                    }
                }



                foreach (int item in numberList)
                {
                    Console.WriteLine(item);
                }
                    
            };

            async void task4(){
                Console.WriteLine("Ведите число");
                int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                string biteNumber = ""; 
                while(number>0){
                    biteNumber = $"{number%2}" + biteNumber;
                    number = number/2;
                }
            
                bool isPalidrom = true;
                for(int i = 0 ; i < biteNumber.Length/2; i++ ){
                    if(biteNumber[i] != biteNumber[biteNumber.Length-i-1]){
                        isPalidrom = false;
                        break;
                    }
                }
                if(isPalidrom){
                    Console.WriteLine("Полидром");
                }else{
                    Console.WriteLine("Не полидром");
                }

            }
            
            async void task5(){
                Random rnd = new Random();
                int countOne = rnd.Next(1,10);
                int [] mass = new int[countOne*countOne];
                for(int i = 0; i < mass.Length; i++){
                    if(countOne > 0){
                        mass[i] = 1;
                        countOne--;
                    }else{
                        mass[i] = 0;
                    }
                }
                foreach (int item in mass)
                {
                    Console.WriteLine(item);
                }


                }

               
            
            void task6(){
                Random rnd = new Random();
                int [] mass = new int[100];
                Dictionary<int,int> countPovt = new Dictionary<int, int>();
                for(int i = 0; i < mass.Length; i++){
                    mass[i] = rnd.Next(1,99);
                    if(countPovt.ContainsKey(mass[i])){
                        countPovt[mass[i]] ++;
                    }else{
                        countPovt[mass[i]] = 1;
                    }
                }
                int maxKey = 0;
                foreach(var item in countPovt){
                    if(maxKey==0){
                        maxKey = item.Key;
                    }else{
                        if(countPovt[maxKey]< item.Value ){
                            maxKey = item.Key;
                        }
                    }
                }
                Console.WriteLine($" Элемент {maxKey} встречается {countPovt[maxKey]} раз");


                }

               
            
          

               
            
        }

        
    }
}
