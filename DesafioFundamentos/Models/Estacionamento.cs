namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        string placa;

        public void AdicionarVeiculo()
        {
            while (true){
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                placa = Console.ReadLine();

                if (placa.Length == 8)
                    {
                        veiculos.Add(placa);
                        Console.WriteLine($"O veículo com a placa {placa} foi estacionado com sucesso!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Placa inválida. A placa deve ter 8 caracteres (XXX-0000).");
                    }
            }
        }

        public void RemoverVeiculo()
        {
            while (true)
            {
                Console.WriteLine("Digite a placa do veículo para remover:");
                placa = Console.ReadLine();

                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    veiculos.Remove(placa);
                    
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    int horas = Convert.ToInt32(Console.ReadLine());
                    decimal valorTotal = precoInicial + precoPorHora * horas;

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                    break;
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente e tente novamente.");
                }
            }
        }

        public void ListarVeiculos()
        {
            int contador = veiculos.Count;
            Console.WriteLine($"Quantidade de veículos estacionados: {contador}");

            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine($"- {veiculo.ToUpper()}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

    }
}
