using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd_ejemplo1.Models
{
    public class Coche
    {
        public string IdCoche { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Propietario { get; set; }

        public Coche(string idCoche, string marca, string modelo, string propietario)
        {
            this.IdCoche = idCoche;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Propietario = propietario;
        }
    }
}