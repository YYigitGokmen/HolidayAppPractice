

using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

string[] validOptions = { "bodrum", "marmaris", "cesme" };
string secilenTatil;
bool isValid;
int packagePrice = 0;

//kullanıcıdan gelen cevaplar eşliğinde do while ve if döngüleri ile süreç tamamlanıyor.

do {
    Console.WriteLine("Merhaba lütfen tatil için girmek istediğiniz lokasyonu seçiniz.");
    Console.WriteLine("");
    Console.WriteLine(" Bodrum (Paket başlangıç fiyatı 4000 TL)");
    Console.WriteLine(" Marmaris (Paket başlangıç fiyatı 3000 TL)");
    Console.WriteLine(" Cesme (Paket başlangıç fiyatı 5000 TL)");
    secilenTatil = Console.ReadLine().ToLower();

    isValid = Array.Exists(validOptions, option => option == secilenTatil);

    if (!isValid)

    {
        Console.WriteLine("Yanlış lokasyon tekrar deneyiniz.");
        
    }
}
while(!isValid);
Console.WriteLine("Teşekklürler seçiminiz: "+ secilenTatil);



if (secilenTatil == "bodrum")
{
    packagePrice = 4000;
}
else if (secilenTatil == "marmaris")
{
    packagePrice = 3000;
}
else if (secilenTatil == "cesme")

        { packagePrice = 5000;
}



Console.Write("Kaç kişi için tatil planlamak istersiniz? : ");

int people = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("");

switch (secilenTatil)
{
    case "bodrum":
        Console.WriteLine("Önerilerimiz: Bodrum Sualtı Arkeoloji Müzesi'ni keşfedin. ...\r\n" +
            "Bodrum Antik Tiyatrosu'nda gösterilere katılın. ...\r\nZeki Müren Müzesi'nde sanat" +
            " güneşini anın. ...");
        break;

    case "marmaris":
        Console.WriteLine("Önerilerimiz: Marmaris’in doğa güzellikleri ile eşsiz bir seyahat geçirmenizi" +
            " sağlayacak marmaris’te gezilecek yerler ise şöyle sıralanabilir: Marmaris Kalesi ve" +
            " Müzesi, Turgut Şelalesi, Dalaman Çayı");
        break;

    case "cesme":
        Console.WriteLine("Önerilerimiz: Alaçatı’nın tarihi taş evlerinden devşirme taş otellerinde konaklamak" +
            " Çeşme deneyiminin en özel parçalarından");
        break;
}

Console.WriteLine("");

string[] correctOnes = { "1", "2" };
string road;
bool ısOption;
int roadPrice = 0;

do
{
    Console.WriteLine("Tatilinize ne şekilde gitmek istersiniz? ");
    Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
    Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
    Console.WriteLine("Lütfen yukarıdaki seçeneklerden birini seçiniz.");
    road =Console.ReadLine();
    ısOption = Array.Exists(correctOnes, Ones => Ones == road);

    if (!ısOption)

    {
        Console.WriteLine("Yanlış Tercih Lütfen tekrar deneyiniz.");
            };

} while (!ısOption);
Console.WriteLine("Teşekkürler şeçiminiz: " + road);

if (road =="1")
{
   roadPrice = people* 1500;
}
else if (road =="2")
{
    roadPrice = people* 4000;
}

int totalSum = roadPrice + packagePrice;
//kullanıcıdan gelen veriler eşliğinde kişi başı hava ve kara yolu ücret değişimini dikkate alarak toplam ücreti yansıttım
Console.WriteLine("Güncel Tatil Ücretiniz:"+totalSum);


//bir while döngüsü kullanarak verilen cevaba göre programı tekrar baştan başlatabildik veya break ile direkt bitirebildik.
while (true)
{
    
    Console.WriteLine("Başka bir tatil planı yapmak ister misiniz? (Evet veya Hayır)");
    string answer = Console.ReadLine().ToLower();

    if (answer == "evet")
    {
        Console.WriteLine("En başa yönlendiriliyorsunuz...");
        Process.Start("HolidayApp.exe");
    }
    else
    {
        Console.WriteLine("İyi günler");
        break;
    }
}



