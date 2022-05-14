int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);
int respuesta = 0;
int contador = 0;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine();
Console.WriteLine("**************************************************************************");
Console.WriteLine("*                                                                        *");
Console.WriteLine("*          Saludos humano!, JUGUEMOS UN pequeño JUEGO >:D.....           *");
Console.WriteLine("*                                                                        *");
Console.WriteLine("* Voy a pensar en un número del 1 al 20 y TENDRÁS que adivinarlo....     *");
Console.WriteLine("*                                                                        *");
Console.WriteLine("* ...PORQUE EL PROGRAMA NO SE CERRARÁ HASTA QUE LO HAGAS JEJEJE >:)      *");
Console.WriteLine("*                                                                        *");
Console.WriteLine("**************************************************************************");
Console.WriteLine();
Console.WriteLine("Bueno.... ingresa el numero en el que CREES que estoy pensando");

while (respuesta != numeroSecreto)
{
    contador++;
    respuesta = int.Parse(Console.ReadLine());
    Console.Clear();

    if (respuesta < 1 || respuesta > 20)
    {
        contador--;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
        Console.WriteLine("*******************************************");
        Console.WriteLine("* Mirá, se que a los humanos les cuesta...*");
        Console.WriteLine("*        Poné un número entre 1 y 20      *");
        Console.WriteLine("*******************************************");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Intentá otra vez");

    }
    else if (respuesta > numeroSecreto)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
        Console.WriteLine("*******************************************");
        Console.WriteLine("*           Ojo, casi, pero no.           *");
        Console.WriteLine("*     El número  "+ respuesta+ " es ↑MAYOR↑ al mío     *");
        Console.WriteLine("*******************************************");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Intentá otra vez");
    }
    else if (respuesta < numeroSecreto)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
        Console.WriteLine("*******************************************");
        Console.WriteLine("*           Ojo, casi, pero no.           *");
        Console.WriteLine("*     El número  " + respuesta + " es ↓MENOR↓ al mío      *");
        Console.WriteLine("*******************************************");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Intentá otra vez");
    }
    else if(respuesta == numeroSecreto)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine("*******************************************");
        Console.WriteLine("*          Muy bien! Adivinaste!          *");
        Console.WriteLine("*            El número era "+numeroSecreto+"!"+"             *");
        Console.WriteLine("*******************************************");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Lo hiciste en: "+contador+" intentos.");
    }

}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine();
Console.WriteLine("***************************************************************");
Console.WriteLine("*              Bueno, a mimir porque perdí                    *");
Console.WriteLine("***************************************************************");
Console.ResetColor();