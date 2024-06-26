class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int, string> MyDictionary = new();
        MyDictionary.Add(01, "Adana");
        MyDictionary.Add(06, "Ankara");
        MyDictionary.Add(34, "İstanbul");
        MyDictionary.Add(42, "Konya");

        foreach (var (key, value) in MyDictionary)
        {
            Console.WriteLine($"{key} şehri : {value}");
        }
    }
}