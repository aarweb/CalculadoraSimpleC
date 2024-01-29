namespace CalculadoraSimple
{
    class Estilos
    {
        public static void MostrarSolucion(string solucion)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{solucion}");
            Console.ResetColor();
        }
        public static void Error(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ResetColor();
        }
        public static void EtiquetaUsuario()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Usuario> ");
            Console.ResetColor();
        }
        public static void MostrarOpcion(string opcion)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Has selecionado [{opcion}]");
            Console.ResetColor();
        }
    }
}