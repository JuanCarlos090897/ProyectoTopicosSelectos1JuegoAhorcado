using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWS
{
    public partial class Form1 : Form
    {

        public static string palabra; // Hago una varible global de la clase con la palabra que se usa para jugar 
        public static string PalabraQueQueda; // esto lo que hace es guardar la pabra que queda para seguir revisando
        public static char[] ArregloPalabraX;
        public static string DificultadSelecionada;
        public int Intentos = 0;
        public int ConteoVocales = 0; // Esto es para saber cuantas vocales quedan 
        public int ConteoConsonantes = 0; // es para ver cuantas consonantes quedan 
        public int PonerVocal = 1; // esto es para ver si puede poner una vocal
        public int PonerConsonantes = 0; // Esto es para ver cuantas veces tiene que poner una consonante antes de poner una vocal


        public Form1()
        {
            InitializeComponent();
            btnIngresarLetra.Enabled = false;
            txtLetrasIngresar.Enabled = false;
            btnEmpezarDeNuevo.Enabled = false;
            
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDificultad.Items.Add("Facil");
            cmbDificultad.Items.Add("Medio");
            cmbDificultad.Items.Add("Dificil");
            
        }

        private void btnIngresarLetra_Click(object sender, EventArgs e)
        {
            
            bool ResultadoVerexisteLetra = false;
            if (txtLetrasIngresar.Text.Length == 1)
            {
                if(EsVocal(txtLetrasIngresar.Text) == false || PonerConsonantes != 0 )// aqui entra cuando es una consonante 
                {
                    PonerConsonantes--;
                }
                if (PonerConsonantes ==0 && PonerVocal == 0) // esto es por si ya cumplio el limete establecido de consonantes que pueda poner la vocal
                {
                    PonerVocal++;
                }

                if (EsVocal(txtLetrasIngresar.Text)==false || PonerVocal == 1 || ConteoVocales == 1 || ConteoConsonantes == 0)// osea si es false es porque la letra no es una vocal 
                {
                    if (EsVocal(txtLetrasIngresar.Text) == true) // aqui lo que hago es si lo que ingreso fue vocal que le de 0 hasta que meta la cantidad necesaria de consonantes
                    {
                        PonerVocal = 0;


                        // ahora aqui adentro voy a poner que se resetee cuando mete una vocal la cantidad de intentos de consonantes que debe hacer

                        if (cmbDificultad.SelectedItem.ToString() == "Dificil")
                        {
                            PonerConsonantes = 3;
                        }
                        if (cmbDificultad.SelectedItem.ToString() == "Medio")
                        {
                            PonerConsonantes = 2;
                        }
                        if (cmbDificultad.SelectedItem.ToString() == "Facil")
                        {
                            PonerConsonantes = 1;
                        }


                    }
                    
                    ResultadoVerexisteLetra = VerExisteLetra(txtLetrasIngresar.Text); // aqui lo mando para que haga el metodo de fijarse y acomodar e igual me devulva true o false
                    txtLetrasIngresar.Text = "";
                    if (ResultadoVerexisteLetra == false)
                    {
                        Intentos = Intentos - 1;
                        lblConteoIntentos.Text = Intentos.ToString();
                    }
                    if (Intentos == 0)
                    {
                        lblResultadoJuego.Text = "Has Perdido";
                    }
                    // falta hacer un metodo para ver si la palabra no tiene X en grande y si no tiene poner que ha ganado 
                    if (VerSiHayXs() == false)
                    {
                        lblResultadoJuego.Text = "GANADOR";
                    }
                    if (VerSiHayXs() == false || Intentos == 0) // aqui es lo que hago cuando termina el juego ya sea que haya ganado o perdido 
                    {
                        btnIngresarLetra.Enabled = false;
                        txtLetrasIngresar.Enabled = false;
                        btnEmpezarDeNuevo.Enabled = true;
                    }
                }else if (EsVocal(txtLetrasIngresar.Text) == true && PonerVocal == 0)
                {

                }
                

            }
            
        }

        public bool VerSiHayXs()
        {
            for(int i = 0; i< palabra.Length; i++)
            {
                if(ArregloPalabraX[i] == 'X')
                {
                    return true; // si aun hay X se devuelve true sino false
                }

            }
            return false;
        }

        public void MetodoConteoVocales() // en este metodo lo que hago en contar las vocales y de una vez conteo consonantes 
        {
            int conteo = 0;
            char[] arreglo = new char[palabra.Length];
            

            for (int i = 0; i < palabra.Length; i++) // aqui lleno un arreglo con todas las letras 
            {
                conteo++;
                arreglo = palabra.ToCharArray(0, conteo);
            }
            for (int i = 0; i < palabra.Length; i++) // aqui voy a contar las vocales que tiene ese arreglo
            {
                if (arreglo[i].ToString() == "a" || arreglo[i].ToString() == "e" || arreglo[i].ToString() == "i" || arreglo[i].ToString() == "o" || arreglo[i].ToString() == "u")
                {
                    ConteoVocales++;
                }
                else {
                    ConteoConsonantes++;
                }

            }
        }
        public bool EsVocal(string letra)
        {
            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                return true;
            }
            return false;
        }
        private void btnSeleccionarDificultad_Click(object sender, EventArgs e)
        {
            if (cmbDificultad.SelectedItem != null) // aqui valido a ver si la persona selecciono algo sino que no haga nada
            {
                var ItemSelccionado = cmbDificultad.SelectedItem.ToString();


                using (WSPersonas.WSPersonasClient client = new WSPersonas.WSPersonasClient())
                {

                    var persona = client.ObtenerPalabra(ItemSelccionado); // hasta aqui recibo la palabra
                    palabra = persona.PalabraDeLaLista;
                    //PalabraQueQueda = palabra; // desde aqui le doy la palabra que se escogio porque esta es la que se va a desarmar

                    PalabraQueQueda = ""; // aqui lo hago para que no tenga la palabra anterior despues de haber jugado una vez

                    for (int i=0; i<palabra.Length; i++)// aqui lo que voy hacer es darle el valor de X a todas las letras de la palabra
                    {
                        PalabraQueQueda = PalabraQueQueda + "X";
                    }
                    
                }
                MetodoConteoVocales();// aqui le doy la cantidad de vocales a que tiene la palabra a la variable global de ConteoVocales
                DificultadSelecionada = ItemSelccionado;
                cmbDificultad.Enabled = false;
                btnSeleccionarDificultad.Enabled = false; // aqui lo que hago es deshabilitar los botones cuando se selecciona la dificultad  
                txtLetrasIngresar.Enabled = true;
                btnIngresarLetra.Enabled = true;
                lblPalabraFormandose.Text = PalabraQueQueda;
                
                ArregloPalabraX = new char[palabra.Length];
                // char x[] = 'X';
                for (int a = 0; a < palabra.Length; a++)// aqui lleno el arreglo de char en X
                {
                    ArregloPalabraX[a] = 'X';
                }

                // aqui le voy a dar la cantidad de intentos 

            if(DificultadSelecionada == "Dificil")
                {
                    Intentos = 3;
                    PonerConsonantes = 3;
                }else if (DificultadSelecionada == "Medio")
                {
                    Intentos = 4;
                    PonerConsonantes = 2;
                }
                else
                {
                    Intentos = 5;
                    PonerConsonantes = 1;
                }
                lblConteoIntentos.Text = Intentos.ToString();
            }
        }

        public bool VerExisteLetra(string letrabuscada) // lo que hago aqui es hacer una metodo que revise a ver si existe esa letra en la palabra 
        {
            char[] arreglo;
            bool bandera = false;
            int conteo = 0;
            string palabramiedo = "";
            
            for (int i = 0; i < palabra.Length; i++) {// este for es para buscar la letra que sea igual a la palabra va en letra por letra 
                conteo ++;
                arreglo = palabra.ToCharArray(0,conteo);    // lo que ocupo hacer es i i++ asi voy viendo a ver si existe la letra  

                if (arreglo[i].ToString() == letrabuscada) 
                {
                    bandera = true; // lo que hago es que si se encuentra esta letra le paso que es  true porque si se encontro 

                    ArregloPalabraX[i] = letrabuscada[0];
                    
                }
           
            }
            if (bandera == true ) // aqui lo que hago es darle a palabra que queda el valor de la cadena 
            {

            }
            for (int i = 0; i < palabra.Length; i++)
            {
                palabramiedo = palabramiedo + ArregloPalabraX[i];
                    }
            PalabraQueQueda = palabramiedo;
            lblPalabraFormandose.Text = PalabraQueQueda;
            return bandera;
        }

        private void btnEmpezarDeNuevo_Click(object sender, EventArgs e)
        {
            btnEmpezarDeNuevo.Enabled = false;
            btnSeleccionarDificultad.Enabled = true;
            cmbDificultad.Enabled = true;
            lblPalabraFormandose.Text = "Palabra";
            lblConteoIntentos.Text = "0";
            lblResultadoJuego.Text = ".";

        }
    }
}


// lo que me hace falta es pasar la palabra a un lugar donde el cual la persona digite la letra revise a ver si esta esa letra