using System;
using System.IO;
using aqza.Models;
using Newtonsoft.Json;

namespace qwerty
{

    class EmptyClass
    {
        static void Main(string[] args)
        {
            #region

            //Directory.CreateDirectory(@"/Users/xamyak/Desktop/Test");
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

            //Console.WriteLine("salam");

            //File.Create(@"/Users/xamyak/Desktop/Test/salam.txt");

            //string[] arr = Directory.GetFiles(@"/Users/xamyak/Desktop/Test");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //StreamWriter sw = new StreamWriter(@"/Users/xamyak/Desktop/Test/salam.txt");
            //sw.WriteLine("qwertyujhdgdfs");
            //sw.Close();


            //StreamReader sw1 = new StreamReader(@"/Users/xamyak/Desktop/Test/salam.txt");
            //string result = sw1.ReadToEnd();
            //Console.WriteLine(result);

            //using(StreamWriter sw = new StreamWriter(@"/Users/xamyak/Desktop/Test/salam.txt"))
            //{
            //    sw.WriteLine("f3rqfwfqwd");
            //}


            //using (StreamReader sw1 = new StreamReader(@"/Users/xamyak/Desktop/Test/salam.txt"))
            //{
            //    string result = sw1.ReadToEnd();
            //    Console.WriteLine(result);
            //}

            #endregion


            #region

            Product p1 = new Product { Id = 1, Name = "Iphone11", Price = 999 };
            Product p2 = new Product { Id = 2, Name = "Iphone12", Price = 1999 };
            Product p3 = new Product { Id = 3, Name = "Iphone13", Price = 2999 };

            ProductItem ProductItem = new ProductItem { Id = 1, TotalPrice = p1.Price, Product = p1 };
            ProductItem ProductItem1 = new ProductItem { Id = 2, TotalPrice = p2.Price, Product = p2 };
            ProductItem ProductItem2 = new ProductItem { Id = 3, TotalPrice = p3.Price, Product = p3 };



            List<ProductItem> list = new List<ProductItem>();

            list.Add(ProductItem);
            list.Add(ProductItem1);
            list.Add(ProductItem2);

            ProductItems ProductItems = new ProductItems { Id = 1, ProductItem = list };
            //string result = JsonConvert.SerializeObject(ProductItems);
            //Console.WriteLine(result);


            //using (StreamWriter sw = new StreamWriter(@"/Users/xamyak/Desktop/aqza/aqza/Json/jsonfile.json", true))
            //{
            //    sw.WriteLine(result);
            //}

            using (StreamReader sw1 = new StreamReader(@"/Users/xamyak/Desktop/aqza/aqza/Json/jsonfile.json", true))
            {
                string result = sw1.ReadToEnd();
                Console.WriteLine(result);
            }


            #endregion
        }


    }

}