﻿using System;
namespace Task1
{
    public class Task1{
        public static void sayHello(string name){
            string sms=$"Hello {name}!";
            Console.WriteLine(sms);
        }
        public static void HelloUser(){
            Console.WriteLine("Введите ваше имя: ");
            string val = Console.ReadLine();
            sayHello(val);
        }
        public static void Square(){
            Console.WriteLine("Введите число: ");
            string str = Console.ReadLine();
            bool success = int.TryParse(str, out int number);
            if (success){
                Console.WriteLine($"Число {number} в квадрате: {Math.Pow(number,2)}");
            }
            else{
                Console.WriteLine($"{str} - не число!");
            }
        }
        public static void Sum(){
                Console.WriteLine("Введите два числа через Enter: ");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int s = num1 + num2;
                Console.WriteLine($"Сумма {num1} + {num2} = {s}");

        }
        public static void Main(){ 
            Console.InputEncoding = System.Text.Encoding.UTF8;
            sayHello("Илья"); //Task1.1
            HelloUser(); // Task1.2
            Square(); // Task1.3
            Sum(); // Task1.4


        }
        
    }
}
