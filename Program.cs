// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();

Console.WriteLine("Enter your surname: ");
string surname = Console.ReadLine();

Console.WriteLine($"Hello {name} {surname}.");

DateTime dateTime = DateTime.Now;
Console.WriteLine(dateTime);

int number = 20;
string number2 = "20";
Console.WriteLine(number + number2.ToString());

string number3 = number2.ToString();

int number4 = Convert.ToInt32(number3);
Console.WriteLine(number4);

string dateTime2 = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(dateTime2);

string dateTime3 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(dateTime3);

string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);
