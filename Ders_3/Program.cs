
#region İF-Else

//Console.Write("Şifrenizi girin :");
//string password = Console.ReadLine();

//if (password == "A1234")
//{
//    Console.WriteLine("Şifre doğru.");
//}
//else
//{
//    Console.WriteLine("Şifre yanlış.");
//}


//Console.Write("Başkent adını girin: ");
//string capital = Console.ReadLine();

//Console.Write("Ülke adını girin: ");
//string country = Console.ReadLine();

//if (capital.ToLower() == "ankara" && country.ToLower() == "türkiye")
//{
//    Console.WriteLine("Bilgiler doğru.");
//}
//else
//{
//    Console.WriteLine("Bilgiler yanlış.");
//}


//Console.Write("Sayı girin: ");
//int number = int.Parse(Console.ReadLine());

//if (number == 99)
//{
//    Console.WriteLine("Sayı doğru.");
//}
//else
//{
//    Console.WriteLine("Sayı yanlış.");
//}


//Console.Write("Not1 girin: ");
//int exam1 = int.Parse(Console.ReadLine());

//Console.Write("Not2 girin: ");
//int exam2 = int.Parse(Console.ReadLine());

//Console.Write("Not3 girin: ");
//int exam3 = int.Parse(Console.ReadLine());

//float average = (exam1 + exam2 + exam3) / 3;

//if (average>=0 & average<50)
//{
//    Console.WriteLine("Duum kötü.");
//}
//if (average >= 50 & average < 70)
//{
//    Console.WriteLine("Duum orta.");
//}
//if (average >= 70 & average < 85)
//{
//    Console.WriteLine("Duum iyi.");
//}
//if (average >= 85 & average <= 100)
//{
//    Console.WriteLine("Duum çok iyi.");
//}


//Console.Write("Şehir adını girin: ");
//string city = Console.ReadLine();

//if (city == "ankara" || city== "adana" ||city=="tokat")
//{
//    Console.WriteLine("Şehir mevcut.");
//}
//else
//{
//    Console.WriteLine("Şehir mevcut değil.");
//}


//Console.Write("Kullanıcı adını girin: ");
//string userName = Console.ReadLine();

//if (userName!="admin")
//{
//    Console.WriteLine("Kullanıcı adı hatalı !");
//}
//else
//{
//    Console.WriteLine("Kullanıcı adı doğru.");
//}

#endregion

#region Mod İşlemleri

//Console.Write("Sayı1 girin: ");
//int number1 = int.Parse(Console.ReadLine());

//Console.Write("Sayı1 girin: ");
//int number2 = int.Parse(Console.ReadLine());

//int result = number1 % number2;

//Console.WriteLine($"Sayı1 in Sayı2 ile bölümünden kalan : {result}'dır.");


//Console.Write("Sayı girin: ");
//int number = int.Parse(Console.ReadLine());

//if (number % 2 == 0)
//{
//    Console.WriteLine("Sayı çifttir.");
//}
//else
//{
//    Console.WriteLine("Sayı tektir.");
//}

#endregion

#region Char ile IF-ELSE

//Console.Write("Takım ilk harfini girin: ");
//int team = char.Parse(Console.ReadLine());

//if (team == 'b' || team == 'B')
//{
//    Console.WriteLine("Beşiktaş");
//}
//if (team == 'f' || team == 'F')
//{
//    Console.WriteLine("Fenerbahçe");
//}
//if (team == 'g' || team == 'G')
//{
//    Console.WriteLine("Galatasaray");
//}

#endregion

#region Proje Uygulaması

//Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
//Console.WriteLine();
//Console.WriteLine("------------------------------");
//Console.WriteLine("1-Ana Yemekler");
//Console.WriteLine("2-Çorbalar");
//Console.WriteLine("3-Pizzalar");
//Console.WriteLine("4-İçecekler");
//Console.WriteLine("5-Tatlılar");
//Console.WriteLine("------------------------------");
//Console.WriteLine();

//string menuItem;

//Console.Write("Detayını görmek istediğiniz menü seçimi: ");
//menuItem = Console.ReadLine();

