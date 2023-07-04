using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LaLiga
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Pruebas Arraylist, se debe de elegir 'jugador', o 'equipo' 
            para que salga un valor al azar
            */

            
            String type;
            type = Console.ReadLine();
            
            if(type == "jugador") {
                
                List<String> jugadores = new List<String>();
            
                jugadores.Add("Modric");
                jugadores.Add("Lewandowski");
                jugadores.Add("Griezmann");
                jugadores.Add("Zubimendi");
                jugadores.Add("Yeremy Pino");
                jugadores.Add("Canales");
                jugadores.Add("Chimy Avila");
                jugadores.Add("Unai Simon");
                jugadores.Add("Muriqi");
                jugadores.Add("Oriol Romeu");
                jugadores.Add("Isi Palazon");
                jugadores.Add("Jesus Navas");
                jugadores.Add("Iago Aspas");
                jugadores.Add("Pacha Espino");
                jugadores.Add("Enes Unal");
                jugadores.Add("Jose Luis Gayá");
                jugadores.Add("Robertone");
                jugadores.Add("Uzuni");
                jugadores.Add("Jonathan Viera");
                jugadores.Add("Rioja");
                
                Random random = new Random();
                int number = random.Next(0, jugadores.Count);
                
                Console.WriteLine(jugadores[number]);

            
            }
            else if (type == "equipo")
            {
                List<String> equipos = new List<String>();
            
                equipos.Add("Real Madrid");
                equipos.Add("Barcelona");
                equipos.Add("Atletico");
                equipos.Add("Real Sociedad");
                equipos.Add("Real Betis");
                equipos.Add("Athletic");
                equipos.Add("Villarreal");
                equipos.Add("Cadiz");
                equipos.Add("Las Palmas");
                equipos.Add("Alaves");
                equipos.Add("Osasuna");
                equipos.Add("Granada");
                equipos.Add("Valencia");
                equipos.Add("Almeria");
                equipos.Add("Rayo Vallecano");
                equipos.Add("Celta");
                equipos.Add("Getafe");
                equipos.Add("Sevilla");
                equipos.Add("Mallorca");
                equipos.Add("Girona");
                
                
                Random random = new Random();
                int number = random.Next(0, equipos.Count);
                
                Console.WriteLine(equipos[number]);
            }
            else 
            {
                Console.WriteLine("Elija a un 'jugador', o 'equipo' de nuevo");
            }
        }
    }
}
