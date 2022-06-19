/* 
Ref ve out keywordleri;
Değer tipleri referans tiplere dönüştürmeyi, daha doğrusu ilgili değerin referansını kullanmayı sağlar.

Ref keyword'ünde ilgili değişkene bir başlangıç değeri verilmesi gerekmektedir. Yoksa program hata verir.
Out keyword'ünde ilgili değişkene başlangıç değeri verilmesine gerek yoktur. Ancak bir metot ya da fonksiyon içinde
kullanıldığında değişken değeri güncellenmek zorundadır.
*/

/***** Ref kullanımı *****/
int sayi1 = 21;
int sayi2 = 20;

var sonuc = Ekle(ref sayi1, sayi2);
Console.WriteLine(sonuc);
Console.WriteLine(sayi1);

static int Ekle(ref int sayi1, int sayi2)
{
    sayi1 = 25;
    return sayi1 + sayi2;
}



/***** Out kullanımı *****/
int number1 = 21;
int number2;

var result = Add(number1, out number2);
Console.WriteLine(result);
Console.WriteLine(number2);

static int Add(int number1, out int number2)
{
    number2 = 30;
    return number1 + number2;
}