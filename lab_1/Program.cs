using System;

public class Program{
    public static void Main(){
        Console.Write("Introduceti primul numar: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduceti al doilea numar: ");
        int b = Convert.ToInt32(Console.ReadLine());

        while (b != 0){
            int rest = a % b;
            a = b;
            b = rest;
        }
        
        if (a == 1){
            Console.WriteLine("Numerele sunt prime");
        }
        else{
            Console.WriteLine("Numerele nu sunt prime");
        }
    }

}
