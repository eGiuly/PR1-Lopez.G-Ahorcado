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
            int i = 0, numAle = 0, extension = 0;
            string palOculta = "", palAdivinando = "";
            Random objeto = new Random();
            numAle = objeto.Next(1, 4);
            palOculta = pal[numAle];
            extension = palOculta.Length;
            Console.WriteLine("");
            Console.WriteLine("  Pista : tiene " + extension + " letras");
            for (i = 0; i <= extension - 1; i++)
            {

                palAdivinando = palAdivinando + "*";

            }
            Console.Write("\n" + palAdivinando);
            int intento = 0;
            do
            {
                char lp;
                char le;
                Boolean exito = false;
                Console.Write("\n Escriba una tecla \n");
                lp = Console.ReadLine()[0];
                for (i = 0; i <= extension - 1; i++)
                {
                    le = palOculta.Substring(i, 1)[0];
                    if (le.Equals(lp))
                    {
                        StringBuilder sbpal2 = new StringBuilder(palAdivinando);
                        sbpal2[i] = lp;
                        palAdivinando = sbpal2.ToString();

                        exito = true;
                    }
                }
                if (exito)
                {
                    Console.WriteLine("\nBien," + palAdivinando);
                    if (palOculta.Equals(palAdivinando))
                    {
                        Console.WriteLine(" Has acertado la palabra {0}", palAdivinando);
                        break;
                    }

                }
                else
                {
                    intento++;

                    Console.WriteLine("\n Esa letra  es  incorrecta, lleva {0} intentos", intento);
                }
                if (intento == 6)
                {
                    Console.Write("perdiste  :(  la palabra era {0}",palOculta);
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
                Console.ForegroundColor = ConsoleColor.Cyan;
                
            }

        }

    }
       
    
   
   


}

