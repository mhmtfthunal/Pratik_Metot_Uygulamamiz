//Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. 

void SarkiSozu()
{
    Console.WriteLine("Geçmişin işleri şehrin stresi\r\nHayat yarışı ve zamansız bitmesi\r\nNe kadar umrumda olabilir ki?\r\nNe kadar umrumda olabilir ki?");
}
SarkiSozu();


Console.WriteLine("---------------------------");


//Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.

int RastGeleSayi()
{

    Random rnd = new Random();

    int rastgeleSayiUret = rnd.Next();

    int kalan = rastgeleSayiUret % 2;

    return kalan;
}

Console.WriteLine(RastGeleSayi());


Console.WriteLine("---------------------------");


//Parametre olarak aldığı iki sayının çarpımını geriye dönsün.


int Carpim(int sayi1, int sayi2)
{
    return sayi1 * sayi2;
}
Console.WriteLine(Carpim(15, 16));



Console.WriteLine("---------------------------");

//Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.


void HosGeldiniz(string ad, string soyAd)
{

    Console.WriteLine($"Hoş Geldiniz {ad} { soyAd}");

}
HosGeldiniz("ali", "yılmaz");