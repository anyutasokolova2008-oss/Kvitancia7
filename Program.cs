using System;

class Kvitanция
{
    public int Number;
    public string Date;
    public float Sum;

    public Kvitanция(int number, string date, float sum)
    {
        Number = number;
        Date = date;
        Sum = sum;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Kvitanция kv = new Kvitanция(1, "23.03.2026", 1500.50f);

        Console.WriteLine("Номер: " + kv.Number);
        Console.WriteLine("Дата: " + kv.Date);
        Console.WriteLine("Сумма: " + kv.Sum);
    }
}