public class Program
{
    public static void Main()
    {
        var corpuriGeometrice = new List<CorpGeometric>
        {
            new PiramidaTriunghiulara(4, 5),
            new CubPerfect(3),
            new PiramidaTriunghiulara(2, 7),
            new CubPerfect(2.5),
        };

        foreach (var corp in corpuriGeometrice)
        {
            Console.WriteLine($"{corp.NumeCorp} - Volum: {corp.Volum()}");
        }

    }
}

public interface IVolumCorpGeometric
{
    double Latura { get; set; }
    double Inaltime { get; set; }
    double Volum();
}

public class VolumPiramida : IVolumCorpGeometric
{
    public double Latura { get; set; }
    public double Inaltime { get; set; }

    public double Volum()
    {
        return (1.0 / 3.0) * Latura * Latura * Inaltime;
    }
}

public class VolumCub : IVolumCorpGeometric
{
    public double Latura { get; set; }
    public double Inaltime { get; set; }

    public double Volum()
    {
        return Latura * Latura * Latura;
    }
}

public abstract class CorpGeometric : IVolumCorpGeometric
{
    public string NumeCorp { get; set; }
    public double Latura { get; set; }
    public double Inaltime { get; set; }

    protected CorpGeometric(string numeCorp, double latura, double inaltime)
    {
        NumeCorp = numeCorp;
        Latura = latura;
        Inaltime = inaltime;
    }

    public abstract double Volum();
}

public class PiramidaTriunghiulara : CorpGeometric
{
    public PiramidaTriunghiulara(double latura, double inaltime) : base("Piramida triunghiulara", latura, inaltime)
    {
    }

    public override double Volum()
    {
        return (1.0 / 3.0) * Latura * Latura * Inaltime;
    }
}

public class CubPerfect : CorpGeometric
{
    public CubPerfect(double latura) : base("Cub perfect", latura, latura)
    {
    }

    public override double Volum()
    {
        return Latura * Latura * Latura;
    }
}
