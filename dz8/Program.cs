using System;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine(@"Какую задачу запустить, укажите номер: 
            1.  Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
            2.  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
            3.  Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
            4.  Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая построчно выведет элементы и их индексы.
            5.  Задача 62: Заполните спирально массив 4 на 4 числами от 1 до 16.
            6.  Задача 1. 1. Дан двумерный массив. Заменить в нём элементы первой строки элементами главной диагонали. А элементы последней строки, элементами побочной диагонали.
            7.  Дан двумерный массив, заполненный случайными числами от -9 до 9. Подсчитать частоту вхождения каждого числа в массив, используя словарь.
            8.  Найти минимальный по модулю элемент. Удалить столбец и диагонали, содержащие его.
            9.  Заполните двумерный массив 3х3 числами от 1 до 9 змейкой.
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
                case 8:
                    task8();
                    break;
                case 9:
                    task9();
                    break;
                default:
                    Console.WriteLine("Вы ввели неправильное число");
                    break;
            }
            ///Метод для генерации 2 мерного массива
            int[,] GenerateRandomArray(int row=0, int column=0){
                Random rnd = new Random();  
                if(row == 0){
                    row = rnd.Next(4,40);
                }
                if(column == 0){
                        column= rnd.Next(4,40);
                }

                int[,] newArray = new int[row,column];
                for(int i = 0 ; i < row; i++){
                    for(int j = 0 ; j < column; j++){
                        newArray[i,j] = rnd.Next(0,999);

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



            async void task1(){
                int [,] matrch = GenerateRandomArray();
                printMatrch(matrch);
                for(int i = 0; i < matrch.GetLength(0); i++){
                    for(int j = 0; j < matrch.GetLength(1); j ++){
                        for(int jStep = 1; jStep < matrch.GetLength(1); jStep++){
                            if(matrch[i,jStep]> matrch[i,jStep-1]){
                                (matrch[i,jStep], matrch[i,jStep-1]) = (matrch[i,jStep-1], matrch[i,jStep]);
                            }
                        }
                    }
                }
                Console.WriteLine("----------------------");
                printMatrch(matrch);

              
            };

            async void task2(){
                int [,] matrch = GenerateRandomArray(4,4);
                printMatrch(matrch);
                int [] sumRow = new int[matrch.GetLength(0)];

                for(int i=0; i< matrch.GetLength(0); i++){
                    int sum = 0;
                    for(int j=0;j<matrch.GetLength(1);j++){
                        sum += matrch[i,j];
                    }
                    sumRow[i] = sum;
                }

                int minNumberRow = 0;
                for(int i = 1; i< sumRow.Length;i++){
                    if(sumRow[i-1]> sumRow[i]){
                        minNumberRow = i;
                    };
                };
                Console.WriteLine("");
                Console.WriteLine($"строка с минимальной суммой чисел {minNumberRow+1}");
             
                
            };

            async void task3(){
                int [,] matrch1 = GenerateRandomArray(3,4);
                int [,] matrch2 = GenerateRandomArray(4,3);
                printMatrch(matrch1);
                Console.WriteLine("--------------------");
                printMatrch(matrch2);
                Console.WriteLine("--------------------");


                int[,] multiplicationArray = new int[3,3];

                for(int i = 0 ; i < 3; i++){
                    for(int j = 0 ; j < 3; j++){
                        int summEch = 0;
                        for(int conutI = 0 ; conutI < 4; conutI++){
                           summEch +=  matrch1[i,conutI] * matrch2[conutI,j];
                        }
                        multiplicationArray[i,j] = summEch;
                    }
                }
                printMatrch(multiplicationArray);

            
            };

            async void task4(){
                Random rnd = new Random();
                int xVector = rnd.Next(4,10);
                int yVector = rnd.Next(4,10);
                int zVector = rnd.Next(4,10);

                int[,,] Matrich3D = new int[xVector,yVector,zVector];

                int[] uniqueInt = new int[xVector*yVector*zVector];

                for(int i =0 ; i< uniqueInt.Length; i++){
                    while (true){
                        int rundomInt = rnd.Next(4,99999);
                        if(Array.IndexOf(uniqueInt,rundomInt)<0){
                            uniqueInt[i] = rundomInt;
                            break;
                        }
                    };
                }
                int iUniqueInt = 0;
                for(int x =0; x < xVector;x++){
                    for(int y =0;y<yVector;y++){
                        for(int z = 0; z<zVector;z++){
                            Matrich3D[x,y,z] = uniqueInt[iUniqueInt];
                            iUniqueInt++;
                        }
                    }
                }
                for(int x =0; x < xVector;x++){
                    for(int y =0;y<yVector;y++){
                        for(int z = 0; z<zVector;z++){
                            Console.WriteLine($"Элемент массива Matrich3D[{x},{y},{z}] = {Matrich3D[x,y,z]}");
                        }
                    }
                }



                
               

            };
            
            async void task5(){
                int [,] matrch = new int[8,10];
                int itNumbers = 1;
                int step = 0;

                while(itNumbers <= matrch.GetLength(0) * matrch.GetLength(1)){
                  

                    for(int j = step; j< matrch.GetLength(1)-step; j++){
                        matrch[0+step,j] = itNumbers;
                        itNumbers++;
                    }
                   
                    for(int i = 1+step; i< matrch.GetLength(0)-step; i++){
                        matrch[i,matrch.GetLength(1)-1-step] = itNumbers;
                        itNumbers++;
                    }
                    
                    for(int j = matrch.GetLength(1)-2-step; j > step; j--){
                        matrch[matrch.GetLength(0)-1-step,j] = itNumbers;
                        itNumbers++;
                    }
                    
                    for(int i = matrch.GetLength(0)-1-step; i > step; i--){
                        matrch[i,0+step] = itNumbers;
                        itNumbers++;
                    }
                    step++;
                }

                printMatrch(matrch);
              
            };

            async void task6(){
                int [,] matrch = GenerateRandomArray(4,4);
                printMatrch(matrch);
                Console.WriteLine("");
                int temLast = matrch[0,matrch.GetLength(1)-1];
               

                for(int i = 0; i < matrch.GetLength(0); i++){
                   
                    matrch[0,i] = matrch[i,i];
                }
              

                for(int i = 0; i < matrch.GetLength(0); i++){
                    matrch[matrch.GetLength(0)-1,i] = matrch[matrch.GetLength(0)-1-i,i];
                }
                matrch[matrch.GetLength(0)-1,matrch.GetLength(1)-1] = temLast;
                printMatrch(matrch);

            };

            async void task7(){
                Random rnd = new Random();  
                int row = 4;
                int column = 4;

                int[,] newArray = new int[row,column];
                for(int i = 0 ; i < row; i++){
                    for(int j = 0 ; j < column; j++){
                        newArray[i,j] = rnd.Next(-9,9);

                    }
                }
                Dictionary<int,int> countNumber = new Dictionary<int,int>();


                for(int i = 0 ; i < row; i++){
                    for(int j = 0 ; j < column; j++){
                        if(countNumber.ContainsKey(newArray[i,j])){
                            countNumber[newArray[i,j]] ++;
                        }else{
                            countNumber[newArray[i,j]] = 1;
                        }

                    }
                }



            };

            async void task8(){
            };

            async void task9(){
                int [,] matrch = new int[8,10];
                int itNumbers = 1;
                int step = 0;

                while(itNumbers <= matrch.GetLength(0) * matrch.GetLength(1)){
                                
                    for(int i = 0; i< matrch.GetLength(0); i++){
                        matrch[i,step] = itNumbers;
                        itNumbers++;
                    }
                   
                    step++;
                    for(int i = matrch.GetLength(0)-1; i >= 0; i--){
                        matrch[i,step] = itNumbers;
                        itNumbers++;
                    }
                    step++;
                }

                printMatrch(matrch);
            };
               
            
           }



               
            
        

        
    }
}
