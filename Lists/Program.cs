﻿using System;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var newArray = new int[5];

            var newArray2 = new int[5]{1,2,3,4,5};

            var newStructArray = new Test[3]{new Test(), new Test(), new Test()};
            newArray[0] = 10;

            Console.WriteLine(newArray[0]);
            Console.WriteLine(newArray2[3]);
            Console.WriteLine(newStructArray[3]);
        }

        struct Test
        {
            public int Id { get; set; }
        }
    }
}
