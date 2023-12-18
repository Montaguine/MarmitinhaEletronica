using UI.Menu;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var recepcao = new MenuRecepcao();
            var atendimento = new MenuGarcom();
            var mesa = recepcao.SelecionaMesa();
            var garcom = atendimento.SelecionaGarcom();
            atendimento.MostraCardapio();
            var usuario = new MenuMesa(mesa);
            usuario.MenuLoop();
        }
    }
}
