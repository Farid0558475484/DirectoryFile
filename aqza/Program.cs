using System;
using System.IO;
namespace qwerty
{

    class EmptyClass
    {
        static void Main(string[] args)
        {

            Directory.CreateDirectory(@"/Users/xamyak/Desktop/Test");
            //Directory.CreateDirectory(@"/Users/xamyak/Desktop/Test/salam.txt");
            //Directory.CreateDirectory(@"/Users/xamyak/Desktop/Test/dewre.txt");
            //Directory.Delete(@"/Users/xamyak/Desktop/Test", true);
            //if (Directory.Exists(@"/Users/xamyak/Desktop/Test/salam.txt"))
            //{
            //    Directory.Delete(@"/Users/xamyak/Desktop/Test",true);

            //}

            //string[] arr = Directory.GetFiles(@"/Users/xamyak/Desktop/Test");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("salam");

            //File.Create(@"/Users/xamyak/Desktop/Test/salam.txt");

            string[] arr = Directory.GetFiles(@"/Users/xamyak/Desktop/Test");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            StreamWriter sw = new StreamWriter(@"/Users/xamyak/Desktop/Test/salam.txt");
            sw.WriteLine("qwertyujhdgdfs");
            sw.Close();


            StreamReader sw1 = new StreamReader(@"/Users/xamyak/Desktop/Test/salam.txt");
            string result = sw1.ReadToEnd();
            Console.WriteLine(result);
        }


    }

}