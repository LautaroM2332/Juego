using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kk
{
    public class Menu
    {
        public string[,] menuPelea = new string[4, 2];
        public string[] pausa = new string[3];
        public int filaActualM = 0;
        public int columnaActualM = 0;

        public Menu() 
        {
            menuPelea[0, 0] = "Atacar";
            menuPelea[0, 1] = "Inventario";
            menuPelea[1, 0] = "Habilidades";
            menuPelea[1, 1] = "Huir";

            pausa[0] = "Personaje";
            pausa[1] = "Inventario";
            pausa[2] = "Habilidades";
            pausa[3] = "Salir del juego";

            
        }
        
        public void mostrarMenu(string[,] menuPelea)
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
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($">{menuPelea[i, i]}");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine($"{menuPelea}");
                        }
                    }
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
