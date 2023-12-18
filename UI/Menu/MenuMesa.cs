using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using GestaoDePedidos.Mesas;
using Funcionarios.TiposFuncionarios;

namespace UI.Menu
{
    internal class MenuMesa
    {
        public Mesas Mesa { get; set; }
        public List<Garcom>? Garcons { get; set; }

        public Garcom? Garcom { get; set; }

        public MenuMesa(Mesas mesa)
        {
            SetMesa(mesa);
        }
        public void SetMesa(Mesas mesa)
        {
            this.Mesa = mesa;
        }

        public void MenuLoop()
        {
            int escolha;
            do
            {
                Console.WriteLine("1 - Chamar garçom");
                Console.WriteLine("2 - Ver cardápio");
                Console.WriteLine("3 - Fazer pedido");
                Console.WriteLine("4 - Fechar comanda");
                escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Mesa.ChamarGarcom();
                        break;
                    case 2:
                        Garcom.ExibirCardapio();
                        break;
                    case 3:
                        int escolha2;
                        Console.WriteLine("Já deicidiu o item que deseja pedir? ");
                        Console.WriteLine("1 - SIM, 2 - NÃO");
                        escolha2 = int.Parse(Console.ReadLine());
                        if (escolha2 == 1)
                        {
                            Console.WriteLine("Informe o ID do item que deseja pedir: ");
                            escolha2 = int.Parse(Console.ReadLine());
                            Mesa.FazPedido(escolha2);
                        }
                        if (escolha2 == 2)
                        {
                            Garcom.ExibirCardapio();
                            Console.WriteLine("Informe o ID do item que deseja pedir: ");
                            escolha = int.Parse(Console.ReadLine());
                            Mesa.FazPedido(escolha2);
                        }
                        break;
                    case 4:
                        Mesa.FecharComanda();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (escolha != 4);
            Console.WriteLine($"O total da sua comanda é {Mesa.comanda.ItensDaComanda.ValorTotal}" +
                $" e os itens pedidos foram {Mesa.comanda.ItensDaComanda.ToString}");
            Console.WriteLine("Agradeçemos a preferência, volte sempre!");
        }
    }
}
