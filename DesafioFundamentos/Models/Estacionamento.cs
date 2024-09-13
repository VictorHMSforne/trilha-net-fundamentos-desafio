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

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // Concluído!!!
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("======================");
            Console.WriteLine("CADASTRO DE VEÍCULOS");
            Console.WriteLine("======================");
            Console.ResetColor();

            bool continuar = true;
            string opcao;
            while (continuar)
            {
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                string placaVeiculo = Console.ReadLine();
                if (veiculos.Any(v => v.ToUpper() == placaVeiculo.ToUpper()))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Este veículo já está estacionado, digite outra placa");
                    Console.ResetColor();

                    Console.WriteLine("Deseja Cadastrar outro veículo? S/N");
                    opcao = Console.ReadLine().ToUpper();
                    switch (opcao)
                    {
                        case "S":
                            break;
                        case "N":
                            continuar = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opção inválida!");
                            Console.ResetColor();
                            break;
                    }

                }
                else
                {
                    veiculos.Add(placaVeiculo);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Veículo adicionado com Sucesso!!!");
                    Console.ResetColor();

                    Console.WriteLine("Deseja Cadastrar outro veículo? S/N");
                    opcao = Console.ReadLine().ToUpper();
                    switch (opcao)
                    {
                        case "S":
                            break;
                        case "N":
                            continuar = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opção inválida!");
                            Console.ResetColor();
                            break;
                    }
                }
            }
            
        }

        public void RemoverVeiculo()
        {
            
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // Concluído!!!
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=================================");
            Console.WriteLine("REMOÇÃO DE VEÍCULOS");
            Console.WriteLine($"VALOR DA ENTRADA: R$ {precoInicial}");
            Console.WriteLine($"VALOR POR HORA:   R$ {precoPorHora}");
            Console.WriteLine("=================================");
            Console.ResetColor();

            
            bool continuar = true;
            string opcao;
            while (continuar)
            {
                Console.WriteLine("Digite a placa do veículo para remover:");
                string placa = Console.ReadLine();

                // Verifica se o veículo existe
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                    // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                    // Concluído!!!

                    int horas = Convert.ToInt32(Console.ReadLine());
                    decimal valorTotal = precoInicial + (precoPorHora * horas); 
                    veiculos.Remove(placa);

                    // TODO: Remover a placa digitada da lista de veículos
                    // Concluído!!!
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Veículo removido com Sucesso!!!");
                    Console.ResetColor();
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

                    Console.WriteLine("Deseja Remover outro veículo? S/N");
                    opcao = Console.ReadLine().ToUpper();
                    switch (opcao)
                    {
                        case "S":
                            break;
                        case "N":
                            continuar = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opção inválida!");
                            Console.ResetColor();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente\n");

                    Console.WriteLine("Deseja Voltar para o Menu? S/N");
                    opcao = Console.ReadLine().ToUpper();
                    switch (opcao)
                    {
                        case "S":
                            continuar = false;
                            break;
                        case "N":
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opção inválida!");
                            Console.ResetColor();
                            break;
                    }

                }
            }
            
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // Concluído!!!
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("======================");
                Console.WriteLine("LISTAGEM DE VEÍCULOS");
                Console.WriteLine("======================");
                Console.ResetColor();
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var item in veiculos)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(item);
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não há veículos estacionados.");
                Console.ResetColor();
            }
        }
    }
}
