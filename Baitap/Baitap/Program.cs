﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Danh sach so nguyen to:");
        for (int i = 2; i <= 100; i++) 
        {
            bool isPrime = true; 

            for (int j = 2; j < i; j++) 
            {
                if (i % j == 0) 
                {
                    isPrime = false; 
                    break; 
                }
            }

            if (isPrime) 
            {
                Console.WriteLine(i); 
            }
        }
    }
}
