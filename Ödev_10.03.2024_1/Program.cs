// See Bir tamsayı alan ve tamsayı basamaklarını çözümleyen bir program yazınız.

//Girilen ifadenin doğru bir tamsayı olup olmadığı kontrol etmelisiniz.Eğer ki kullanıcının giriş yaptığı değer bir tamsayı değilse, kullanıcıdan doğru formatta bir sayı istemelisiniz.  
//Ayrıca yapılacak işlemler kesinlikle tamsayı tipindeki değişkenler kullanılarak yapılmalıdır.Bu uygulamada string metotları kullanılmayacaktır.Kullanıcının programı sonlandırmak için sayı giriş aşamasında “exit” yazılması gereklidir.

//2837 sayısı için sonuç aşağıdaki gibi görünmelidir:

//7 x 1 = 7

//3 x 10 = 30

//8 x 100 = 800

//2 x 1000 = 2000


using System;
using System.Reflection.Metadata;

namespace _Ödev_10032024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasamakAyirma();
        }
        static void BasamakAyirma()
        {
            int sayi1;
            do
            {
                try
                {
                    Console.WriteLine("Lütfen Basamaklarına Ayrılmasını İstediğiniz Sayiyi Giriniz :");
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    sayi1 = Math.Abs(sayi1);
                    int sayac = 1;
                    while (sayi1 != 0) 
                    {
                        int basamak = sayi1 % 10;
                        Console.WriteLine($"{sayac}'ler basamağı : {basamak} x {sayac} = {basamak * sayac}");

                        sayac *= 10;
                        sayi1 /= 10;
                    }
                    break;

                }

                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }

             } while (true);
            
        }
    }
} 


