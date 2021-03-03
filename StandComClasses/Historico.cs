using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandComClasses
{
    class Historico
    {
        public int dinheiroAtualizado { get; }
        public string cliente { get; }
        public string matricula { get; }
        public string marca { get; }
        public string modelo { get; }
        public int valor { get; }
        public DateTime data { get; }
        public string obs { get; }

        public Historico(int dinheiroAtualizado, int valor, string cliente, string matricula, string marca, string modelo, DateTime data, string obs)
        {
            this.dinheiroAtualizado = dinheiroAtualizado;
            this.cliente = cliente;
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
            this.valor = valor;
            this.data = data;
            this.obs = obs;
        }
    }
}
