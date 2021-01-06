using System;
using MVC_Console_II.Controller;


namespace MVC_Console_II
{
    class Program
    {
        static void Main(string[] args)
        {
          ProdutoController produtoController = new ProdutoController();

          produtoController.Cadastrar();
          produtoController.MostrarProduto();
        }
    }
}
