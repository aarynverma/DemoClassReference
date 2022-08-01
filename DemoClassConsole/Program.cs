// See https://aka.ms/new-console-template for more information

using System;
using System.Data.Common;
using DemoClass;

namespace App {
    class Progrom
    {
        static void Main(string[] args)
        {
            var message = MessageHelper.GetMessage();
            Console.WriteLine(message);
        }
    }

}

