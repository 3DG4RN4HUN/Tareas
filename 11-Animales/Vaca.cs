using System;
public class Vaca: Mamifero
{
    public string DaLeche { get; set; }
    public bool HaceMooo { get; set; }

    public Vaca() // Polimorfismo
    {
        HaceMooo = true;
    }

    public Vaca(bool haceMooo) // Polimorfismo
    {
        HaceMooo = haceMooo;
    }
    public void Mooo()
    {
        Console.WriteLine("Tengo una Vaca lechera que hace MOOO...");

    }

}