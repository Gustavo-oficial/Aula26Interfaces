using System;
using System.Collections.Generic;

namespace Aula26Interfaces
{
    public interface ICarrinho
    {
        
         void MostrarTotal();
         void Adicionar(Produto produto);

         void Excluir(Produto produto);

         void Alterar(int _codigo, Produto _produtoalterado);

         void Ler();
    }
}