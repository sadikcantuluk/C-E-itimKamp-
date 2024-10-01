#region Değişkenler (Double)

////DOUBLE

//double applePrice = 5.5;
//double bananaPrice = 12.5;
//double tomataPrice = 22.5;
//double lemonPrice = 16.5;

//Console.WriteLine("Meyve - Sebze Fiyatları");
//Console.WriteLine("----------------------------------");
//Console.WriteLine();
//Console.WriteLine($"Elma............{applePrice} TL");
//Console.WriteLine($"Muz............{bananaPrice} TL");
//Console.WriteLine($"Domates............{tomataPrice} TL");
//Console.WriteLine($"Limon............{lemonPrice} TL");
//Console.WriteLine();
//Console.WriteLine("----------------------------------");

//double appleGram = 12.345;
//double bananaGram = 4.532;
//double tomatoGram = 5.820;
//double lemonGram = 1.842;

//Console.WriteLine("Fiş");
//Console.WriteLine("----------------------------------");
//Console.WriteLine();
//Console.WriteLine($"Elma............{applePrice}TL x {appleGram}kg = {applePrice * appleGram}");
//Console.WriteLine($"Muz............{bananaPrice}TL x {bananaGram}kg = {bananaPrice * bananaGram}");
//Console.WriteLine($"Domates............{tomataPrice}TL x {tomatoGram}kg = {tomataPrice * tomatoGram}");
//Console.WriteLine($"Limon............{lemonPrice}TL x {lemonGram}kg = {lemonPrice * lemonGram}");
//Console.WriteLine();
//Console.WriteLine($"                                       Toplam = {(applePrice * appleGram) + (bananaPrice * bananaGram) + (tomataPrice * tomatoGram) + (lemonPrice * lemonGram)}");
//Console.WriteLine("----------------------------------");


#endregion

#region Değişkenler (Char)

////CHAR

//char character = '#';
//char harf = 'a';

//Console.WriteLine(character);
//Console.WriteLine(harf);

#endregion

#region Klavyeden Veri Alma (String)

//string passengerName, passengerSurname, passengerCity, passengerAge, passengerIdentityNo;

//Console.WriteLine("CSharp Havayolları");
//Console.WriteLine("-------------------------------");
//Console.WriteLine("");

//Console.Write("Yolcu Adı :");
//passengerName = Console.ReadLine();

//Console.Write("Yolcu Soyadı :");
//passengerSurname = Console.ReadLine();

//Console.Write("Yolcu Yaşı :");
//passengerAge = Console.ReadLine();

//Console.Write("Yolcu TC :");
//passengerIdentityNo = Console.ReadLine();

//Console.Write("Yolcu Şehir :");
//passengerCity = Console.ReadLine();

//Console.WriteLine($"Yolcu Bilgileri : {passengerName} {passengerSurname} {passengerAge} {passengerIdentityNo} {passengerCity}");

#endregion

#region Klavyeden Veri Alma (Integer)

//int shoesPrice, mousePrice, computerPrice, phonePrice, keyboardPrice;

//shoesPrice = 500;
//mousePrice = 2400;
//computerPrice = 20000;
//phonePrice = 18600;
//keyboardPrice = 2300;

//Console.WriteLine("Alışveris Tutarı");
//Console.WriteLine("-------------------------------");
//Console.WriteLine("");

//int shoesCounter, mouseCounter, computerCounter, phoneCounter, keyboardCounter;

//Console.Write("Ayakkabı Adedi :");
//shoesCounter = int.Parse(Console.ReadLine());

//Console.Write("Mouse Adedi :");
//mouseCounter = int.Parse(Console.ReadLine());

//Console.Write("Bilgisayar Adedi :");
//computerCounter = int.Parse(Console.ReadLine());

//Console.Write("Telefon Adedi :");
//phoneCounter = int.Parse(Console.ReadLine());

//Console.Write("Klavye Adedi :");
//keyboardCounter = int.Parse(Console.ReadLine());

//Console.WriteLine($"Fatura Tutarı : {(mousePrice * mouseCounter) + (shoesPrice * shoesCounter) + (computerCounter * computerPrice) + (phoneCounter * phonePrice) + (keyboardCounter * keyboardPrice)}");

#endregion

#region Klavyeden Veri Alma (Double)

//double exam1, exam2, exam3, result;

//Console.Write("Sınav1 notu :");
//exam1 = double.Parse(Console.ReadLine());

//Console.Write("Sınav2 notu :");
//exam2 = double.Parse(Console.ReadLine());

//Console.Write("Sınav3 notu :");
//exam3 = double.Parse(Console.ReadLine());

//Console.WriteLine($"Ortalama : {(exam1 + exam2 + exam3) / 3}");

#endregion

#region Klavyeden Veri Alma (Char)

char gender;

Console.Write("Cinsiyeti gir :");
gender = char.Parse(Console.ReadLine());

Console.WriteLine($"Cinsiyet : {gender}");

#endregion