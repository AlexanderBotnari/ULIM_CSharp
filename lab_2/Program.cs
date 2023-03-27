using System;

public class Program {
    public static void Main() {
        int n = 3; // dimensiunea matricei
        int[,] matrix = new int[n, n];

        // inițializare matrice cu valori de intrare
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                Console.Write($"Introduceți valoarea pentru elementul [{i}, {j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // calcul produs elemente nenule din fiecare coloană
        for (int j = 0; j < n; j++) {
            int produs = 1;
            int elementeNenule = 0;

            for (int i = 0; i < n; i++) {
                if (matrix[i, j] != 0) {
                    produs *= matrix[i, j];
                    elementeNenule++;
                }
            }

            Console.WriteLine($"Produsul elementelor nenule din coloana {j} este {produs}. Numărul de elemente nenule este {elementeNenule}.");
        }

        // calcul număr elemente negative de pe diagonala principală
        int nrNegative = 0;

        for (int i = 0; i < n; i++) {
            if (matrix[i, i] < 0) {
                nrNegative++;
            }
        }

        Console.WriteLine($"Numărul de elemente negative de pe diagonala principală este {nrNegative}.");
    }
}