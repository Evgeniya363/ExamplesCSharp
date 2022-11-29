string oldText = "Здесь в методе Main в стеке выделяется память для объекта state1. Далее в стеке создается ссылка для объекта country1 (Country country1), а с помощью вызова конструктора с ключевым словом new выделяется место в хипе(new Country()). Ссылка в стеке для объекта country1 будет представлять адрес на место в хипе, по которому размещен данный объект..";

string Replace(string oldText, char oldChar, char newChar)
{
  string newText = "";
  for (int i=0; i<oldText.Length; i++)
  {
    newText+=(oldText[i]==oldChar)?newChar:oldText[i];
  }
  return newText;
}
Console.WriteLine(Replace(oldText, 'с', 'С'));
Console.WriteLine(Replace(oldText, 'к', 'К'));
Console.WriteLine(Replace(oldText, '(', '{'));