Console.WriteLine("Введите ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "руслан")
{
    Console.WriteLine("Здравствуйте, Хозяин");
}
else
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}