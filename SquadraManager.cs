using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcio
{
    static class SquadraManager
    {
        public static Squadra squadra = new Squadra()
        {
            Nome = "Milan",
            Allenatore = "Mario Rossi",
            CampionatoDisputatato = "Serie A",
            DataFondazione = "13-08-1891",
            Presidente = "Laura Bianchi",
            Rosa = rosa,
            Titolari = titolari
        };
        public static List<Calciatore> calciatori = new List<Calciatore>()
        {
            {new Attaccante(){Id = 1, Nome = "Alessandro Del Piero", DataDiNascita= "11-11-1979", NumeroMaglia = 10, GoalRealizzati = 15} },
            {new Attaccante(){Id = 2, Nome = "Francesco Totti", DataDiNascita= "13-01-1982", NumeroMaglia = 10, GoalRealizzati = 19} },
            {new Attaccante(){Id = 3, Nome = "Luca Toni", DataDiNascita= "16-03-1981", NumeroMaglia = 12, GoalRealizzati = 9} },
            {new Attaccante(){Id = 4, Nome = "Filippo Inzaghi", DataDiNascita= "29-02-1975", NumeroMaglia = 8, GoalRealizzati = 11} },
            {new Centrocampista(){Id = 5, Nome = "Pavel Nedved", DataDiNascita= "09-09-1974", NumeroMaglia = 2, PassaggiTentati = 35, PassaggiRiusciti = 33 } },
            {new Centrocampista(){Id = 6, Nome = "Marco Materazzi", DataDiNascita= "30-04-1985", NumeroMaglia = 15, PassaggiTentati = 43, PassaggiRiusciti = 37 } },
            {new Centrocampista(){Id = 7, Nome = "Simone Inzaghi", DataDiNascita= "14-09-1974", NumeroMaglia = 22, PassaggiTentati = 32, PassaggiRiusciti = 25 } },
            {new Difensore() {Id = 8, Nome = "Giorgio Chiellini" , DataDiNascita="14-08-1984", NumeroMaglia= 32, TackleRiusciti = 40} },
            {new Difensore() {Id = 9, Nome = "Leonardo Bonucci" , DataDiNascita="20-08-1988", NumeroMaglia= 4, TackleRiusciti = 24} },
            {new Difensore() {Id = 10, Nome = "Alessandro Florenzi" , DataDiNascita="03-08-1996", NumeroMaglia= 17, TackleRiusciti = 34} },
            {new Difensore() {Id = 11, Nome = "Leonardo Spinazzola" , DataDiNascita="11-05-1992", NumeroMaglia= 7, TackleRiusciti = 29} },
            {new Portiere() {Id = 12, Nome = "Gianluigi Buffon", DataDiNascita = "19-12-1978", NumeroMaglia = 1, GoalSubiti = 3, RigoriParati = 19} },
            {new Portiere() {Id = 13, Nome = "Gianluigi Donnarumma", DataDiNascita = "25-02-1999", NumeroMaglia = 13, GoalSubiti = 1, RigoriParati = 13} },
        };
        public static List<Calciatore> rosa = new List<Calciatore>();
        public static List<Calciatore> titolari = new List<Calciatore>();

        public static bool AggiungiGiocatoreRosa(Calciatore calciatore)
        {
            if (calciatore == null)
            {
                return false;
            }
            else
            {
                foreach (Calciatore player in rosa)
                {
                    if (player == calciatore)
                    {
                        Console.WriteLine("\nGiocatore già presente in Rosa!\n");
                        return false;
                    }
                }
                rosa.Add(calciatore);
                return true;

            }
        }
        public static void MostraGiocatori()
        {
            foreach (Calciatore calciatore in calciatori)
            {
                Console.WriteLine($"{calciatore.Id,-5 }{calciatore.Nome}");
            }
        }
        public static Calciatore RestituisciCalciatore(int index)
        {
            foreach (Calciatore calciatore in calciatori)
            {
                if (calciatore.Id == index)
                {
                    return calciatore;
                }
            }
            return null;
        }
        public static void MostraGiocatoriRosa()
        {
            foreach (Calciatore calciatore in rosa)
            {
                Console.WriteLine($"{calciatore.Id,-5 }{calciatore.Nome}");
            }
        }
        public static bool EliminaGiocatoreRosa(int index)
        {
            if (rosa.Count != 0)
            {
                foreach (Calciatore calciatore in rosa)
                {
                    if (calciatore.Id == index)
                    {
                        rosa.Remove(calciatore);
                        return true;
                    }
                }
                foreach (Calciatore calciatore in titolari)
                {
                    if (calciatore.Id == index)
                    {
                        titolari.Remove(calciatore);
                        return true;
                    }
                }
                return false;
            }
            else
            {
                Console.WriteLine("\nNon ci sono ancora giocatori nella rosa!\n");
                return false;
            }

        }
        public static bool AggiungiGiocatoreTitolare(Calciatore calciatore)
        {
            if (calciatore == null)
            {
                return false;
            }
            else
            {
                foreach (Calciatore player in titolari)
                {
                    if (player == calciatore)
                    {
                        Console.WriteLine("\nGiocatore già presente tra i titolari!\n");
                        return false;
                    }
                }
                titolari.Add(calciatore);
                return true;

            }
        }
        public static Calciatore RestituisciCalciatoreRosa(int index)
        {
            foreach (Calciatore calciatore in rosa)
            {
                if (calciatore.Id == index)
                {
                    return calciatore;
                }
            }
            return null;
        }
        public static void SceltaTitolari()
        {
            Console.WriteLine(" -- Gestione Titolari --\n ");
            if (rosa.Count >= 3) //ci andrebbe 11 ma per velocizzare le prove ho messo 3 
            {
                do
                {
                    SquadraManager.MostraGiocatoriRosa();

                    Console.WriteLine("\nInserisci il numero del giocatore che vuoi far diventare Titolare\n");
                    Console.Write(">> ");
                    bool isInt = int.TryParse(Console.ReadLine(), out int indexPlayer);
                    while (!isInt)
                    {
                        Console.WriteLine("\nInserimento non valido\n");
                        Console.Write(">> ");
                    }
                    Calciatore nuovoTitolare = new Calciatore();
                    nuovoTitolare = SquadraManager.RestituisciCalciatoreRosa(indexPlayer);
                    bool isTrue = SquadraManager.AggiungiGiocatoreTitolare(nuovoTitolare);
                    if (isTrue)
                    {
                        Console.WriteLine("\nInserimento Avvenuto con successo!\n");
                    }
                    else
                    {
                        Console.WriteLine("\nInserimento non riuscito!\n");
                    }
                } while (titolari.Count != 2); //ci andrebbe titolati.count == 11 ma ho messo due per fare test


                
            }
            else
            {
                Console.WriteLine("Non ci sono abbastanza giocatori in Rosa per poter scegliere la formazione Titolare\n!");

            }
            
        }
        public static void MostraStatisticheTitolari()
        {
            Console.Clear();
            Console.WriteLine(" -- Statistiche Titolari -- \n");
            if (titolari.Count != 0)
            {
                foreach (Calciatore calciatore in titolari)
                {
                    Console.WriteLine(calciatore.ToString());
                }
            }
            else
            {
                Console.WriteLine("Non ci sono ancora titolari in squadra!");
            }
            Console.WriteLine();
        }

    }
}
