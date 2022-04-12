using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_yonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int say = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı:" + say);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: "+ex.Message.ToString());
            }
            //finally
            //{
            //    Console.WriteLine("İşlem Tamamlandı");
            //}
            try
            {
                Console.WriteLine();

                //int a=int.Parse(null);
                //int a=int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş Değer girdiniz");
                Console.WriteLine(ex);
                
            }
            catch (FormatException ex)  
            {
                Console.WriteLine("veri tipi uygun değil");
                Console.WriteLine(ex);
            } 
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük değer girdiniz...");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlemler Tamamlandı...");
            }
            
            Console.ReadLine();

        }
    }
}
