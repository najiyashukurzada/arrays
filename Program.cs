using System.Text.RegularExpressions;
object[] Users = new object[0];
Console.WriteLine("Register!");
string userName = Console.ReadLine();
Console.Write("username: ");
string name = Console.ReadLine();
Console.Write("name: ");
string surname = Console.ReadLine();
Console.Write("surname: ");
string age = Console.ReadLine();
Console.Write("age: ");
string email = Console.ReadLine(); 
Console.Write("email:");
string password = Console.ReadLine();
Console.Write("password:");
string phoneNumber = Console.ReadLine();
Console.Write("phonenumber:");

Regex regex = new Regex(@"^[A-Z]{1}[a-z]{1,14}$");
Regex regex1 = new Regex(@"^[a-z]\S");
Regex regex2 = new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");
Regex regex3 = new Regex(@"\w");
Regex regex4 = new Regex(@"^\+994\-[0-9]{2}\-[0-9]{3}\-[0-9]{2}\-[0-9]{2}");
Regex regex5 = new Regex(@"\d");

Match regexMatch = regex.Match(name);
Match regexMatch1 = regex1.Match(userName);
Match regexMatch2 = regex2.Match(email);
Match regexMatch3 = regex3.Match(password);
Match regexMatch4 = regex4.Match(phoneNumber);
Match regexMatch5 = regex5.Match(age);

    
Console.WriteLine(regexMatch.Success);
Console.WriteLine(regexMatch1.Success);
Console.WriteLine(regexMatch2.Success);
Console.WriteLine(regexMatch3.Success);
Console.WriteLine(regexMatch4.Success);
Console.WriteLine(regexMatch5.Success);

if (regexMatch.Success && regexMatch1.Success && regexMatch2.Success && regexMatch3.Success && regexMatch4.Success && regexMatch5.Success)
{
    var User = new { username = userName, name = name, surname = surname, age = age, email = email, password = password, phoneNumber = phoneNumber };
    Array.Resize (ref Users, Users.Length + 1);
    Users[Users.Length - 1] = User;
    Console.WriteLine("User created !");

}
else
{
    Console.WriteLine("invalid validation !");
}
