﻿// See https://aka.ms/new-console-template for more information
using LogicDasar;

public class MainLogic
{
    public static void Main()
    {
        Console.WriteLine("Masukan Angka :");
        string? input = Console.ReadLine();
        int n = input == null ? 0 : int.Parse(input);

        Logic02Soal01.CetakData(n);
        Logic02Soal02.CetakData(n);
        Logic02Soal03.CetakData(n);
        Logic02Soal04.CetakData(n);
        Logic02Soal05.CetakData(n);
       // Logic02Soal06.CetakData(n);
       
    }
}
