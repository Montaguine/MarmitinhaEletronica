using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardapio.TiposCardapios;
using GestaoDePedidos.Mesas;

namespace Funcionarios.TiposFuncionarios
{
    public class Garcom : Funcionario
    {
        public int MesasAtendendo { get; set; }

        public Limpeza l1 { get; set; } = new Limpeza("Ramon", 10);
        //public List <Mesas> listaDeMesasAtendidas { get; set; } = new List<Mesas>(); inicio de lógica para obtenção de quais mesas cada garçom

        public CardapioLogica cardapio { get; set; } = new CardapioLogica();
        public Garcom(string nome, int id, int mesasAtendendo)
            : base(nome, id)
        {
            MesasAtendendo = mesasAtendendo;
        }

        public void AbrirMesaG(Mesas m)
        {
            m.AbrirMesa();
            //listaDeMesasAtendidas.Add(m);
        }

        public void FecharMesaG(Mesas m)
        {
            m.FecharMesa();
            l1.LimparMesa();
            //listaDeMesasAtendidas.Remove(m);
        }

        public int FazPedidoG(Mesas m, int idItem)
        {
            int adicionouItem = m.FazPedido(idItem);
            return adicionouItem;
        }

        public string getNomeG()
        {
            return nome;
        }

        public void ExibirCardapio()
        {
            cardapio.MostrarCardapioOrdenadoPorNome();
        }
    }
}
