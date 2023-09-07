using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Materiale
    {

        public string Titolo { get; set; }
        public DateTime Anno { get; set; }
        public int Nid { get; set; }
        public string Settore { get; set; }
        public bool Stato { get; set; }

        public string Tipo { get; set; }


        public static List<Materiale> ListaMateriale = new List<Materiale>();

        public Materiale() { }

        public Materiale(string titolo, DateTime anno, int nid, string settore, bool stato, string tipo)
        {
            Titolo = titolo;
            Anno = anno;
            Nid = nid;
            Settore = settore;
            Stato = stato;
            Tipo = tipo;
        }

        public static void Menu()
        {
            Console.WriteLine("##### BIBLIOTECA POSSO URLARE #####");
            while (true)
            {
                Console.WriteLine("Premi 1 per vedere tutto il materiale");
                Console.WriteLine("Premi 2 per vedere i materiali disponibili");
                Console.WriteLine("Premi 3 per inserire un prestito");
                Console.WriteLine("Premi 4 per vedere i prestiti in corso");
                Console.WriteLine("Premi 5 per estinguere un prestito");
                Console.WriteLine("################################");

                Console.Write("Scelta: ");
                int scelta = int.Parse(Console.ReadLine());
                if (scelta == 1)
                {
                    MostraTuttaLista();
                }
                else if (scelta == 2)
                {

                    MostraDisponibili();
                    Menu();
                }
                else if (scelta == 3)
                {
                    PrestitoStudenti();
                }
                else if (scelta == 4)
                {
                    MostraPrestito();
                }
                else if (scelta == 5)
                {
                    EstinguiPrestito();
                }
                else if (scelta == 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Scelta non valida");
                    Menu();
                }
            }
        }
        public static void ListMateriale()
        {

            ListaMateriale.Add(new Materiale("Storia d'Italia", new DateTime(2022, 05, 23), 1, "Storia", true, "Libro"));
            ListaMateriale.Add(new Materiale("Impara C#", new DateTime(2000, 05, 23).Date, 2, "Informatica", true, "Libro"));
            ListaMateriale.Add(new Materiale("Sql", new DateTime(2023, 05, 23).Date, 3, "Informatica", false, "Dvd"));
        }
        public static void MostraTuttaLista()
        {
            foreach (Materiale mate in ListaMateriale)
            {
                string disp = "";
                if (mate.Stato)
                {
                    disp = "Disponibile";
                }
                else
                {
                    disp = "Non disponibile";
                }

                Console.WriteLine($"ID: {mate.Nid}, Titolo: {mate.Titolo}, Anno: {mate.Anno.Year}, Settore: {mate.Settore}, Disponibilità: {disp} Tipologia: {mate.Tipo}");
                Console.WriteLine();
            }
            Menu();
        }
        public static void MostraDisponibili()
        {
            if (ListaMateriale.Count > 0)
            {
                foreach (Materiale mate in ListaMateriale)
                {
                    string disp = "";
                    if (mate.Stato)
                    {
                        disp = "Disponibile";

                        Console.WriteLine($"ID: {mate.Nid}, Titolo: {mate.Titolo}, Anno: {mate.Anno.Year}, Settore: {mate.Settore}, Disponibilità: {disp} Tipologia: {mate.Tipo}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Materiale non disponibile");
                Console.WriteLine();
                Menu();

            }
            Console.WriteLine();
        }
        public static void PrestitoStudenti()
        {
            Console.WriteLine("Inserisci Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci Cognome: ");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserisci Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Inserisci n° Telefono: ");
            int tel = int.Parse(Console.ReadLine());
            Console.WriteLine("Cosa vuoi prendere in prestito?");
            foreach (Materiale mate in ListaMateriale)
            {
                string disp = "";
                if (mate.Stato)
                {
                    disp = "Disponibile";

                    Console.WriteLine($"ID: {mate.Nid}, Titolo: {mate.Titolo}, Anno: {mate.Anno.Year}, Settore: {mate.Settore}, Disponibilità: {disp} Tipologia: {mate.Tipo}");
                }
            }
            Console.WriteLine("Scelta: ");
            int num = int.Parse(Console.ReadLine());
            DateTime data = DateTime.Now;

            foreach (Materiale mat in ListaMateriale)
            {
                if (num == mat.Nid)
                {
                    if (mat.Stato)
                    {
                        Console.WriteLine($"Hai preso in prestito {mat.Titolo}, il: {data}");
                        Studente st = new Studente(nome, cognome, email, tel, mat.Titolo, data, mat.Nid);
                        Studente.ListaStudente.Add(st);
                        mat.Stato = false;
                        Console.WriteLine();
                        Menu();


                    }
                    else
                    {
                        Console.WriteLine("Materiale non trovato");
                        Console.WriteLine();
                        PrestitoStudenti();
                    }
                }
            }
        }
        public static void EstinguiPrestito()
        {
            if (Studente.ListaStudente.Count > 0)
            {
                Console.WriteLine("##### ESTINGUI PRESTITO #####");
                Console.WriteLine("Inserisci l'ID del Materiale");
                int Id = int.Parse(Console.ReadLine());

                foreach (Studente st in Studente.ListaStudente)
                {
                    if (Id == st.Id)
                    {
                        DateTime data = DateTime.Now;
                        Console.WriteLine($"Prestito di: Nome: {st.Nome}, Cognome: {st.Cognome},  Titolo: {st.Titolo}, Data Prestito: {st.Data}, Id Libro: {st.Id}");
                        Console.WriteLine($"Estinto il: {data} ");
                        Console.WriteLine();

                        Studente.ListaStudente.Remove(st);
                        foreach (Materiale mt in ListaMateriale)
                        {
                            if (st.Id == mt.Nid)
                            {
                                mt.Stato = true;
                            }
                        }
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("Id non riconosciuto");
                        Console.WriteLine();
                        EstinguiPrestito();
                    }
                }
            }
            else
            {
                Console.WriteLine("Nessun prestito disponibile");
                Console.WriteLine();
                Menu();

            }
        }
        public static void MostraPrestito()
        {
            Console.WriteLine("##### PRESTITI IN CORSO #####");

            if (Studente.ListaStudente.Count > 0)
            {
                foreach (Studente pr in Studente.ListaStudente)
                {
                    Console.WriteLine($"Nome: {pr.Nome}, Cognome: {pr.Cognome}, Data Prestito: {pr.Data}, Titolo: {pr.Titolo}, Id Libro: {pr.Id}");
                }
                Console.WriteLine();

                Menu();
            }
            else
            {

                Console.WriteLine("Non c'è ancora nessun prestito");
                Console.WriteLine();
                Menu();
            }
        }
    }




}
