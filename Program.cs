using System;
using System.Text;
using System.Threading.Tasks;

namespace hesapmakine
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int res;
                Console.Write("Birinci Sayıyı Giriniz:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("İkinci Sayıyı Giriniz:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Sembol Giriniz:(/,+,-,*):");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Toplam:" + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Çıkarma:" + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Çarpma:" + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Bölme:" + res);
                        break;
                    default:
                        Console.WriteLine("Yanlış Giriş!!!");
                        break;
                }
                Console.ReadLine();
                Console.Write("Devam etmek istiyor musun(e/h):");
                value = Console.ReadLine();
            }
            while (value == "e" || value == "E");
        }
    }

}