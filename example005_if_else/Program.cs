Console.Write("введите ваше имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "лиза")
{
   Console.WriteLine("ура, это же лиза!"); 
}
else
{
    Console.Write("привет, ");
    Console.WriteLine(username);
}