using System;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine(@"Какую задачу запустить, укажите номер: 
            1. Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
            2. Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
            3. Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
            4. Задача 1. Даны две матрицы, количество строк и столбцов которых может быть 3 или 4, заполнены числами от -9 до 9. Выполните умножение матриц.
            5. Задача 2. Двумерный массив размером 3х4 заполнен числами от 100 до 9999. Найдите в этом массиве и сохраните в одномерный массив все числа, сумма цифр которых больше их произведения. Выведите оба массива.
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

             int[,] GenerateRandomArray(){
                Random rnd = new Random();  
                int lenArray1 = rnd.Next(4,40); 
                int lenArray2 = rnd.Next(4,40); 
                int[,] newArray = new int[lenArray1,lenArray2];
                for(int i = 0 ; i < lenArray1; i++){
                    for(int j = 0 ; j < lenArray2; j++){
                        newArray[i,j] = rnd.Next(0,999);

                    }
                }
                return newArray;
            };

            async void task1(){
                Random rnd = new Random();
                Console.WriteLine("укажите размер массива через запятую");
                string number = Console.ReadLine();
                int lenArray1 = Convert.ToInt32(number.Split(',')[0]);
                int lenArray2 = Convert.ToInt32(number.Split(',')[1]);
                int[,] newArray = new int[lenArray1,lenArray2];
                for(int i = 0 ; i < lenArray1; i++){
                    for(int j = 0 ; j < lenArray2; j++){
                        newArray[i,j] = rnd.Next(0,999);

                    }
                }
                

                Console.WriteLine(newArray);
              
            };

            void task2(){
                int[,] newArray= GenerateRandomArray(); 

                Console.WriteLine("укажите позицию через запятую");
                string position = Console.ReadLine();
                int position1 = Convert.ToInt32(position.Split(',')[0]);
                int position2 = Convert.ToInt32(position.Split(',')[0]);

                if(position1<= newArray.GetLength(0)&& position2<= newArray.GetLength(1)){
                    Console.WriteLine(newArray[position1,position2]);
                }else{
                    Console.WriteLine("Такой позиции нет");
                }
                
           
            };

            async void task3(){
                int[,] newArray= GenerateRandomArray(); 
                int[] arithmeticMean = new int [ newArray.GetLength(1) ];

                for(int i = 0 ; i < newArray.GetLength(1); i++){
                    int mean = 0;
                    for(int j = 0 ; j < newArray.GetLength(0); j++){
                       mean += newArray[j,i];
                    }
                    arithmeticMean[i] = mean/newArray.GetLength(1);
                }
                    
            };

            async void task4(){
                
                Random rnd = new Random();  
               
                int[,] newArray1 = new int[3,4];
                for(int i = 0 ; i < 3; i++){
                    for(int j = 0 ; j < 4; j++){
                        newArray1[i,j] = rnd.Next(-9,10);
                        Console.Write(" {0,3}", newArray1[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("--------------------");
                int[,] newArray2 = new int[4,3];
                for(int i = 0 ; i < 4; i++){
                    for(int j = 0 ; j < 3; j++){
                        newArray2[i,j] = rnd.Next(-9,10);
                        Console.Write(" {0,3}", newArray2[i, j]);
                    }
                    Console.WriteLine();
                }
               Console.WriteLine("--------------------");
                int[,] multiplicationArray1 = new int[3,3];

                for(int i = 0 ; i < 3; i++){
                    for(int j = 0 ; j < 3; j++){
                        int summEch = 0;
                        for(int conutI = 0 ; conutI < 4; conutI++){
                           summEch +=  newArray1[i,conutI] * newArray2[conutI,j];
                          
                        }

                        multiplicationArray1[i,j] = summEch;

                        Console.Write(" {0,3}", multiplicationArray1[i, j]);
                    }
                    Console.WriteLine();
                }

         

            }
            
            async void task5(){
                Random rnd = new Random();  
                int prozv(int iteger){
                    string number = $"{iteger}";
                    int prozvedenie = 1;
                    for(int i = 0; i< number.Length;i++){
                        prozvedenie = prozvedenie * Convert.ToInt32( ""+number[i]);
                    }
                    return prozvedenie;

                }
                 int summ(int iteger){
                    string number = $"{iteger}";
                    int summNumber = 0;
                    for(int i = 0; i< number.Length;i++){
                        summNumber = summNumber + Convert.ToInt32( ""+number[i]);
                    }
                    return summNumber;

                }
                    List<int> listProiz= new List<int>();
                    int[,] newArray1 = new int[3,4];
                    for(int i = 0 ; i < 3; i++){
                        for(int j = 0 ; j < 4; j++){
                            newArray1[i,j] = rnd.Next(100,9999);
                            Console.Write(" {0,3}", newArray1[i, j]);
                            if(prozv(newArray1[i,j]) < summ(newArray1[i,j])){
                                listProiz.Add(newArray1[i,j]);
                            }            
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("--------------------");

                    for(int i=0; i< listProiz.Count; i++){
                        Console.WriteLine(" {0,3},",listProiz[i]);
                    }

                    


                }

               
            
          

               
            
          

               
            
        }

        
    }
}
