using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;


namespace dori_savdo_sotiq
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "dorilar_bazasi.txt";
          

            StreamReader reader = new StreamReader(path);
            var satr =new List < Tuple<int, string, int>>();
            int it1, it3;
            string[] s = reader.ReadToEnd().Split('\n');
            string[] sa;
            foreach (var item in s)
            { sa = item.Split(' ');
                if (sa[0] != "\n" && sa[0] != "")
                {
                    it1 = int.Parse(sa[0]);
                    it3 = int.Parse(sa[2]);
                    satr.Add(new Tuple<int, string, int>(it1, sa[1], it3));
                }
            }




        
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

        l1:

            reader.Close();
            StreamWriter writer = new StreamWriter(path);
            foreach (var item in satr)
            {
                writer.WriteLine(item.Item1 + " " + item.Item2 + " " + item.Item3 );
            }
            writer.Close();
            Console.Write("========== Dorixona xizmati ==========\n 1. Dorilar(CRUD)                    " +
             " \n 2. Dori qidirish                     \n    Tanlang... ");

           
            l2:
            try
            {
                byte a = byte.Parse(Console.ReadLine());
                
                switch (a)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.Write("========== Dorixona xizmati ==========\n 1. Yangi dori qo'shish         " +
                      " \n 2. Dorilar ro'yxati          \n 3. Dori ma'lumotlarini o'zgartirish\n" +
                      " 4. Dorini o'chirish       \n  0. Ortga qaytish         \n     Tanlang... ");
                            a = byte.Parse(Console.ReadLine());
                            switch (a)
                            {
                                case 1: {
                                        Console.Clear();

                                        int Id = satr.Count+1;
                                        string dorinomi;
                                        Console.Write("Dori Nomi kiriting ==> ");
                                        dorinomi = Console.ReadLine();
                                        
                                        Console.Write("Dori Narxini kiriting ==> ");
                                      int  narx = int.Parse(Console.ReadLine());
                                        satr.Add(new Tuple<int, string, int>(Id, dorinomi, narx));
                                            
                                        goto l1;
                                    }
                                case 2: {
                                        Console.Clear();
                                        foreach (var item in satr)
                                        {
                                            Console.WriteLine(item.Item1+". "+item.Item2+" - "+item.Item3);
                                        }
                                        goto l1;
                                    }
                                case 3:
                                    {
                                        Console.Clear();
                                        foreach (var item in satr)
                                        {
                                            Console.WriteLine(item.Item1 + ". " + item.Item2 + " - " + item.Item3);
                                        }
                                        Console.WriteLine("\n Qaysi Dorini o'zgartirmoqchi bo'lsangiz shuni nomeri tanlang ===>> ");
                                        a = byte.Parse(Console.ReadLine());
                                        satr.RemoveAt(a-1);
                                        int Id = satr.Count;
                                        string dorinomi;
                                        Console.Write("Dori Nomi kiriting ==> ");
                                        dorinomi = Console.ReadLine();

                                        Console.Write("Dori Narxini kiriting ==> ");
                                        int narx = int.Parse(Console.ReadLine());

                                        satr.Insert(a,new Tuple<int, string, int>(Id,dorinomi,narx));

                                        goto l1;
                                    }
                                case 4: {
                                        Console.Clear();
                                        foreach (var item in satr)
                                        {
                                            Console.WriteLine(item.Item1 + ". " + item.Item2 + " - " + item.Item3);
                                        }
                                        Console.WriteLine("\n Qaysi Dorini o'chirmoqchi bo'lsangiz shuni nomeri tanlang ===>> ");
                                        a = byte.Parse(Console.ReadLine());
                                       
                                        satr.RemoveAt(a-1);  goto l1; }
                                case 0: { Console.Clear(); goto l1; }

                            }
                            break;
                        }

                    case 2: {
                            Console.Clear();
                            Console.WriteLine("Qidirayotgan doringizni nomi kiriting");
                            string bormi = Console.ReadLine();
                            
                            foreach (var item in satr)
                            {
                                if(bormi==item.Item2) {
                                    Console.WriteLine("Siz izlagan dori bor!!!");
                                    Console.WriteLine(item.Item1 + ". " + item.Item2 + " - " + item.Item3);
                                    goto l1;
                                }
                                
                            }
                            Console.WriteLine("Uzur Siz izlagan dori yo'q.");
                            goto l1;
                        }
                    default: {  Console.WriteLine("Iltimos Berilgan sonlarni kiritish!!!"); goto l2;  }
                }
            }
            catch (Exception)
            {
                 Console.WriteLine("Iltimos Raqam kiriting!!!");
                goto l2;
            }
            

            Console.ReadKey();
            
        }
    }
}
