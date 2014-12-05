using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahorcado
{
    public class ahorcado
    {
        string[] Letrero = {
                                                                           
           "                                                                                                                                                            \n",
           "                 .8.          8 8888        8     ,o888888o.     8 888888888o.      ,o888888o.           .8.          8 888888888o.          ,o888888o.     \n",
           "                .888.         8 8888        8  . 8888     `88.   8 8888    `88.    8888     `88.        .888.         8 8888    `^888.    . 8888     `88.   \n",
           "               :88888.        8 8888        8 ,8 8888       `8b  8 8888     `88 ,8 8888       `8.      :88888.        8 8888        `88. ,8 8888       `8b  \n",
           "              . `88888.       8 8888        8 88 8888        `8b 8 8888     ,88 88 8888               . `88888.       8 8888         `88 88 8888        `8b \n",
           "             .8. `88888.      8 8888        8 88 8888         88 8 8888.   ,88' 88 8888              .8. `88888.      8 8888          88 88 8888         88 \n",
           "            .8`8. `88888.     8 8888        8 88 8888         88 8 888888888P'  88 8888             .8`8. `88888.     8 8888          88 88 8888         88 \n",
           "           .8' `8. `88888.    8 8888888888888 88 8888        ,8P 8 8888`8b      88 8888            .8' `8. `88888.    8 8888         ,88 88 8888        ,8P \n",
           "          .8'   `8. `88888.   8 8888        8 `8 8888       ,8P  8 8888 `8b.    `8 8888       .8' .8'   `8. `88888.   8 8888        ,88' `8 8888       ,8P  \n",
           "         .888888888. `88888.  8 8888        8  ` 8888     ,88'   8 8888   `8b.     8888     ,88' .888888888. `88888.  8 8888    ,o88P'    ` 8888     ,88'   \n",
           "        .8'       `8. `88888. 8 8888        8     `8888888P'     8 8888     `88.    `8888888P'  .8'       `8. `88888. 8 888888888P'          `8888888P'     \n",
                           }; 
       
        public static void Main()
        {
            ahorcado titulo = new ahorcado();
            titulo.MostrarLetrero();

            juego();
            Console.ReadKey();


        }

        private static void juego()
        {
           
            string[] pal = new string[20];
            pal[1] = "hola";
            pal[2] = "ahorcado";
            pal[3] = " habitacion";
            pal[4] = "ideologia";
            int i = 0, na = 0, t1 = 0;
            string pal2 = "", pal3 = "";
            Random objeto = new Random();
            na = objeto.Next(1, 4);
            pal2 = pal[na];
            t1 = pal2.Length;
            Console.WriteLine("");
            Console.WriteLine("  Pista : tiene " + t1 + " letras");
            for (i = 0; i <= t1 - 1; i++)
            {

                pal3 = pal3 + "*";

            }
            Console.Write("\n" + pal3);
            int intento = 0;
            do
            {
                char lp;
                char le;
                Boolean exito = false;
                Console.Write("\n Escriba una tecla \n");
                lp = Console.ReadLine()[0];
                for (i = 0; i <= t1 - 1; i++)
                {
                    le = pal2.Substring(i, 1)[0];
                    if (le.Equals(lp))
                    {
                        StringBuilder sbpal2 = new StringBuilder(pal3);
                        sbpal2[i] = lp;
                        pal3 = sbpal2.ToString();

                        exito = true;
                    }
                }
                if (exito)
                {
                    Console.Write("\nBien," + pal3);

                }
                else
                {
                    intento++;

                    Console.Write("\n Esa letra  es  incorrecta, lleva {0} intentos", intento);
                }
                if (intento == 6)
                {
                    Console.Write("perdiste");
                }
            }
            while (intento <= 5);
        }

        public void MostrarLetrero()
        {
            for (int i = 0; i < this.Letrero.Length; i++)
            {
                for (int j = 0; j < this.Letrero[i].Length; j++)
                {

                    Console.Write(this.Letrero[i][j]);
                    
            
                } 
                // le da el maximo tamaño a la consola
                Console.WindowWidth = Console.LargestWindowWidth;
                Console.WindowHeight = Console.LargestWindowHeight;
                //   cambia el color del fondo y la letra.
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                
            }

        }

    }
       
    
   
   


}

