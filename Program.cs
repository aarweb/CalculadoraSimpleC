namespace CalculadoraSimple
{
    class Program
    {
        public static double SolicitarNumero()
        {
            double numero = 0;
            bool conversionNumeroCorrecta = false;
            do
            {
                conversionNumeroCorrecta = double.TryParse(Console.ReadLine() ?? "0", out numero);
                if (!conversionNumeroCorrecta)
                    Estilos.Error("Debes introducir un valor de tipo numerico");

            } while (!conversionNumeroCorrecta);

            return numero;
        }


        
        public static void Division()
        {
            double primerNumero = 0, segundoNumero = 0, resultado = 0;
            Console.WriteLine("Escribe el primer numero:");
            Estilos.EtiquetaUsuario();
            primerNumero = SolicitarNumero();
            Console.WriteLine("Escribe el segundo numero");
            Estilos.EtiquetaUsuario();
            segundoNumero = SolicitarNumero();
            resultado = primerNumero / segundoNumero;
            string textoResultado = $"{primerNumero} / {segundoNumero} = {resultado:N2}";
            Estilos.MostrarSolucion(textoResultado);
        }
        public static void Multiplicacion()
        {
            double primerNumero = 0, segundoNumero = 0, resultado = 0;
            Console.WriteLine("Escribe el primer numero:");
            Estilos.EtiquetaUsuario();
            primerNumero = SolicitarNumero();
            Console.WriteLine("Escribe el segundo numero");
            Estilos.EtiquetaUsuario();
            segundoNumero = SolicitarNumero();
            resultado = primerNumero * segundoNumero;
            string textoResultado = $"{primerNumero} * {segundoNumero} = {resultado:N2}";
            Estilos.MostrarSolucion(textoResultado);
        }
        public static void Resta()
        {
            double primerNumero = 0, segundoNumero = 0, resultado = 0;
            Console.WriteLine("Escribe el primer numero:");
            Estilos.EtiquetaUsuario();
            primerNumero = SolicitarNumero();
            Console.WriteLine("Escribe el segundo numero");
            Estilos.EtiquetaUsuario();
            segundoNumero = SolicitarNumero();
            resultado = primerNumero - segundoNumero;
            string textoResultado = $"{primerNumero} - {segundoNumero} = {resultado:N2}";
            Estilos.MostrarSolucion(textoResultado);
        }
        public static void Suma()
        {
            double primerNumero = 0, segundoNumero = 0, resultado = 0;
            Console.WriteLine("Escribe el primer numero:");
            Estilos.EtiquetaUsuario();
            primerNumero = SolicitarNumero();
            Console.WriteLine("Escribe el segundo numero");
            Estilos.EtiquetaUsuario();
            segundoNumero = SolicitarNumero();
            resultado = primerNumero + segundoNumero;
            string textoResultado = $"{primerNumero} + {segundoNumero} = {resultado:N2}";
            Estilos.MostrarSolucion(textoResultado);
        }
        public static void ControlCalculadora(int opcion)
        {
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    Estilos.MostrarOpcion("Suma");
                    Suma();
                    break;
                case 2:
                    Estilos.MostrarOpcion("Resta");
                    Resta();
                    break;
                case 3:
                    Estilos.MostrarOpcion("Multiplicacion");
                    Multiplicacion();
                    break;
                case 4:
                    Estilos.MostrarOpcion("Division");
                    Division();
                    break;
                case 5:
                    Estilos.MostrarOpcion("Salir Del Programa");
                    break;
            }
        }
        public static int Menu()
        {
            int opcion = 0;
            bool conversionNumeroCorrecta = false, esOpcionCorrecta = false;
            do
            {
                Console.WriteLine($"{new string('-', 20)}\n{"Calculadora"}\n{new string('-', 20)}\n[1] Suma\n[2] Resta\n[3] Multiplicacion\n[4] Divison\n[5] Salir Del Programa");
                conversionNumeroCorrecta = int.TryParse(Console.ReadLine() ?? "0", out opcion);
                if (conversionNumeroCorrecta)
                {
                    esOpcionCorrecta = opcion is <= 5 and >= 1;
                    if (!esOpcionCorrecta)
                    {
                        Estilos.Error("Opcion no Valida!");
                    }
                }
                else
                {
                    Estilos.Error("Debes introducir un valor de tipo int");
                }

            } while (!conversionNumeroCorrecta || !esOpcionCorrecta);
            return opcion;
        }
        public static void Main()
        {
            bool salirDelPrograma = false;
            do
            {
                int opcion = Menu();
                ControlCalculadora(opcion);
                salirDelPrograma = opcion == 5;
            } while (!salirDelPrograma);
        }
    }
}