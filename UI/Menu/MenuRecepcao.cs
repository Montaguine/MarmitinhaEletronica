using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardapio.TiposItems;
using GestaoDePedidos.Mesas;

namespace UI.Menu
{
    public class MenuRecepcao
    {
        public List<Mesas> Mesas { get; set; }

        public MenuRecepcao()
        {
            Mesas = JsonParser<Mesas>.ReceberJson();
        }

        public Mesas SelecionaMesa()
        {
            int resposta;

            Console.WriteLine("Bem vindo à Marmita Eletrônica");

            Console.WriteLine("\nConfirme o total de pessoas do grupo: ");

            resposta = Resposta();

            Console.WriteLine($"Aguarde um momento enquanto preparamos sua mesa para {resposta} lugares.");

            if (Mesas.Find(x => x.Lugares == resposta && x.status == StatusMesa.Livre) != null)
            {
                return Mesas.Find(x => x.Lugares == resposta && x.status == StatusMesa.Livre);
            }
            else if (Mesas.Find(x => x.Lugares > resposta && x.status == StatusMesa.Livre) != null)
            {
                return Mesas.Find(x => x.Lugares > resposta && x.status == StatusMesa.Livre);
            }
            else
            {
                Console.WriteLine("Não há mesas disponíveis que atendam a quantidade de clientes, por favor aguarde um momento.");
                return null;
            }
        }
        public static int Resposta()
        {
            try
            {
                int resposta = int.Parse(Console.ReadLine());
                return resposta;
            }
            catch (Exception)
            {
                Console.WriteLine("Resposta inválida");
                return 0;
            }
        }
    }
}
