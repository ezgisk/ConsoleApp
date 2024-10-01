
Console.WriteLine("Lutfen asagidaki bilgileri giriniz:");
string tcNo;
while (true)
{
    Console.Write("T.C. Kimlik Numarası: ");
    tcNo = Console.ReadLine();

    // Check if the T.C. identification number is 11 digits long
    if (tcNo.Length == 11 && long.TryParse(tcNo, out _)) // We're also checking if it's numeric
    {
        break;
    }
    else
    {
        Console.WriteLine("T.C. Kimlik Numarası 11 haneli olmalıdır ve yalnızca rakamlardan oluşmalıdır.");
    }
}
Console.WriteLine("Adi:");
string firstName = Console.ReadLine();

Console.WriteLine("Soyadi:");
string lastName = Console.ReadLine();

Console.WriteLine("Telefon Numarasi:");
string phoneNumber = Console.ReadLine();
// Telefon numarasini string olarak almamin nedeni hem ulusal olarak telefon numaralarinin farkliligi hem de basindaki sifirin int da kaybolmasidir.

Console.WriteLine("Yas:");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Ilk Aldigi Urunun Fiyati:");
double firstProductPrice = double.Parse(Console.ReadLine());

Console.WriteLine("Ikinci Aldigi Urunun Fiyati:");
double secondProductPrice = double.Parse(Console.ReadLine());
//Finding to total amount
double totalAmount = firstProductPrice + secondProductPrice;
//Finding to earned points
double earnedPoints = totalAmount * 0.10;
//Aldigi urun fiyati bilgilerini double tutmamdaki neden fiyatin ondalikli olabilmesidir.Orn: 100,50
Console.WriteLine("---------------------------------------------");
Console.WriteLine($"{tcNo} Tc numaralı {firstName} {lastName} isimli kişi için kayıt oluşturulmuştur.");
Console.WriteLine($"{phoneNumber} telefon numarasına bildirim mesajı gönderilmiştir.");
Console.WriteLine($"{totalAmount} toplam harcama karşılığı kazanılan %10 patika puan miktarı -> {earnedPoints} TL'dir.");

