//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Ведите пятизначное число");
string? number = Console.ReadLine();
bool palindrom(string s)
{
    for (int i = 0; i < s.Length / 2; i++)
 
        if (s[i] != s[s.Length - i - 1])
            return false;
    return true;
}
Console.WriteLine(palindrom(number));