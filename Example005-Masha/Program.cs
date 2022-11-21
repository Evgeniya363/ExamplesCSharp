//Маша? а кто? 
Console.Write("Представьтесь: ");
string username = Console.ReadLine();
if (username.ToLower()=="маша")
{
  Console.Write("Ура! ");
  Console.WriteLine(username);
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(username);
}