Console.WriteLine("Как тебя зовут?");
string username = Console.ReadLine();
if (username.ToLower() == "миша")
{
    Console.WriteLine("Привет, Мишутка!!!");
}
else
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}