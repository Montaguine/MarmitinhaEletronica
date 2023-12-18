using Cardapio.TiposItems;
using GestaoDePedidos.Mesas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios.TiposFuncionarios
{
    public class Recepcionista : Funcionario
    {
        public List<Mesas> Mesas { get; set; }
        public Recepcionista(string nome, int id)
            : base(nome, id)
        {

        }

        public void ObterMesas()
        {
           Mesas = JsonParser<Mesas>.ReceberJson();
        }
        public Mesas SelecionarMesa(int resposta)
        {
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
                return null;
            }
        }

    }
}
