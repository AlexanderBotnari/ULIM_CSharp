public class Program
{
    public static void Main()
    {
        Cantec cantec = new Cantec("Love","Deep House","RouDeep",2.55,"RouDeep","RouDeep",2022);

        Cantec cantec1 = new Cantec("Hey-Ho","Romanesc","Zdob si Zdub",3.90,"Roman","Roman",2022);

        Cantec cantec2 = new Cantec("Summer Beach", "House", "Babilon",5.59,"John","Fish",2020);

        Cantec cantec3 = new Cantec("Crystals","Techno","Alessia",3.50,"Alessia Mundfish", "Alessia Mundfish", 2023);

        List<Cantec> listaCantece = new List<Cantec>();
        // adaugam cantecele in lista
        listaCantece.Add(cantec);
        listaCantece.Add(cantec1);
        listaCantece.Add(cantec2);
        listaCantece.Add(cantec3);

        listaCantece.Sort((cantecFirst, cantecSecond) => cantecFirst.Denumire.CompareTo(cantecSecond.Denumire));

        Console.WriteLine("Lista sortata dupa denumire: ");
        foreach (var item in listaCantece)
        {
            Console.WriteLine(item);
        }

        List<Cantec> canteceLungi = listaCantece.FindAll(cantec => cantec.Durata > 5.0);
        Console.WriteLine();
        Console.WriteLine("Gasire cintece mai lungi de 5 minute: ");
        foreach (var item2 in canteceLungi)
        {
            Console.WriteLine(item2);
        }

        double durataTotala = listaCantece.Sum(cantec => cantec.Durata);
        Console.WriteLine();
        Console.WriteLine($"Durata totala a cantecelor este {durataTotala}");

        bool existaCantec = listaCantece.Exists(cantec => cantec.Gen == "Rock" && cantec.An >= 2000);
        Console.WriteLine();
        Console.WriteLine("In lista exista cantec de genul rock mai nou de anul 2000?");
        Console.WriteLine("Raspuns : "+existaCantec);


        List<string> numeInterpreti = listaCantece.Select(cantec => cantec.Interpret).ToList();
        Console.WriteLine();
        Console.WriteLine("Selectarea numelor interpretilor");
        foreach (var nume in numeInterpreti)
        {
            Console.WriteLine(nume);
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
