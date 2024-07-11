using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndJuego
{
    public class Enemigo
    {
        public string nombre;
        public int vida = 30;
        public string clase;
        public Arma arma;

        public Enemigo(string nombre, string clase, Arma arma)
        {
            this.nombre = nombre;
            this.clase = clase;
            this.arma = arma;
        }
        
        public void hacerDano() 
        {
            
        }
    }
}
