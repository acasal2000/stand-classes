using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandComClasses
{
    class VeiculosPertencentes
    {
        public string cliente { get; }
        public string matricula { get; }
        public string marca { get; }
        public string modelo { get; }

        public VeiculosPertencentes(string cliente, string matricula, string marca, string modelo)
        {
            this.cliente = cliente;
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
        }

    }
}
