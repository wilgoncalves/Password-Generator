using PasswordGenerator.Services;


Console.WriteLine("Welcome to PasswordGenerator. Let's begin!");
Console.WriteLine();

Console.Write("What's the password length? ");
int length = int.Parse(Console.ReadLine()!);

Console.Write("Password must contain uppercase letters? (Y/N) ");
bool upperCase = (Console.ReadLine()!).ToLower() == "y";

Console.Write("Password must contain lowercase letters? (Y/N) ");
bool lowerCase = (Console.ReadLine()!).ToLower() == "y";

Console.Write("Password must contain numbers? (Y/N) ");
bool numbers = (Console.ReadLine()!).ToLower() == "y";

Console.Write("Password must contain special chars? (Y/N) ");
bool specialChars = (Console.ReadLine()!).ToLower() == "y";

PasswordGeneratorService generatorService = new PasswordGeneratorService();
string password = generatorService.GeneratePassword(length, upperCase, lowerCase, numbers, specialChars);

Console.WriteLine();
Console.WriteLine(password);

