using System;
public abstract class Mamifero: Metazoos 
{
    public int Patas { get; set; }

    public void Caminar()
    {
        Console.WriteLine("Caminando es muy buebo para tu salud"); 
    }

}