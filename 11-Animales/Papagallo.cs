using System;

public class PapaGallo: Avioticos
{
    public string Orden { get; set; }
    public string Familia { get; set; }

    public void Parlotean()
    {
        Console.WriteLine("Imitan sonidos");
    }

    public void Plumaje()
    {
        DescribirPlumaje();
    }

    private void DescribirPlumaje()
    {
        Console.WriteLine("Colorido en Verde, Rojo, Amarillo algunos Alvinos");
    }

}