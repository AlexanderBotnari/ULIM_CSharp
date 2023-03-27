using System;

public class Program
{
    public static void Main()
    {
        Cantec cantec = new Cantec("Love","Deep House","RouDeep",2.55,"RouDeep","RouDeep",2022);
        CantecShowBussines cantecShowBussines = new CantecShowBussines("Love","Deep House","RouDeep",2.55,"RouDeep","RouDeep",2022,"popular");
        Rap rap = new Rap("Love","Deep House","RouDeep",2.55,"RouDeep","RouDeep",2022,"popular",999);

        Console.WriteLine(cantec);
        Console.WriteLine(cantecShowBussines);
        Console.WriteLine(rap);

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

public class CantecShowBussines : Cantec
{
    private String _popularitate;

    public CantecShowBussines(){}

    public CantecShowBussines(CantecShowBussines cantec):base(cantec)
    {
        this.Denumire = cantec.Denumire;
        this.Gen = cantec.Gen;
        this.Durata = cantec.Durata;
        this.An = cantec.An;
        this.Interpret = cantec.Interpret;
        this.AutorMuzica = cantec.AutorMuzica;
        this.AutorVersuri = cantec.AutorVersuri;
        this._popularitate = cantec._popularitate;
    }

    public CantecShowBussines(String denumire, String gen , String interpret, String popularitate):base(denumire, gen, interpret)
    {
        this._popularitate = popularitate;
    }

    public CantecShowBussines(String denumire, String gen, String interpret, Double durata, String autorVersuri, String autorMuzica, int an, String popularitate)
        :base(denumire, gen, interpret, durata, autorVersuri, autorMuzica, an)
    {
        this._popularitate = popularitate;
    }

    public String Popularitate
    {
        get{return _popularitate;}
        set{_popularitate = value;}
    }

    public override string ToString()
    {
        return base.ToString() + ", Popularitate: "+Popularitate;
    }
}

public class Rap : CantecShowBussines
{
    private int _nrDescarcari;

    public Rap(){}

    public Rap(Rap cantec):base(cantec)
    {
        this.Denumire = cantec.Denumire;
        this.Gen = cantec.Gen;
        this.Durata = cantec.Durata;
        this.An = cantec.An;
        this.Interpret = cantec.Interpret;
        this.AutorMuzica = cantec.AutorMuzica;
        this.AutorVersuri = cantec.AutorVersuri;
        this._nrDescarcari = _nrDescarcari;
        this.Popularitate = Popularitate;
    }

    public Rap(String denumire, String gen , String interpret, String popularitate, int nrDescarcari):base(denumire, gen, interpret, popularitate)
    {
        this._nrDescarcari = nrDescarcari;
    }

    public Rap(String denumire, String gen, String interpret, Double durata, String autorVersuri, String autorMuzica,
        int an, String popularitate, int nrDescarcari):base(denumire, gen, interpret, durata, autorVersuri, autorMuzica, an, popularitate)
    {
        this._nrDescarcari = nrDescarcari;
    }

    public int NrDescarcari
    {
        get{return _nrDescarcari;}
        set{_nrDescarcari = value;}
    }

    public override string ToString()
    {
        return base.ToString()+", Nr. de descarcari: "+NrDescarcari;
    }
}
