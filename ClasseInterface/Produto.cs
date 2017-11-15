namespace ClasseInterface
{
    public class Produto:IAcao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Produto()
        {

        }
        
        public Produto(int _Id, string _Nome, string _Descricao, double _Preco)
        {
            this.Id = _Id;
            this.Nome = _Nome;
            this.Descricao = _Descricao;
            this.Preco = _Preco;
        }

        public string Cadastro()
        {
            string composicao="Id do Produto:"+Id+
                              "\nNome do Produto: "+Nome.ToUpper()+
                              "\nDescrição do Produto: "+Descricao+
                              "\nPreço: "+string.Format("{0:C2}",Preco);

            return "Produto cadastrado\n"+composicao;
        }

        public string Consulta()
        {
            throw new System.NotImplementedException();
        }
    }
}