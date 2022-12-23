using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class SwitchCase
    {
        static void Main(string[] args)
        {
            var number = 20;
            switch (number)//switch için şart yazıyoruz
            {
                case 10://10 olma  durumunda ekrana yazdır
                    Console.WriteLine("Number is 10");
                break;//

                case 20://20 olma durumunda ekrana yazdır
                    Console.WriteLine("Number is 20");
                    break;

                default: //iki şartı da sağlamıyorsa ekrana yazdır
                    Console.WriteLine("Number is not 10 or 20");
                    break;
                    
                    
            }
            Console.ReadKey();
        }
    }
}
