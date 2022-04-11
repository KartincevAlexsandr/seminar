using System;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine(@"Какую задачу запустить, укажите номер: 
            1.  
            2. 
            3.
            4. 
            5. 
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
              
            };

            void task2(){
             
                
            };

            async void task3(){
            
            };

            async void task4(){
               

            }
            
            async void task5(){
              

               
            
           }



               
            
        

        
    }
}
