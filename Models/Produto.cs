using System.Collections.Generic;
using System.IO;
using System;
using MVC_Console_II.Controller;

namespace MVC_Console_II.Models
{
    public class Produto
    {
        public int Codigo {get; set;}

        public string Nome {get;set;}

        public float Preco {get;set;}

        private const string PATH = "Database/Produto.csv";

        public Produto(){

            string pasta= PATH.Split('/')[0];
        
        //verificamos se a pasta nao existe e criamos essa condição
        if(!Directory.Exists(pasta))
        {
            Directory.CreateDirectory(pasta);
        }
        //Verificamos se o aquivo Produto.csv existe, se não, criamos
        if(!File.Exists(PATH)){

            File.Create(PATH).Close();
        }
        }
          public List<Produto> Ler()
        {    
            List<Produto> produtos = new List<Produto>();

            //ler as info do .csv
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {   
            
                //separar atributos pelo ";"
                string[] atributos = item.Split(";");
        
            
            //criamos um produto vazio para poder colocar na lista de produtos
            Produto prod = new Produto();
            prod.Codigo = int.Parse(atributos[0]);
            prod.Nome = atributos[1];
            prod.Preco = float.Parse(atributos[2]);

            produtos.Add(prod);
        }
        
    
        return produtos;
        }
        public void Inserir(Produto p){
            string[] linhas ={PrepararLinhaCSV(p)};
            File.AppendAllLines(PATH,linhas);
        }
                 public string PrepararLinhaCSV(Produto prod){
                return $"{prod.Codigo}; {prod.Nome};{prod.Preco}";
    }
}
}
    

    
 