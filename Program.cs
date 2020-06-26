using System;

namespace Aula26Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();

            Produto p1 = new Produto("Yakuza",1, 800f);
            Produto p2 = new Produto("FIFA 21",2, 300f);
            Produto p3 = new Produto("Cadeira Gamer",3, 1399.99f);
            Produto p4 = new Produto("Mouse",4, 250f);
            
            cart.Adicionar(p1);
            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);

        cart.Ler();
        cart.MostrarTotal();

        }
    }
}
