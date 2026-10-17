internal class PolimorfismoExemplo
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public double Somar(double a, double b)
    {
        return a + b;
    }

    // Inválido
    //public int Somar(int a, int b)
    //{
    //    return a - b;
    //}

    public int Somar(int a, int b, int c)
    {
        Console.WriteLine("Somei 3 numeros!");
        return a + b + c;
    }
}






