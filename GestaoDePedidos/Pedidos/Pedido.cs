using Cardapio.TiposCardapios;
using Cardapio.TiposItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDePedidos.Pedidos
{
    public class Pedido
    {
        public CardapioLogica Cardapio { get; set; }
        public List<Item> Itens { get; set; }
        public decimal? ValorTotal { get; set; }
        public int QqtItens { get; set; }

        public Pedido()
        {
            ValorTotal = 0;
            QqtItens = 0;
        }

        public int AdicionarItem(CardapioLogica cardapio, int idItem)
        {
            QqtItens = Itens.Count;
            Item item = SelecionaItem(cardapio, idItem);
            Itens.Add(item);
            if (Itens.Count <= QqtItens)
            {
                throw new Exception("Item não adicionado");
            }
            ValorTotal += item.Preco;
            return 1;
        }

        public Item SelecionaItem(CardapioLogica cardapio, int idItem)
        {
            Item itemEncontrado = cardapio.ItemsDoCardapio.FirstOrDefault(i => i.Id == idItem);
            return itemEncontrado;
        }

        public bool ContemItem(int idItem)
        {
            return Itens.Exists(item => item.Id == idItem);
        }


        public void RemoverItem(int idItem)
        {
            if (ContemItem(idItem)) ;
            Itens.Remove(Itens.Find(x => x.Id == idItem));
        }

    }
}
