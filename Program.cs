using System.Numerics;

internal class Program {
    static BigInteger silnia(int x) {
        int wynik = 1;
        for (int i = 1; i <= x; i++) {
            wynik *= i;
        }
        return wynik;
    }
    private static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        if (n == 0) Console.WriteLine("zle wejscie");
        else {
            int[] wartosci = new int[n];
            for (int i = 0; i < n; i++) {
                wartosci[i] = int.Parse(Console.ReadLine());

            }
            foreach (int x in wartosci) {
                string silniawynik = silnia(x).ToString();
                if (int.Parse(silniawynik) < 10) Console.WriteLine("0" + " " + silniawynik);
                else Console.WriteLine(silniawynik.Remove(silniawynik.Length - 1) + " " + silniawynik[silniawynik.Length - 1]);
            }
        }
    }
}
