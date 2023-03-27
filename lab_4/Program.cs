using System;

public class Program
{
    public static void Main()
    {

        //utilizare indexator
        Playlist playlist = new Playlist(5);
        Cantec cantec = new Cantec();
        cantec.Denumire = "Thriller";
        playlist[0] = cantec;
        Console.WriteLine(playlist[0]);

        //utilizare conversie speciala
        Cantec cantec1 = new Cantec();
        cantec1.Durata = 3.5;
        double durataDouble = cantec1.Durata;
        Durata durata = (Durata)durataDouble;
        Console.WriteLine(durata);

        Cantec c1 = new Cantec("Numb", "Rock", "Linkin Park", 3.07, "Chester Bennington", "Mike Shinoda", 2003);
        Cantec c2 = new Cantec("Numb", "Rock", "Linkin Park", 3.07, "Chester Bennington", "Mike Shinoda", 2003);
        Cantec c3 = new Cantec("In the End", "Rock", "Linkin Park", 3.36, "Chester Bennington", "Mike Shinoda", 2001);

        if (c1 == c2)
        {
            Console.WriteLine("Cantecele c1 si c2 sunt egale.");
        }

        if (c1 != c3)
        {
            Console.WriteLine("Cantecele c1 si c3 sunt diferite.");
        }

        Cantec c4 = new Cantec();
        Cantec c5 = new Cantec("Numb", "Rock", "Linkin Park", 3.07, "Chester Bennington", "Mike Shinoda", 2003);

        if (c4)
        {
            Console.WriteLine("Obiectul c4 are valoare implicita false.");
        }
        else
        {
            Console.WriteLine("Obiectul c4 are valoare implicta true.");
        }

        if (c5)
        {
            Console.WriteLine("Obiectul c5 are valoare implicita false.");
        }
        else
        {
            Console.WriteLine("Obiectul c5 are valoare implicta true.");
        }

        Cantec c6 = new Cantec("Numb", "Rock", "Linkin Park", 3.07, "Chester Bennington", "Mike Shinoda", 2003);
        Cantec c7 = new Cantec("In the End", "Rock", "Linkin Park", 3.36, "Chester Bennington", "Mike Shinoda", 2001);

        if (c6 && c7)
        {
            Console.WriteLine("Ambele cantece sunt ale trupei Linkin Park.");
        }
        else
        {
            Console.WriteLine("Unul dintre cantece nu este al trupei Linkin Park.");
        }

        Cantec c8 = new Cantec("Numb", "Rock", "Linkin Park", 3.07, "Chester Bennington", "Mike Shinoda", 2003);
        Cantec c10 = c8 + 3; // adunam cele doua cantece
        Console.WriteLine("Durata totala a celor doua cantece este " + c10.Durata);

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

    public override string ToString() {
        return $"Denumire: {Denumire}, Gen: {Gen}, Interpret: {Interpret}, Durata: {Durata}, Autor Versuri: {AutorVersuri}, Autor Muzica: {AutorMuzica}, An:{An}";
    }

    // supraincarcarea operatorilor
    public static bool operator ==(Cantec c1, Cantec c2)
    {
        if (ReferenceEquals(c1, c2))
        {
            return true;
        }

        if (c1 is null || c2 is null)
        {
            return false;
        }

        return c1._denumire == c2._denumire
            && c1._gen == c2._gen
            && c1._interpret == c2._interpret
            && c1._durata == c2._durata
            && c1._autorVersuri == c2._autorVersuri
            && c1._autorMuzica == c2._autorMuzica
            && c1._an == c2._an;
    }

    public static bool operator !=(Cantec c1, Cantec c2)
    {
        return !(c1 == c2);
    }

    public static bool operator true(Cantec c)
    {
        return c._denumire != null
            || c._gen != null
            || c._interpret != null
            || c._durata != 0
            || c._autorVersuri != null
            || c._autorMuzica != null
            || c._an != 0;
    }

    public static bool operator false(Cantec c)
    {
        return c._denumire == null
            || c._gen == null
            || c._interpret == null
            || c._durata == 0
            || c._autorVersuri == null
            || c._autorMuzica == null
            || c._an == 0;
    }

    public static Cantec operator +(Cantec c, int valoare)
    {
        Cantec result = new Cantec();
        result._denumire = c._denumire;
        result._gen = c._gen;
        result._interpret = c._interpret;
        result._durata = c._durata + valoare;
        result._autorVersuri = c._autorVersuri;
        result._autorMuzica = c._autorMuzica;
        result._an = c._an;
        return result;
    }

    public static Cantec operator &(Cantec c1, Cantec c2)
    {
        if (c1 == null && c2 == null)
        {
            return null;
        }
        else if (c1 == null)
        {
            return c2;
        }
        else if (c2 == null)
        {
            return c1;
        }
        else if (c1.Equals(c2))
        {
            return c1;
        }
        else
        {
            Cantec c = new Cantec();
            c.Denumire = c1.Denumire + " & " + c2.Denumire;
            c.Gen = c1.Gen;
            c.Interpret = c1.Interpret;
            c.AutorVersuri = c1.AutorVersuri;
            c.AutorMuzica = c1.AutorMuzica;
            c.An = c1.An;
            c.Durata = c1.Durata + c2.Durata;
            return c;
        }
    }

    public static Cantec operator |(Cantec c1, Cantec c2)
    {
        Cantec c = new Cantec();
        c._denumire = c1._denumire;
        c._gen = c2._gen;
        c._interpret = c1._interpret;
        c._durata = c1._durata + c2._durata;
        c._autorVersuri = c2._autorVersuri;
        c._autorMuzica = c1._autorMuzica;
        c._an = Math.Min(c1._an, c2._an);
        return c;
    }

}

//indexator
public class Playlist
{
    private Cantec[] _cantece;

    public Playlist(int numarCantece)
    {
        _cantece = new Cantec[numarCantece];
    }

    public Cantec this[int index]
    {
        get { return _cantece[index]; }
        set { _cantece[index] = value; }
    }
}

//conversie speciala
public class Durata
{
    private double _minute;

    public Durata(double minute)
    {
        _minute = minute;
    }

    public static implicit operator double(Durata d)
    {
        return d._minute;
    }

    public static explicit operator Durata(double minute)
    {
        return new Durata(minute);
    }
}