//if (menuItem == "1")
//{
//    Console.WriteLine();
//    Console.WriteLine("------------Ana Yemekler------------");
//    Console.WriteLine();
//    Console.WriteLine("1-Köri Soslu Tavuk");
//    Console.WriteLine("2-Kızartma Tabağı");
//    Console.WriteLine("3-Fasulye Pilav");
//    Console.WriteLine("4-Fırında Somon");
//    Console.WriteLine("5-Patlıcan Musakka");
//    Console.WriteLine("------------Ana Yemekler------------");
//}
//else if (menuItem == "2")
//{
//    Console.WriteLine();
//    Console.WriteLine("------------Çorbalar------------");
//    Console.WriteLine();
//    Console.WriteLine("1-Mercimek Çorbası");
//    Console.WriteLine("2-Yayla Çorbası");
//    Console.WriteLine("3-Domates Çorbası");
//    Console.WriteLine("4-Tavuk Suyu Çorbası");
//    Console.WriteLine("5-Mantar Çorbası");
//    Console.WriteLine("------------Çorbalar------------");
//}
//else if (menuItem == "3")
//{
//    Console.WriteLine();
//    Console.WriteLine("------------Pizzalar------------");
//    Console.WriteLine();
//    Console.WriteLine("1-Margarita Pizza");
//    Console.WriteLine("2-Peperoni Pizza");
//    Console.WriteLine("3-Dört Peynirli Pizza");
//    Console.WriteLine("4-Vejetaryen Pizza");
//    Console.WriteLine("5-Akdeniz Pizza");
//    Console.WriteLine("------------Pizzalar------------");
//}
//else if (menuItem == "4")
//{
//    Console.WriteLine();
//    Console.WriteLine("------------İçecekler------------");
//    Console.WriteLine();
//    Console.WriteLine("1-Kola");
//    Console.WriteLine("2-Ayran");
//    Console.WriteLine("3-Portakal Suyu");
//    Console.WriteLine("4-Soda");
//    Console.WriteLine("5-Çay");
//    Console.WriteLine("------------İçecekler------------");
//}
//else if (menuItem == "5")
//{
//    Console.WriteLine();
//    Console.WriteLine("------------Tatlılar------------");
//    Console.WriteLine();
//    Console.WriteLine("1-Baklava");
//    Console.WriteLine("2-Sütlaç");
//    Console.WriteLine("3-Kazandibi");
//    Console.WriteLine("4-Künefe");
//    Console.WriteLine("5-Tiramisu");
//    Console.WriteLine("------------Tatlılar------------");
//}

#endregion

#region SWITCH-CASE 

//Console.Write("Lütfen Ay Girişi Yapınız: ");
//int monthNumber = int.Parse(Console.ReadLine());

//switch (monthNumber)
//{
//    case 1:
//        Console.Write("Ocak");
//        break;
//    case 2:
//        Console.Write("Şubat");
//        break;
//    case 3:
//        Console.Write("Mart");
//        break;
//    case 4:
//        Console.Write("Nisan");
//        break;
//    case 5:
//        Console.Write("Mayıs");
//        break;
//    case 6:
//        Console.Write("Haziran");
//        break;
//    case 7:
//        Console.Write("Temmuz");
//        break;
//    case 8:
//        Console.Write("Ağustos");
//        break;
//    case 9:
//        Console.Write("Eylül");
//        break;
//    case 10:
//        Console.Write("Ekim");
//        break;
//    case 11:
//        Console.Write("Kasım");
//        break;
//    case 12:
//        Console.Write("Aralık");
//        break;
//    default:
//        Console.Write("Geçersiz ay numarası!");
//        break;
//}

#endregion


#region Switch Case Hesap Makinesi

int number1, number2, result;
char symbol;

Console.Write("1. Sayıyı Giriniz: ");
number1 = int.Parse(Console.ReadLine());

Console.Write("2. Sayıyı Giriniz: ");
number2 = int.Parse(Console.ReadLine());

Console.Write("Lütfen yapmak istediğiniz işlemi giriniz (+, -, *, /): ");
symbol = char.Parse(Console.ReadLine());

switch (symbol)
{
    case '+':
        result = number1 + number2;
        Console.WriteLine("Toplam: " + result);
        break;
    case '-':
        result = number1 - number2;
        Console.WriteLine("Fark: " + result);
        break;
    case '*':
        result = number1 * number2;
        Console.WriteLine("Çarpım: " + result);
        break;
    case '/':
        if (number2 != 0)
        {
            result = number1 / number2;
            Console.WriteLine("Bölüm: " + result);
        }
        else
        {
            Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz.");
        }
        break;
    default:
        Console.WriteLine("Geçersiz işlem.");
        break;
}

#endregion




