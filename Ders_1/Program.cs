
#region Yazdırma Komutları

//Console.WriteLine("Teknoloji Kategorileri");
//Console.WriteLine();
//Console.WriteLine("***************************");
//Console.WriteLine();
//Console.WriteLine("1 Akıllı Telefonlar");
//Console.WriteLine("2 Laptoplar");
//Console.WriteLine("3 Tabletler");
//Console.WriteLine("4 Kulaklıklar");

#endregion

#region Değişkenler (String - Integer)

////STRING

//string customerName, customerSurname;
//string customerPhone, customerEmail;
//string customerDistrict, customerCity;

//customerName = "Sadıkcan";
//customerSurname = "TULUK";
//customerPhone = "+90 555 888 00 99";
//customerEmail = "sadikcantuluk@gmail.com";
//customerDistrict = "Atakum";
//customerCity = "Samsun";

//Console.WriteLine("Müşteri Bilgileri");
//Console.WriteLine();
//Console.WriteLine("----------------------------------");
//Console.WriteLine($"Ad Soyad : {customerName} {customerSurname}");
//Console.WriteLine($"Telefon Numarası : {customerPhone}");
//Console.WriteLine($"Mail Adresi : {customerEmail}");
//Console.WriteLine($"İkametgah Adresi : {customerDistrict}/{customerCity}");
//Console.WriteLine("----------------------------------");

////INTEGER

int hamburgerPrice = 160;
int pizzaPrice = 180;
int cakePrice = 90;
int lemonadePrice = 80;
int waterPrice = 20;

Console.WriteLine("Menü");
Console.WriteLine("----------------------------------");
Console.WriteLine();
Console.WriteLine($"Hamburger............{hamburgerPrice} TL");
Console.WriteLine($"Pizza............{pizzaPrice} TL");
Console.WriteLine($"Kek............{cakePrice} TL");
Console.WriteLine($"Limonata............{lemonadePrice} TL");
Console.WriteLine($"Su............{waterPrice} TL");
Console.WriteLine();
Console.WriteLine("----------------------------------");

int hamburgerCounter = 2;
int pizzaCounter = 1;
int cakeCounter = 3;
int lemonadeCounter = 4;
int waterCounter = 2;

Console.WriteLine("Fiş");
Console.WriteLine("----------------------------------");
Console.WriteLine();
Console.WriteLine($"Hamburger............{hamburgerPrice}TL x {hamburgerCounter} = {hamburgerPrice * hamburgerCounter}");
Console.WriteLine($"Pizza............{pizzaPrice}TL x {pizzaCounter} = {pizzaPrice * pizzaCounter}");
Console.WriteLine($"Kek............{cakePrice}TL x {cakeCounter} = {cakePrice * cakeCounter}");
Console.WriteLine($"Limonata............{lemonadePrice}TL x {lemonadeCounter} = {lemonadePrice * lemonadeCounter}");
Console.WriteLine($"Su............{waterPrice}TL x {waterCounter} = {waterPrice * waterCounter}");
Console.WriteLine();
Console.WriteLine($"                                       Toplam = {(hamburgerPrice * hamburgerCounter)+(pizzaPrice * pizzaCounter)+(cakePrice * cakeCounter) +(lemonadePrice * lemonadeCounter) +(waterPrice * waterCounter)}");
Console.WriteLine("----------------------------------");


#endregion
