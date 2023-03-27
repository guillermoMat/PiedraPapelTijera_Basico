using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijera
{
    public class Juego
    {
    

        Piedra obj_piedra = new Piedra();
        Papel obj_papel = new Papel();
        Tijera obj_tijera = new Tijera();

      

       public string comprobacionJuego(int opc,string contra)
        {
            //Console.WriteLine(obj_tijera.GetType());//que tipo de objeto es 
            //Console.WriteLine(obj_tijera.GetType().Equals(typeof(Tijera))); //si es true o false

            //Console.WriteLine("\nSeleccione una opcion:");
            //Console.WriteLine("1-Piedra");
            //Console.WriteLine("2-Papel");
            //Console.WriteLine("3-Tijera");
            //Console.Write("Opcion: ");
            //int opc = int.Parse(Console.ReadLine());


            string resultado="";

            if (opc==1)
            {//PIEDRA
                if (contra=="piedra" || contra=="Piedra")
                {
                    resultado= "Empate";
                }else if (contra == "papel" || contra == "Papel")
                {
                    resultado = "Pierde";
                }else if (contra == "tijera" || contra == "Tijera")
                {
                    resultado = "Gana";
                }

            }else if (opc == 2)
            {//PAPEL
                if (contra == "piedra" || contra == "Piedra")
                {
                    resultado = "Gana";
                }
                else if (contra == "papel" || contra == "Papel")
                {
                    resultado = "Empata";
                }
                else if (contra == "tijera" || contra == "Tijera")
                {
                    resultado = "Pierde";
                }
            }else if (opc==3)
            {//TIJERA
                if (contra == "piedra" || contra == "Piedra")
                {
                    resultado = "Pierde";
                }
                else if (contra == "papel" || contra == "Papel")
                {
                    resultado = "Gana";
                }
                else if (contra == "tijera" || contra == "Tijera")
                {
                    resultado = "Empate";
                }
            }
            else
            {
                resultado = "Error";
            }
            return resultado;

        }

        public string comprobacionJuegoObjetos(object opc, object contra)
        {
            //Console.WriteLine(obj_tijera.GetType());//que tipo de objeto es 
            //Console.WriteLine(obj_tijera.GetType().Equals(typeof(Tijera))); //si es true o false

            //Console.WriteLine("\nSeleccione una opcion:");
            //Console.WriteLine("1-Piedra");
            //Console.WriteLine("2-Papel");
            //Console.WriteLine("3-Tijera");
            //Console.Write("Opcion: ");
            //int opc = int.Parse(Console.ReadLine());


            string resultado = "";

            if (opc.GetType() == obj_piedra.GetType())
            {//PIEDRA
                if (contra.GetType() == obj_piedra.GetType())
                {
                    resultado = "Empate";
                }
                else if (contra.GetType() == obj_papel.GetType())
                {
                    resultado = "Pierde";
                }
                else if (contra.GetType() == obj_tijera.GetType())
                {
                    resultado = "Gana";
                }

            }else if (opc.GetType() == obj_papel.GetType())
            {//PAPEL
                if (contra.GetType() == obj_piedra.GetType())
                {
                    resultado = "Gana";
                }
                else if (contra.GetType() == obj_papel.GetType())
                {
                    resultado = "Empata";
                }
                else if (contra.GetType() == obj_tijera.GetType())
                {
                    resultado = "Pierde";
                }
            }else if (opc.GetType() == obj_tijera.GetType())
            {//TIJERA
                if (contra.GetType() == obj_piedra.GetType())
                {
                    resultado = "Pierde";
                }
                else if (contra.GetType() == obj_papel.GetType())
                {
                    resultado = "Gana";
                }
                else if (contra.GetType() == obj_tijera.GetType())
                {
                    resultado = "Empate";
                }
            }
            return resultado;

        }

    }
}
