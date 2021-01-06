
using System.Collections.Generic;
using System;
using MVC_Console.Views;
using MVC_Console_II.Models;

namespace MVC_Console_II.Controller

{
    public class ProdutoController
    {

        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();
        public void MostrarProduto(){
            List<Produto> todos = produto.Ler();
            produtoView.ListarTodos(todos);
        }
      
      public void Cadastrar(){
          produto.Inserir(produtoView.CadastrarProduto());

        }
               
    }
}

