using System;
using System.Collections.Generic;
using MVC_Console_II.Models;

namespace MVC_Console.Views
{
    public class ProdutoView
    {
    
        public void ListarTodos(List <Produto> produtos){
            foreach (Produto item in produtos){
                Console.WriteLine($"Codigo: {item.Codigo}");
                  Console.WriteLine($"Nome: {item.Nome}");
                    Console.WriteLine($"Preço: {item.Preco}");
                    Console.WriteLine();

           
            }
        }
               public Produto CadastrarProduto(){

               Produto produto = new Produto();
               Console.WriteLine($"Digite o codigo do produto");
               produto.Codigo = int.Parse(Console.ReadLine());

               Console.WriteLine($"Digite o nome do produto");
                 produto.Nome = Console.ReadLine();
               Console.WriteLine($"Digite o preço do produto");
                 produto.Preco = float.Parse(Console.ReadLine());
               
               return produto;
               Console.WriteLine($"{produto.Codigo}");
               Console.WriteLine($"{produto.Nome}");
               Console.WriteLine($"{produto.Preco}");
               
               
           }

        }
    }
    

