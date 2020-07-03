using System;

namespace FinalParcial.Model
{
    public class Registry
    {
        public int idUser { get; set; }
        public int idRegistry { get; set; }
        public bool entry { get; set; }
        public string temperature { get; set; }
        public DateTime date { get; set; }
    }
}