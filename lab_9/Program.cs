using System;
using System.Collections;

public class Program
{
    public static void Main()
    {
        List<Cantec> listaCantece = new List<Cantec>();
        ArrayList arrayListCantece = new ArrayList();
        LinkedList<Cantec> linkedListCantece = new LinkedList<Cantec>();

        // adăugăm cinci cântece în fiecare dintre cele trei colecții
        Cantec c1 = new Cantec() { Denumire = "Bohemian Rhapsody", Interpret = "Queen", Durata = 6.07, Gen = "Rock", An = 1975 };
        Cantec c2 = new Cantec() { Denumire = "Stairway to Heaven", Interpret = "Led Zeppelin", Durata = 8.03, Gen = "Rock", An = 1971 };
        Cantec c3 = new Cantec() { Denumire = "Smells Like Teen Spirit", Interpret = "Nirvana", Durata = 5.01, Gen = "Grunge", An = 1991 };
        Cantec c4 = new Cantec() { Denumire = "Billie Jean", Interpret = "Michael Jackson", Durata = 4.54, Gen = "Pop", An = 1983 };
        Cantec c5 = new Cantec() { Denumire = "Hotel California", Interpret = "Eagles", Durata = 6.31, Gen = "Rock", An = 1977 };

        listaCantece.Add(c1);
        listaCantece.Add(c2);
        listaCantece.Add(c3);
        listaCantece.Add(c4);
        listaCantece.Add(c5);

        arrayListCantece.Add(c1);
        arrayListCantece.Add(c2);
        arrayListCantece.Add(c3);
        arrayListCantece.Add(c4);
        arrayListCantece.Add(c5);

        linkedListCantece.AddLast(c1);
        linkedListCantece.AddLast(c2);
        linkedListCantece.AddLast(c3);
        linkedListCantece.AddLast(c4);
        linkedListCantece.AddLast(c5);

        listaCantece.Sort((c1, c2) => c1.Denumire.CompareTo(c2.Denumire));

        foreach (Cantec c in listaCantece)
        {
            Console.WriteLine($"Denumire: {c.Denumire}, Interpret: {c.Interpret}, Gen: {c.Gen}, Durata: {c.Durata}, An: {c.An}");
        }

        Dictionary<string, Cantec> dictionarCantece = new Dictionary<string, Cantec>();

        dictionarCantece.Add(c1.Denumire, c1);
        dictionarCantece.Add(c2.Denumire, c2);
        dictionarCantece.Add(c3.Denumire, c3);
        dictionarCantece.Add(c4.Denumire, c4);
        dictionarCantece.Add(c5.Denumire, c5);

        Cantec cd = dictionarCantece["Bohemian Rhapsody"];
        Console.WriteLine($"Denumire: {cd.Denumire}, Interpret: {cd.Interpret}, Gen: {cd.Gen}, Durata: {cd.Durata}, An: {cd.An}");

        foreach (KeyValuePair<string, Cantec> kvp in dictionarCantece)
        {
            Console.WriteLine($"Denumire: {kvp.Key}, Interpret: {kvp.Value.Interpret}, Gen: {kvp.Value.Gen}, Durata: {kvp.Value.Durata}, An: {kvp.Value.An}");
        }

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
}
