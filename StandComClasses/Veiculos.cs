using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandComClasses
{
    public class Veiculos
    {
        public int valor { get; set; }
        public string matricula { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }

        public Veiculos(int valor, string matricula, string marca, string modelo)
        {
            this.valor = valor;
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
        }    
        
        public Veiculos()
        {

        }
    }
}
