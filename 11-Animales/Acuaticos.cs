using System;

public abstract class Acuaticos: Metazoos
{
    public int NumeroAletas { get; set; }
    public string Color { get; set; }

    public void Nadar()
    {
        Console.WriteLine("Nademos, nadaremos nadaharemos nadaharemos...");
    }
}