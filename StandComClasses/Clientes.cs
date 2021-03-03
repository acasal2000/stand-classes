using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandComClasses
{
    class Clientes
    {
        public int dinheiroInicial { get; set; }
        public string nome { get; set; }

        public int valorVenda { get; set; }

        public List<Historico> listaHistorico = new List<Historico>();
        public List<VeiculosPertencentes> listaVeiculosPertencentes = new List<VeiculosPertencentes>();

        public Clientes(int dinheiro, string nome)
        {
            this.dinheiroInicial = dinheiro;
            this.nome = nome;
            //var inicial = new Historico(dinheiroInicial, 0, "-", "-", "-", "-", DateTime.Now, "Balanço Inicial");
            //listaHistorico.Add(inicial);
        }

        public Clientes()
        {

        }

        public void comprarVeiculo(int valor, string cliente, string matricula, string marca, string modelo, DateTime data, string obs)
        {
            if (valor < 0) // Se o valor que o cliente oferece é menor que 0, então
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "O valor oferecido pelo veículo não pode ser inferior a 0 euros!");
            }
            if (dinheiroInicial - valor < 0)
            {
                throw new InvalidOperationException("Não tens dinheiro suficiente para comprar o veículo!");
            }
            dinheiroInicial -= valor;

            var compra = new Historico(dinheiroInicial, -valor, cliente, matricula, marca, modelo, data, obs);
            listaHistorico.Add(compra);

            var associarVeiculoCliente = new VeiculosPertencentes(cliente, matricula, marca, modelo);
            listaVeiculosPertencentes.Add(associarVeiculoCliente);
        }

        public void venderVeiculo(int valor, string cliente, string matricula, string marca, string modelo, DateTime data, string obs)
        {
            if (valor < 0) // Se o valor que o cliente oferece é menor que 0, então
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "O valor de venda do veículo não pode ser inferior a 0 euros!");
            }
            dinheiroInicial += valor;

            valorVenda = valor;

            var vender = new Historico(dinheiroInicial, valor, cliente, matricula, marca, modelo, data, obs);
            listaHistorico.Add(vender);

            int index = 0;

            for (int i = 0; i < listaVeiculosPertencentes.Count; i++)
            {
                if (listaVeiculosPertencentes[i].matricula == matricula)
                {
                    index = i;
                    break;
                }
            }
            listaVeiculosPertencentes.RemoveAt(index);
        }

        public string consultarHistorico(string cliente)
        {

            var historico = new StringBuilder();

            historico.AppendLine($"**********************************************");
            historico.AppendLine($" Movimentos do cliente {cliente} ");
            historico.AppendLine($"**********************************************\n");
            historico.AppendLine($"SALDO\tCLIENTE\tMATRICULA\tMARCA\tMODELO\tVALOR\tDATA\t\t\tOBSERVAÇÕES");

            foreach (var item in listaHistorico)
            {
                historico.AppendLine($"{item.dinheiroAtualizado}\t{item.cliente}\t{item.matricula}\t{item.marca}\t{item.modelo}\t{item.valor}\t{item.data}\t{item.obs}");
            }

            return historico.ToString();
        }

        public string consultarVeiculosPertencentes(string cliente)
        {
            var listaVeiculosClientes = new StringBuilder();
            listaVeiculosClientes.AppendLine($"**********************************************");
            listaVeiculosClientes.AppendLine($" Lista de Veículos do cliente {cliente} ");
            listaVeiculosClientes.AppendLine($"**********************************************\n");
            listaVeiculosClientes.AppendLine($"CLIENTE\tMATRICULA\tMARCA\tMODELO");
            listaVeiculosClientes.AppendLine($"________________________________________");

            if (listaVeiculosPertencentes.Count != 0)
            {
                foreach (var item in listaVeiculosPertencentes)
                {
                    listaVeiculosClientes.AppendLine($"\n{item.cliente}\t{item.matricula}\t{item.marca}\t{item.modelo}");
                }
            }
            else
            {
                listaVeiculosClientes.AppendLine("\nNão existe nenhum veículo associado a este cliente!");
            }
            return listaVeiculosClientes.ToString();
        }
    }
}
