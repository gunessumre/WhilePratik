//1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

int i;
 i=1;
 while (i<=10)
 {
     Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
     i++;
 }

//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

 int j = 1;
 while (j <= 20)
 {
     Console.WriteLine(j);
    j++;
 }


//3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

 int k = 2;
 while (k <= 20)
 {
     Console.WriteLine(k);
     k += 2;
 }

//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int toplam = 0;
int sayi = 50; 
while (sayi <= 150)
 {
     toplam += sayi;  
     sayi++;  
 }
 Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);

// 5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
int tekToplam = 0;
int ciftToplam = 0;
int sayi1 = 1;

// 1 ile 120 arasındaki sayılar için while dongusu 120 i de dahil olmasi icin <= operatorunu kullandik
while (sayi1 <= 120)
{
    if (sayi1 % 2 == 0)  // Eger sayi çift ise
    {
        ciftToplam += sayi1;  // Cift toplamina ekle
    }
    else  // Eğer sayı tek ise
    {
        tekToplam += sayi1;  // Tek toplamina ekle
    }

    sayi1++;  // sayıyı 1 artir
}
// Sonuclari ekrana yazdir
Console.WriteLine("Tek sayıların toplamı: " + tekToplam);
Console.WriteLine("Çift sayıların toplamı: " + ciftToplam);


