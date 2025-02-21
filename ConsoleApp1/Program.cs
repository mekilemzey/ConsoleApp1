Console.WriteLine("güçlü şifre belirleme");
Console.Write("şifre giriniz ");
string sifre = Console.ReadLine();

if (sifre.Length < 8)
{
    Console.WriteLine(" Şifre 8 karakterden az olmayacak");
}
else if (!(sifre.Contains("@") || sifre.Contains("#") || sifre.Contains("$") || sifre.Contains("%")))
{
    Console.WriteLine(" Şifre de özel karakterlerin olması gerekiyor (@, #, $, %)");
}
else
{
    bool buyukHarf = false;

    for (int i = 0; i < sifre.Length; i++)
    {
        if (char.IsUpper(sifre[i]))
        {
            buyukHarf = true;
            break;
        }
    }

    if (!buyukHarf)
    {
        Console.WriteLine(" Şifrenizde büyük harf olmalı");
    }
    else
    {
        Console.WriteLine("güçlü şifre oluşturuldu");
    }
}
