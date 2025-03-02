using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // 1. For döngüsü ile sayının rakamlarının toplamını bulan algoritma
        int number = 12345;
        int sum = 0;
        for (int n = number; n != 0; n /= 10)
        {
            sum += n % 10;
        }
        Console.WriteLine($"Rakamların toplamı: {sum}");

        // 2. While döngüsü ile kullanıcıdan belirli şartlara uyan bir değer alan algoritma
        int userInput;
        do
        {
            Console.Write("10 ile 100 arasında bir sayı girin: ");
            userInput = int.Parse(Console.ReadLine());
        } while (userInput < 10 || userInput > 100);
        Console.WriteLine($"Girdiğiniz sayı: {userInput}");

        // 3. Foreach döngüsü ile kişilerin yaş kategorisini belirleyen algoritma
        int[] ages = { 5, 13, 25, 70 };
        foreach (int age in ages)
        {
            if (age >= 0 && age <= 12)
                Console.WriteLine($"{age}: Çocuk");
            else if (age >= 13 && age <= 19)
                Console.WriteLine($"{age}: Genç");
            else if (age >= 20 && age <= 64)
                Console.WriteLine($"{age}: Yetişkin");
            else if (age >= 65)
                Console.WriteLine($"{age}: Yaşlı");
        }

        // 4. Bir dizide tekrar eden elemanları bulan algoritma
        int[] numbers = { 1, 2, 3, 4, 5, 3, 2, 1 };
        var duplicates = numbers.GroupBy(n => n).Where(g => g.Count() > 1).Select(g => g.Key);
        Console.WriteLine("Tekrar eden elemanlar: " + string.Join(", ", duplicates));

        // 5. Bir dizide en uzun ve en kısa kelimeyi bulan algoritma
        string[] words = { "elma", "muz", "ananas", "kavun" };
        string longestWord = words.OrderByDescending(w => w.Length).First();
        string shortestWord = words.OrderBy(w => w.Length).First();
        Console.WriteLine($"En uzun kelime: {longestWord}");
        Console.WriteLine($"En kısa kelime: {shortestWord}");

        // 6. Kullanıcının girdiği bir cümleyi diziye kaydeden ve alfabetik olarak sıralayan algoritma
        Console.Write("Bir cümle girin: ");
        string sentence = Console.ReadLine();
        string[] wordsArray = sentence.Split(' ').OrderBy(w => w).ToArray();
        Console.WriteLine("Alfabetik sıralama: " + string.Join(", ", wordsArray));

        // 7. Bir string dizisinin boyutunu dinamik olarak genişleten algoritma
        List<string> dynamicList = new List<string> { "elma", "armut" };
        dynamicList.Add("muz");
        Console.WriteLine("Dinamik liste: " + string.Join(", ", dynamicList));

        // 8. Kullanıcının girdiği kelimeleri listeye kaydeden ve tersten yazdıran algoritma
        List<string> userWords = new List<string>();
        string input;
        do
        {
            Console.Write("Kelime girin (çıkmak için 'q' tuşuna basın): ");
            input = Console.ReadLine();
            if (input != "q")
            {
                userWords.Add(input);
            }
        } while (input != "q");
        userWords.Reverse();
        Console.WriteLine("Tersten kelimeler: " + string.Join(", ", userWords));

        // 9. Kullanıcıdan rastgele sayılar alıp listeye ekleyen, bu sayıların ortalamasını alan ve bu sayıları küçükten büyüğe sıralayan algoritma
        List<int> numbersList = new List<int>();
        string numberInput;
        do
        {
            Console.Write("Sayı girin (bitirmek için 'q' tuşuna basın): ");
            numberInput = Console.ReadLine();
            if (numberInput != "q")
            {
                numbersList.Add(int.Parse(numberInput));
            }
        } while (numberInput != "q");
        double average = numbersList.Average();
        numbersList.Sort();
        Console.WriteLine($"Ortalama: {average}");
        Console.WriteLine("Küçükten büyüğe sıralama: " + string.Join(", ", numbersList));

        // 10. Bir sayı listesinde 10’dan küçük olanları silen algoritma
        List<int> numberList = new List<int> { 5, 10, 15, 20, 3, 8, 25 };
        numberList.RemoveAll(n => n < 10);
        Console.WriteLine("10'dan küçük olmayan sayılar: " + string.Join(", ", numberList));

        // 11. Öğrenci notlarının olduğu bir listede 50’nin altındaki tüm notları 50 olarak güncelleyen algoritma
        List<int> studentGrades = new List<int> { 45, 80, 65, 30, 90 };
        for (int i = 0; i < studentGrades.Count; i++)
        {
            if (studentGrades[i] < 50)
            {
                studentGrades[i] = 50;
            }
        }
        Console.WriteLine("Güncellenmiş notlar: " + string.Join(", ", studentGrades));
    }
}
