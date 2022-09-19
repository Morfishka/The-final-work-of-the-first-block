Console.WriteLine("Введите текст: ");
string? text = Console.ReadLine();

string StringsLess4Сharacters(string text)
{
    string [] words = text.Split(new char[]{',','!','?',' ',':'},StringSplitOptions.RemoveEmptyEntries);
    Console.Write("Результат: ");
    foreach(string word in words)
    {
        if (word.Length <= 3)
        {
            Console.Write($"{word} ");
        }
    }
    return "";
}

StringsLess4Сharacters(text);