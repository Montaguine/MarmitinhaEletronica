namespace Cardapio.TiposItems
{
    public class ItemBebidas : Item
    {
        public bool EhAlcolica { get; set; }
        public bool EhNatural { get; set; }

        public ItemBebidas(int id, string nome, TipoPrato tipo, bool vegetariano, decimal preco, string? descricao, double calorias, bool alcolica, bool natural)
            : base(id, nome, tipo, vegetariano, preco, descricao, calorias)
        {
            EhAlcolica = alcolica;
            EhNatural = natural;
        }
    }
}
