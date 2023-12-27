// <copyright file="{filename}" company="heartbit software gmbh, Austria">
// Copyright (c) 2024 All Rights Reserved
// </copyright>
//
// <author>Roland Berktold</author>
//
// <summary>
//  Main entriypoint
// </summary>

using System.Text;

namespace HelloWorld;

class Program
{
    private const int MagicNumber = 9;

    public static int GetMagicNumber() 
    {
        
        return MagicNumber;
    }

    static void Main(string[] args)
    {
        var x = Program.GetMagicNumber();
        Console.WriteLine("Hello, World!" + x + " ddd");

        int y = x++;
        x = RolisMethod(x, y);
    }

    private static int RolisMethod(int x, int y)
    {
        if (y == 10)
        {
            x++;
        }

        var txt = x.ToString();

        return x;
    }

    private static void TestFunc(string message)
    {
        var xxx = message;
        var builder = new StringBuilder(100);
    }
}
