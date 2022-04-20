using System;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine(@"Какую задачу запустить, укажите номер: 
            1.  Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
            2.  Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            3.  Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            4.  Дано предложение. Напишите рекурсивный метод, подсчитывающий количество слов в данном предложении. Словом считается последовательность символов без пробелов.
            5.  Известно, что пароль длиной 3 символа состоит из латинских букв строчного регистра и цифр от 0 до 9. Напишите рекурсивный метод, который перебирает все комбинации паролей. 
            6.  Даны натуральные числа a и b. Рекурсивно описать функцию возведения числа a в степень b, используя только операцию инкрементирования (“++”).
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

            //Функция получения начального и конечного числа ряда
            int[] AskUser(){
                int[] period = new int[2];
                Console.Write("Ведите начальное число: ");
                period[0] = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("");
                Console.Write("Ведите Конечное число: ");
                period[1] = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("");

                return period;
            }
           



             void task1(){
                 string recurs(int m,int n){
                     if(m==n){
                         if(m%3==0){
                             return $", {m}";
                         }else{
                             return "";
                         }
                     }
                     if(m%3==0){
                         return $", {m}" + recurs(m+1,n);
                     }else{
                         return recurs(m+1,n);
                     }
                 }


                int[] period = AskUser();

                Console.Write(recurs(period[0],period[1]));   

            };

             void task2(){
                 int recurs(int m,int n){
                     if(m==n){
                         return m;
                     }else{
                         return m + recurs(m+1,n);
                     }
                 }


                int[] period = AskUser();

                 Console.Write($" {recurs(period[0],period[1])}");
               
                
            };

             void task3(){
                int akkerman(int m, int n){
                    Console.WriteLine($" {m}, {n}");
                    if(m==0){
                        return n+1;
                    }else if(n==0){
                        return akkerman(m-1,1);
                    }
                    else{
                        return akkerman(m-1,akkerman(m,n-1));
                    }
                }
                int m = 3;
                int n = 2;
                Console.WriteLine(akkerman(m,n));
            };

             void task4(){
                int countString(string str, int step=0){
                    if(step == str.Length-1){
                        return 1;
                    }else if(str[step] == ' ' && str[step-1] != ' '){
                        return 1+countString(str,step+1);
                    }else{
                        return countString(str,step+1);
                    }

                }
                string str = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.";
                

                Console.WriteLine($"Кол-во слов = {countString(str)}");
               

            };
            
             void task5(int lenPassworn = 3){
                string dictionaryABC = "0123456789abcdefghijklmnopqrstuvwxyz";
                string GenerationPass(int len){
                    Random rnd = new Random(); 
                    string pass = "";
                    for(int i = 0; i < len; i++){
                        
                        pass += dictionaryABC[rnd.Next(0,dictionaryABC.Length)];
                    }
                    return pass;
                }
                string convertPass(int step){
                    // Конвектируем порядковый номер в строку
                    int lenDictionary = dictionaryABC.Length;
                   
                    if(step < lenDictionary){
                        return $"{dictionaryABC[step]}";
                    }else{
                        return convertPass(step/(lenDictionary)) + dictionaryABC[step%lenDictionary];
                    }
                    

                };
                string BruteForcePass(string secretPass, int step=0){
                    //рекурсивная фукция брутфорса пароля

                    
                    int countCombination = Convert.ToInt32(Math.Pow(dictionaryABC.Length-1, lenPassworn));

                    if(step == countCombination-1){
                        return "не нашли";
                    }else if(convertPass(step) == secretPass){
                        return convertPass(step);
                    }else{
                        Console.WriteLine($"пароль {convertPass(step)}");
                        try{
                            return BruteForcePass(secretPass,step+1);
                        }
                        catch {
                            return("Ошибка");
                            }
                        
                    }


                    return "";
                }

                int countCombination = Convert.ToInt32(Math.Pow(dictionaryABC.Length, lenPassworn));

                string pass = GenerationPass(lenPassworn);
                

                try{
                    Console.WriteLine($"Угадали пароль {BruteForcePass(pass)}");
                }catch{
                    Console.WriteLine($"Ошибка");
                }
              
                
              
              
            };

             void task6(){
                int recursDegree(int number, int degree){
                    if(degree == 1){
                        return number;
                    }
                    return number*recursDegree(number,degree-1);
                }

                int a = 2;
                int b = 23;
                Console.WriteLine(recursDegree(a,b));

               
            };

           
               
            
           }



               
            
        

        
    }
}
