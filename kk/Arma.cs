using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndJuego
{
    public class Arma
    {
        public Random random = new Random();
        public string nombre;
        public int danoA;
        public string descripcion;
        public char calidadArma;

        public Arma()
        {
        }

        public virtual void MostrarDescripción ()
        {
            Console.WriteLine("No se sabe mucho de este arma");
        }

    }

    public class EspadaMadera:Arma
    {
        public EspadaMadera()
        {
            nombre = "Espada de madera";
            danoA = random.Next(5, 11);
            descripcion = "Una espadad de madera simple..... no se ve muy fuerte";
            calidadArma = 'C';
        }
    }

    public class Lanza : Arma
    {
        public Lanza() 
        {
            nombre = "Lanza";
            danoA = 15;
            descripcion = "Lanza encontrada en el cadaver de un enemigo.... parece muy filosa..";
            calidadArma = 'B';
        }
    }
}
