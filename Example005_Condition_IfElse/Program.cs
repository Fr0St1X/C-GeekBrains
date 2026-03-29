Console.Write("Введие имя пользователя: ");
string username = Console.ReadLine()!;

if(username.ToLower() == "юзверь")
{
    Console.WriteLine("Да ладно, видел я и похуже.");
}
else
{
    Console.Write("Ну здорова, ");
    Console.Write(username);
    Console.WriteLine("!");
}