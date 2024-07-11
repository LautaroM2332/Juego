using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndJuego
{
    public class Menu
    {
        public string[,] menuPelea;
        public string[] pausa = new string[4];
        public int filaActualM = 0;
        public int columnaActualM = 0;

        public Personaje personaje;
        public Habilidades habilidades;

        public Menu() 
        {
            menuPelea = new string[,]
            {

                { "Atacar" , "Inventario" },
                { "Habilidades" , "Huir" }
            };

            pausa[0] = "Personaje";
            pausa[1] = "Inventario";
            pausa[2] = "Habilidades";
            pausa[3] = "Salir del juego";

            
        }
        
        public void mostrarMenu()
        {
            int filas = menuPelea.GetLength(0);
            int columnas = menuPelea.GetLength(1);
            ConsoleKeyInfo tecla;  

            do
            {
                Console.Clear();
                for (int i = 0; i < filas; i++)
                {
                    for(int j = 0; j < columnas; j++)
                    {
                        if (i == filaActualM && j == columnaActualM)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write($">{menuPelea[i,j]}");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write($"{menuPelea[i, j]}");
                        }
                        Console.Write("          ");
                    }
                    Console.WriteLine();
                }

                tecla = Console.ReadKey(true);

                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    filaActualM--;
                    if (filaActualM < 0)
                    {
                        filaActualM = filas - 1;
                    }

                }
                else if (tecla.Key == ConsoleKey.DownArrow)
                {
                    filaActualM++;
                    if (filaActualM >= filas)
                    {
                        filaActualM = 0;
                    }
                }
                else if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    columnaActualM--;
                    if(columnaActualM < 0)
                    {
                        columnaActualM = columnas - 1;
                    }
                }
                else if (tecla.Key == ConsoleKey.RightArrow)
                {
                    columnaActualM++;
                    if(columnaActualM >= columnas)
                    {
                        columnaActualM = 0;
                    }
                }

            } while (tecla.Key != ConsoleKey.Enter);
        }

        public void Pausa()
        {
            int indice = 0;

            
        }
    }
}
