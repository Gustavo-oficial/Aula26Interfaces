using System;
using System.Collections.Generic;

namespace Aula26Interfaces
{
    public class Carrinho : ICarrinho
    {

        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();
        public void Adicionar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Alterar(int _codigo, Produto _produtoAlterado)
        {
            carrinho.Find(z => z.codigo == _codigo).Nome  = _produtoAlterado.Nome;
            carrinho.Find(z => z.codigo == _codigo).Preco = _produtoAlterado.Preco;
        }
    

        public void Excluir(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void Ler()
        {
            foreach(Produto item in carrinho)
            {
                Console.WriteLine($"O produtos a ser adquirido é: {item.Nome} - R$ {item.Preco} ");
            }
        }

        public void MostrarTotal()
        {
                
            foreach(Produto item in carrinho)
            {
                ValorTotal += item.Preco;
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Total dos itens: R$ {ValorTotal} ");
            Console.ResetColor();
        }
    }
}