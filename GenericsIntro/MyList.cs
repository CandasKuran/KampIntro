using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor   "ctor" tabtab yaptigimiz zaman classimizi calistirir.
        public MyList()
        {
            items = new T[0];  //0 elemanli bir string array i newliyoruz. T ye karsilik gelen string olmasi gerektigini program cs de soyledik
        }
        public void Add(T item)
        {
            T[] tempArray = items; //tempArray => gecici dizi olustururak bunu items a sabitliyoruz. bu sekilde new ledigimiz zaman referans
                                   //numarasi degisecegi icin eski veriler silinecegi icin burda items a sabitleyerek yeni ekledigimiz elemanlarin silinmemesini sagliyoruz. 
                                   //bu gecici dizi bizim icin elimizdeki arrayi tutacak ve digerini eklerken bunun silinmemesini saglayacak. 2 satir sonra bu gecici diziyi
                                   //bir alt satirda olusturdugumuz yeni listeye eklemek icin for dongusu kullanacaz,.
            items = new T[items.Length+1]; //dizinin eleman sayisini 1 arttiriyoruz ve dinamik hale getiriyoruz. burda new dedigimiz icin referans adresi degisecek ve
                                           //bir onceki array icerigi sifirlanacak. o yuzden bir ust satirdaki islemi uyguluyoruz.
            for (int i = 0; i < tempArray.Length; i++)
            {                                           //burda ise gecici olarak degerleri icinde tutmasi icin olsturdugumuz tempArray in icinde gezerek verileri yeni
                                                        //olusan referans numarali dizimize ekliyoruz. boylece ekledigimiz yeni deger ile birlikte eski degerler ayni liste icersiinde birlesecek.
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;  //burda ise items.Lenght-1(listenin son elemani) item a esitleyerek sonuncu indexe yeni item i ekliyoruz.
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
