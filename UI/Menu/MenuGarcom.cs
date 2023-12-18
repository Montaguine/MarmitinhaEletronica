using GestaoDePedidos.Mesas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Funcionarios.TiposFuncionarios;
using Cardapio.TiposItems;

namespace UI.Menu
{
    internal class MenuGarcom
    {
        public Mesas Mesa { get; set; }
        public List<Garcom>? Garcons { get; set; }
        public Garcom? Garcom { get; set; }

        public void AtribuiGarcom(Mesas mesa)
        {
            this.Mesa = mesa;
            Garcons = JsonParser<Garcom>.ReceberJson();
            Garcom = SelecionaGarcom();
            Garcom.MesasAtendendo++;
            Garcom.AbrirMesaG(Mesa);
        }

        public void MostraCardapio()
        {
            if (Mesa.Lugares > 1)
                Console.WriteLine($"Sejam bem vindos à Marmita Eletrônica, meu nome é {Garcom.getNomeG} e será um prazer atendê-los\n\n" +
                    $"Aqui está o cardápio, fiquem à vontade e me chamem quando estiverem prontos para realizar o pedido.");

            else Console.WriteLine($"Bem vindo à Marmita Eletrônica, meu nome é {Garcom.getNomeG} e será um prazer atendê-lo\n\n" +
                $"Aqui está o cardápio, fiquem à vontade e me chamem quando quiser realizar o pedido.");

            Garcom.ExibirCardapio();

        }
        public Garcom SelecionaGarcom()
        {
            Garcons?.OrderBy(Garcom => Garcom.MesasAtendendo);
            return Garcons.First();
        }

    }
}
