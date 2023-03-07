Console.WriteLine("Введите имя пользователя:");
string username = Console.ReadLine();

if (username.ToLower() =="сашка")
{
    Console.WriteLine("Ура, это же Сашка!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}