using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcio
{
    class Menu
    {
        static public void Start()
        {
            bool keepOnGoing = true;
            do
            {
                
                Console.WriteLine(" -- Menu -- ");
                Console.WriteLine();
                
                Console.WriteLine("1: Aggiungi giocatore alla rosa");
                Console.WriteLine("2: Vendi giocatore");
                Console.WriteLine("3: Gestisci Titolari");                
                Console.WriteLine("4: Stampa le statistiche dei titolari della squadra");
                Console.WriteLine("5: Esci dal Menu");
                Console.WriteLine();
                Console.Write(">> ");
                string indexMenu = Console.ReadLine();
                switch (indexMenu)
                {
                    case "1": //aggiungi giocatore alla rosa
                        Console.Clear();
                        Console.WriteLine(" -- Elenco Calciatori --\n ");
                        SquadraManager.MostraGiocatori();
                        Console.WriteLine("\nInserisci il numero del giocatore che vuoi aggiungere in rosa\n");
                        Console.Write(">> ");
                        bool isInt = int.TryParse(Console.ReadLine(), out int indexPlayer);
                        while (!isInt)
                        {
                            Console.WriteLine("\nInserimento non valido\n");
                            Console.Write(">> ");
                        }
                        Calciatore nuovoCalciatore = new Calciatore();
                        nuovoCalciatore = SquadraManager.RestituisciCalciatore(indexPlayer);
                        bool isTrue = SquadraManager.AggiungiGiocatoreRosa(nuovoCalciatore);
                        if (isTrue)
                        {
                            Console.WriteLine("\nInserimento Avvenuto con successo!\n");
                        }
                        else
                        {
                            Console.WriteLine("\nInserimento non riuscito!\n");
                        }
                        
                        break;

                    case "2": // eliminare giocatore dalla rosa
                        Console.Clear();
                        Console.WriteLine(" -- Elenco Calciatori --\n ");
                        SquadraManager.MostraGiocatoriRosa();
                        Console.WriteLine("\nInserisci il numero del giocatore che vuoi vendere\n");
                        Console.Write(">> ");
                        isInt = int.TryParse(Console.ReadLine(), out indexPlayer);
                        while (!isInt)
                        {
                            Console.WriteLine("\nInserimento non valido\n");
                            Console.Write(">> ");
                        }
                        isTrue = SquadraManager.EliminaGiocatoreRosa(indexPlayer);
                        if (isTrue)
                        {
                            Console.WriteLine("\nIl giocatore è stato venduto!\n");
                        }
                        else
                        {
                            Console.WriteLine("\nVendita non riuscita!\n");
                        }
                        break;
                    case "3": // gestire titolari
                        Console.Clear();
                        SquadraManager.SceltaTitolari();
                        

                        break;
                    case "4": // stampa statistiche titolari
                        Console.Clear();
                        SquadraManager.MostraStatisticheTitolari();
                        break;
                    case "5": // esci
                        keepOnGoing = false;
                        break;
                    default:
                        Console.WriteLine("\nScelta non disponibile!\n");
                        break;

                }




            } while (keepOnGoing == true);
        }
    }
}
