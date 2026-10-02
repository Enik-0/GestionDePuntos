namespace LogicaPuntos
{
    public class PuntosJugador
    {

        // Atributos privados

        private string nombreJugador;
        private int puntos;
        private int nivel;

        // Propiedades

        public string NombreJugador
        {
            get
            {
                return nombreJugador;
            }
            set
            {
                nombreJugador = value;
            }
        }

        public int Puntos
        {
            get
            {
                return puntos;
            }
            set
            {
                if (value < 0)
                {
                    puntos = 0; // no se permiten puntos negativos
                }
                else
                {
                    puntos = value;
                }
            }
        }

        public int Nivel
        {
            get
            {
                return nivel;
            }
            set
            {
                if (value < 1)
                {
                    nivel = 1; // el nivel minimo es 1
                }
                else
                {
                    nivel = value;
                }
            }
        }


        // Constructores sobrecargados

        public PuntosJugador()
            : this("Jugador Anonimo", 0, 1)
        {

        }

        public PuntosJugador(string nombreJugador)
            : this(nombreJugador, 0, 1)
        {

        }

        public PuntosJugador(string nombreJugador, int puntos)
            : this(nombreJugador, puntos, 1)
        {
        }

        public PuntosJugador(string nombreJugador, int puntos, int nivel)
        {
            this.nombreJugador = nombreJugador;
            this.nombreJugador = nombreJugador;
            this.Puntos = puntos; 
            this.Nivel = nivel;  
        }

        // Metodos de instancia

        public void AgregarPuntos(int puntos)
        {
            AgregarPuntos(puntos, "Sin motivo", false);
        }

        public void AgregarPuntos(int puntos, string motivo)
        {
            AgregarPuntos(puntos, motivo, false);
        }

        public void AgregarPuntos(int puntos, string motivo, bool bonificacion)
        {
            this.puntos += puntos;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Jugador: {nombreJugador} | Puntos: {puntos} | Nivel: {nivel}");
        }

        // ETAPA 2

        // Sobrecarga de operadores

        public static PuntosJugador operator +(PuntosJugador j1, PuntosJugador j2)
        {
            string nombreNombre = $"{j1.nombreJugador} & {j2.nombreJugador}";
            int nuevosPuntos = j1.puntos + j2.puntos;
            int nuevoNivel = Math.Max(j1.nivel, j2.nivel);

            return new PuntosJugador(nombreNombre, nuevosPuntos, nuevoNivel);
        }

        public static PuntosJugador operator -(PuntosJugador j1, PuntosJugador j2)
        {
            int diferencia = j1.puntos - j2.puntos;
            if(diferencia < 0)
            {
                diferencia = 0;
            }

            return new PuntosJugador($"{j1.nombreJugador} - {j2.nombreJugador}", diferencia, 1);
        }

        public static bool operator ==(PuntosJugador j1, PuntosJugador j2)
        {
            bool sonIguales = false;

            if (j1.puntos == j2.puntos)
            {
                sonIguales = true;
            }

            return sonIguales;
        }

        public static bool operator !=(PuntosJugador j1, PuntosJugador j2)
        {
            bool sonDistintos = !(j1 == j2);
            return sonDistintos;
        }

        public static explicit operator int(PuntosJugador jugador)
        {
            return jugador.puntos;
        }

        public static implicit operator PuntosJugador(int puntos)
        {
            return new PuntosJugador("Jugador anonimo", puntos, 1);
        }
    }
}
