﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var filePath = @"c:\vidobu\cs_file.txt";

            var fi = new FileInfo(filePath);

            var fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);

            var byteArr = new byte[fi.Length];

            fs.Read(byteArr, 0, byteArr.Length);

            Console.WriteLine(Encoding.UTF8.GetString(byteArr));

            Console.WriteLine(new string('-', 40));

            var str = "FileStream ile yazdık";
            var strArr = Encoding.UTF8.GetBytes(str);

            fs.Write(strArr, 0, strArr.Length);

            Console.ReadKey();


        }
    }
}
