using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public int  Tel { get; set; }
        public string Titolo { get; set; }
        public int Id { get; set; }
        public DateTime  Data {  get; set; }
        public Studente() { }   

        public Studente(string nome, string cognome, string email, int tel, string titolo, DateTime data, int id)
        {
            Nome = nome;
            Cognome = cognome;
            Email = email;
            Tel = tel;
            Titolo = titolo;
            Data = data;
            Id = id;
        }

        public static List<Studente> ListaStudente = new List<Studente>();


        
    }
}
