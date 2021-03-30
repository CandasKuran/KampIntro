using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {                          // ProductManager icinden cagiracaksin. Kullanilacak isim Add ve parametre olarak product ata.
        public void Add(Product product) // void tanimlamasi git ve bu isi yap demek istedigimiz opsiyonlar icin kullaniyoruz. 
                                         //ornekte oldugu gibi git ve bunu ekle gibi.
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "guncellendi.");
        }

        

    }
}


//public int Topla(int sayi1, int sayi2)        //int ile kullanip return ettikten sonra bu sonucu daha sonra baska bir fonksiyonda cagirip kullanabiliyoruz.
//{
//    return sayi1 + sayi2;
//}
//int toplamaSonucu = productManager.Topla(3,6);
//burda bir int degerine sonucu atiyor ve daha sonra kullanabiliyoruz.
//Console.WriteLine(toplamaSonucu*2); => bu sekilde tekrar o degeri kullanarak 2 ile carpabiliyoruz.


//public void Topla2(int sayi1, int sayi2)
//{
//    Console.WriteLine(sayi1 + sayi2);       // void ile yazdigimiz bu islemde islem yapilir ve ekrana yazilir.
//                                              bu sonucu daha sonra tekrar baska bir fonksiyon icinde kullanamayiz.
//}

// productManager.Topla2(3,6);
//bunun ciktisi 9 olur ve ekrana yazilir.


//bu ProductManager de istedigimiz operasyonlari ekliyoruz.