using System;

class Program
{
    static void Main()
    {
        // Impartirea la zero
        try
        {
            int a = 5;
            int b = 0;
            int c = a / b;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Eroare: impartirea la zero.");
        }

        // Radical din numar negativ
        try
        {
            double d = -1.0;
            double e = Math.Sqrt(d);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Eroare: radical din numar negativ.");
        }

        // Accesarea unui element inexistent al unui tablou
        try
        {
            int[] arr = new int[3];
            int x = arr[5];
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Eroare: accesarea unui element inexistent al unui tablou.");
        }

        // Introducerea unor litere in loc de numere
        try
        {
            int y = int.Parse("abc");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Eroare: introducerea unor litere in loc de numere.");
        }

        // Apelarea unei metode a unui obiect care are referinta nula
        try
        {
            string s = null;
            int len = s.Length;
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Eroare: apelarea unei metode a unui obiect care are referinta nula.");
        }

        // Generarea unei exceptii proprii
        Cantec cantec = new Cantec();
        cantec.Denumire = "My Heart Will Go On";
        cantec.Gen = "Pop";
        cantec.Interpret = "Celine Dion";
        cantec.Durata = -5.0;
        cantec.AutorVersuri = "Will Jennings";
        cantec.AutorMuzica = "James Horner";
        cantec.An = 1997;

        try
        {
            cantec.Validare();
        }
        catch (DurataInvalidaException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (AnInvalidException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}

class DurataInvalidaException : Exception
{
    public DurataInvalidaException(string message) : base(message)
    {
    }
}

class AnInvalidException : Exception
{
    public AnInvalidException(string message) : base(message)
    {
    }
}


public class Cantec
{
    private String _denumire;
    private String _gen;
    private String _interpret;
    private Double _durata;
    private String _autorVersuri;
    private String _autorMuzica;
    private int _an;

    //constructor implicit
    public Cantec(){}

    // constructor de copiere
    public Cantec(Cantec cantec)
    {
        this._denumire = cantec._denumire;
        this._gen = cantec._gen;
        this._interpret = cantec._interpret;
        this._durata = cantec._durata;
        this._autorVersuri = cantec._autorVersuri;
        this._autorMuzica = cantec._autorMuzica;
        this._an = cantec._an;
    }

    //constructor cu toti parametri
    public Cantec(String denumire, String gen, String interpret, Double durata, String autorVersuri, String autorMuzica, int an)
    {
        this._denumire = denumire;
        this._gen = gen;
        this._interpret = interpret;
        this._durata = durata;
        this._autorVersuri = autorVersuri;
        this._autorMuzica = autorMuzica;
        this._an = an;
    }

    // constrcutor cu cativa parametri
    public Cantec(string denumire, string gen, string interpret)
    {
        this._denumire = denumire;
        this._gen = gen;
        this._interpret = interpret;
    }

    public string Denumire {
        get { return _denumire; }
        set { _denumire = value; }
    }

    public string Gen {
        get { return _gen; }
        set { _gen = value; }
    }

    public string Interpret {
        get { return _interpret; }
        set { _interpret= value; }
    }

    public Double Durata {
        get { return _durata; }
        set { _durata = value; }
    }

    public string AutorVersuri {
        get { return _autorVersuri; }
        set { _autorVersuri = value; }
    }

    public string AutorMuzica {
        get { return _autorMuzica; }
        set { _autorMuzica = value; }
    }

    public int An{
        get {return _an;}
        set {_an = value;}
    }

    public static int ConvertSecToMin(int seconds) {
        return seconds / 60;
    }

    public static int ConvertMinToSec(Double minutes) {
        return Convert.ToInt32(minutes * 60);
    }

    public void Validare()
    {
        if (_durata < 0)
        {
            throw new DurataInvalidaException("Eroare: durata nu poate fi negativă.");
        }

        if (_an < 1900 || _an > DateTime.Now.Year)
        {
            throw new AnInvalidException("Eroare: anul trebuie să fie între 1900 și anul curent.");
        }
    }

    public override string ToString() {
        return $"Denumire: {Denumire}, Gen: {Gen}, Interpret: {Interpret}, Durata: {Durata}, Autor Versuri: {AutorVersuri}, Autor Muzica: {AutorMuzica}, An:{An}";
    }
}