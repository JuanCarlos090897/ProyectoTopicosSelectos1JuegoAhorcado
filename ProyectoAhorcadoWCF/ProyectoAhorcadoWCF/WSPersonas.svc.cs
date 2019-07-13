using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProyectoAhorcadoWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSPersonas : IWSPersonas
    {
        public Persona ObtenerPersona(string Identificacion)
        {
            if (Identificacion == "0")
            {
                return new Persona() { Nombre = "Felipe", Edad = 99 };
            }
            else if (Identificacion == "1")
            {
                return new Persona() { Nombre = "Patricia", Edad = 50 };
            }
            else
            {
                return new Persona() { Error = "Error al encontrar esta identificacion" };
            }
        }










        // Esto es para el proyecto



        public Listas ObtenerPalabra(string Dificultad)
        {

            ArrayList ListaDePalabras = new ArrayList();

            string Palabra = "";
            int NumeroRandom = 0;
            Random random = new Random(); // este va ser el nuemro random que voy a generar para escoger la palabra 

            if (Dificultad == "Dificil")
            {
                ListaDePalabras.Add("arterioscleidosis");
                ListaDePalabras.Add("caleidoscopio");
                ListaDePalabras.Add("electrocardiograma");
                ListaDePalabras.Add("otorrinaringologo");
                ListaDePalabras.Add("electrodomestico");
                ListaDePalabras.Add("aeropuerto");


             //   return new Listas() {PalabraDeLaLista = "XXXX" };

            }else if (Dificultad == "Medio")
            {
                ListaDePalabras.Add("siempre");
                ListaDePalabras.Add("presidente");
                ListaDePalabras.Add("ejemplo");
                ListaDePalabras.Add("problemas");
                ListaDePalabras.Add("seguridad");
                ListaDePalabras.Add("internacional");

            }
            else if (Dificultad == "Facil")
            {
                ListaDePalabras.Add("uva");
                ListaDePalabras.Add("gato");
                ListaDePalabras.Add("perro");
                ListaDePalabras.Add("zapato");
                ListaDePalabras.Add("bolso");
                ListaDePalabras.Add("pie");
            }
            else  // aqui deberia ir una respuesta de escoger dificultad 
            {
                
            }

            NumeroRandom = random.Next(0, 5); // Esto genera el numero random para obtener una palabra de las 6 que hay 
          
            Palabra = ListaDePalabras[NumeroRandom].ToString(); // aqui lo que hago es meter la palabra que se quedo con NuneroRamdom en una  variable


            return new Listas() { PalabraDeLaLista = Palabra }; // aqui retorno un objeto listas con la palabra selecionada
        }

    }
}
