namespace TrianguloPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo();
            t.lado1 = 3;
            t.lado2 = 3;
            t.lado3 = 3;
            t.ConfereTipo(t.IsTriangle());
        }
    }
}