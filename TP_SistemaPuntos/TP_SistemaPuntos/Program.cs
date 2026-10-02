using System;
using LogicaPuntos;

namespace TP_SistemaPuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ETAPA 1

            PuntosJugador j1 = new PuntosJugador();
            PuntosJugador j2 = new PuntosJugador("Ger");
            PuntosJugador j3 = new PuntosJugador("Matias", 100);
            PuntosJugador j4 = new PuntosJugador("Santiago", 200, 3);

            j1.MostrarInformacion();
            j2.MostrarInformacion();
            j3.MostrarInformacion();
            j4.MostrarInformacion();

            Console.WriteLine();

            j1.AgregarPuntos(50);
            j2.AgregarPuntos(50, "Completo el nivel");
            j3.AgregarPuntos(50, "Bonus de evento", true);

            j1.MostrarInformacion();
            j2.MostrarInformacion();
            j3.MostrarInformacion();

            // ETAPA 2
            Console.WriteLine("\nETAPA 2\n");

            PuntosJugador jugador1 = new PuntosJugador("Agustin", 500, 2);
            PuntosJugador jugador2 = new PuntosJugador("German", 300, 1);

            PuntosJugador resultadoSuma = jugador1 + jugador2;
            resultadoSuma.MostrarInformacion();

            PuntosJugador resultadoResta = jugador1 - jugador2;
            resultadoResta.MostrarInformacion();

            if (jugador1 == jugador2)
            {
                Console.WriteLine("Los jugadores tienen la misma cantidad de puntos");
            }

            if (jugador1 != jugador2)
            {
                Console.WriteLine("Los jugadores tienen distinta cantidad de puntos");
            }

            int puntosJugador1 = (int)jugador1;
            Console.WriteLine($"Puntos de jugador1: {puntosJugador1}");

            PuntosJugador jugador3 = 1000;
            jugador3.MostrarInformacion();
        }

        // Preguntas Conceptuales

        // 1. Un constructor es el metodo que se ejecuta al crear un objeto nuevo con "new", y sirve para dejarlo listo para usar

        // 2. Sobrecargar un constructor es crear varias versiones, cada una con distinta cantidad de parametros

        // 3. La ventaja de los constructores en cascada es que solo uno hace el trabajo,
        // y los demas le pasan los datos a ese, evitando repetir codigo

        // 4. this sirve para que un constructor llame a otro constructor de la misma clase

        // 5. Es conveniente evitar repetir codigo porque si hay que corregir algo, se corrige en un solo lugar y no en varios

        // 6. La sobrecarga de metodos es tener varios metodos con el mismo nombre, pero con distinta cantidad o tipo de parámetros

        // 7. C# distingue las versiones de AgregarPuntos() fijandose cuantos parametros le pasamos y de que tipo son

        // 8. Sobrecargar un operador es definir que hace un simbolo como +, -, == cuando se usa entre objetos de nuestra clase

        // 9. Usar jugador1 + jugador2 es mas corto y facil de leer, pero por dentro hace lo mismo que llamar a un metodo

        // 10. Al sumar dos jugadores deberia crearse un jugador nuevo, con los puntos de los dos jugadores sumados

        // 11. Si la resta da negativo, el resultado deberia quedar en 0, porque no tiene sentido un jugador con puntos negativos

        // 12. Se considero que dos jugadores son iguales si tienen la misma cantidad de puntos

        // 13. La conversion explicita hay que pedirla a proposito escribiendo el tipo entre parentesis,
        // la implicita la hace C# solo

        // 14. La conversion a int es explicita porque se puede perder informacion,
        // entonces hay que pedirla a proposito

        // 15. La conversion implicita de int a PuntosJugador permite crear un jugador nuevo escribiendo solo un numero,
        // sin perder datos ni necesitar riesgo

        // 16. Usar conversiones implicitas de mas puede generar conversiones que pasan desapercibidas y confunden

    }
}
