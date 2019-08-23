using System;

public class Class1
{
	public Class1()
	{
        static void Main(string[] args)
        {
            char a = 'a';
            char b = '8';
            char c = 'L';
            char d = '.';
            char e = '|';
            char f = ' ';
            Console.WriteLine(char.IsLetter(a));
            Console.WriteLine(char.IsDigit(b));
            Console.WriteLine(char.IsLetterOrDigit(c));
            Console.WriteLine(char.IsLower(a));
            Console.WriteLine(char.IsUpper(c));
            Console.WriteLine(char.IsPunctuation(d));
            Console.WriteLine(char.IsSeparator(e));
            Console.WriteLine(char.IsWhiteSpace(f));
        }
        

    }
}
