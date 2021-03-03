using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandComClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar os veículos
            Console.WriteLine("***** VEÍCULOS DISPONIVEIS *****\n");
            var veiculo1 = new Veiculos(3000, "AA/AA/AA", "Fiat", "Punto");
            Console.WriteLine($"O veículo {veiculo1.marca} {veiculo1.modelo} de matricula {veiculo1.matricula} foi colocado à venda por um valor de {veiculo1.valor} euros.");

            var veiculo2 = new Veiculos(5000, "BB/BB/BB", "Peugeot", "207");
            Console.WriteLine($"O veículo {veiculo2.marca} {veiculo2.modelo} de matricula {veiculo2.matricula} foi colocado à venda por um valor de {veiculo2.valor} euros.");

            var veiculo3 = new Veiculos(7120, "CC/CC/CC", "Toyota", "Yaris");
            Console.WriteLine($"O veículo {veiculo3.marca} {veiculo3.modelo} de matricula {veiculo3.matricula} foi colocado à venda por um valor de {veiculo3.valor} euros.");
            Console.WriteLine();

            // Criar os clientes
            Console.WriteLine("***** CLIENTES EXISTENTES *****\n");
            var cliente1 = new Clientes(10000, "André");
            Console.WriteLine($"O cliente {cliente1.nome} tem um valor inicial de {cliente1.dinheiroInicial} euros.");

            var cliente2 = new Clientes(16000, "Joaquim");
            Console.WriteLine($"O cliente {cliente2.nome} tem um valor inicial de {cliente2.dinheiroInicial} euros.\n");

            // Comprar um veiculo
            Console.WriteLine("***** AÇÕES DOS CLIENTES *****\n");
            cliente1.comprarVeiculo(veiculo1.valor, cliente1.nome, veiculo1.matricula, veiculo1.marca, veiculo1.modelo, DateTime.Now, "Compra");
            cliente1.comprarVeiculo(veiculo2.valor, cliente1.nome, veiculo2.matricula, veiculo2.marca, veiculo2.modelo, DateTime.Now, "Compra");
            cliente2.comprarVeiculo(veiculo3.valor, cliente2.nome, veiculo3.matricula, veiculo3.marca, veiculo3.modelo, DateTime.Now, "Compra");
            Console.WriteLine($"O cliente {cliente1.nome} comprou um veículo por {veiculo1.valor} euros.\n");
            Console.WriteLine($"O cliente {cliente1.nome} comprou um veículo por {veiculo2.valor} euros.\n");
            Console.WriteLine($"O cliente {cliente2.nome} comprou um veículo por {veiculo3.valor} euros.\n");

            // Vender um veiculo
            cliente1.venderVeiculo(6000, cliente1.nome, veiculo1.matricula, veiculo1.marca, veiculo1.modelo, DateTime.Now, "Venda");
            veiculo1.valor = cliente1.valorVenda;
            Console.WriteLine($"O cliente {cliente1.nome} vendeu um veículo por {veiculo1.valor} euros.\n");

            Console.WriteLine();

            // Consultar histórico            
            Console.WriteLine(cliente1.consultarHistorico(cliente1.nome));
            Console.WriteLine();
            Console.WriteLine(cliente2.consultarHistorico(cliente2.nome));

            // Consultar veículos pertencentes a clientes            
            
            Console.WriteLine(cliente1.consultarVeiculosPertencentes(cliente1.nome));   
            Console.WriteLine(cliente2.consultarVeiculosPertencentes(cliente2.nome));

            Console.ReadLine();
        }
    }
}
