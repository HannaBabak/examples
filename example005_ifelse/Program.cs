Console.Write("Введите имя пользователя ");
string username = Console.ReadLine()!;

if(username.ToLower() == "Hanna")
{
    Console.WriteLine("hey, it's Ann!");
}
else
{    
    Console.Write("Привет, ");
    Console.WriteLine(username);
}