﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPrac1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Linq 없이 2의 배수 구하기
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> output = new List<int>();
            
            foreach (var item in input)
            {
                if (item % 2 == 0) output.Add(item);

            } 
            foreach(var item in output)
            {
                Console.WriteLine(item);
            }
            var output2 = from item in input
                          where item % 2 == 0
                          orderby item descending
                          select item*item;
            foreach (var item in output2)
            {
                Console.WriteLine(item);
            }
            output = output2.ToList<int>(); 
        }
    }
}
