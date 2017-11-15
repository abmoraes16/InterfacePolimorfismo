using System;
using ClasseInterface;

namespace ExemploInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //CADASTRO DE PRODUTO
            
            Console.WriteLine("\n\nCadastro de Produto\n");
            
            Produto pr = new Produto(){
                Id = 30,
                Nome = "Sabão",
                Descricao = "Em pó",
                Preco = 30,
            
            };
            
            Console.WriteLine(pr.Cadastro());

            //CADASTRO DE CLIENTE
            
            Console.WriteLine("\nCadastro de Cliente PF\n");

            Endereco endereco = new Endereco();
            endereco.Logradouro = "Rua Nova Esperança";
            endereco.Numero = "56";
            endereco.Bairro = "Jardim Alegria";

            PF pf = new PF(10,"Helena","545678613","helena@mail.com","4545",endereco);

            Console.WriteLine(pf.Cadastro());

        }
    }
}
