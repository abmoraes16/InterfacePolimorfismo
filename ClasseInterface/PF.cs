namespace ClasseInterface
{
    /// <summary>
    /// Herda da classe Cliente, implementa de interface IAcao
    /// </summary>
    public class PF : Cliente,IAcao
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public PF()
        {
            
        }

        public PF(int _Id, string _Nome, string _CPF, string _Email, string _Telefone, Endereco _End)
        {
            this.Id = _Id;
            this.Nome = _Nome;
            this.CPF = _CPF;
            this.Email = _Email;
            this.Telefone = _Telefone;
            this.End = _End;
        }

        public string Cadastro()
        {
            string composicao = "Id do Cliente: "+Id+
                                "\nNome do Cliente: "+Nome+
                                "\nEndereco: "+End.Logradouro+" ,"+End.Numero+" - "+End.Bairro+
                                "\nE-mail: "+Email+
                                "\nTelefone: "+Telefone+
                                "\nCPF: "+CPF;
        
            return "Dados do Cliente\n"+composicao;
        }

        public string Consulta()
        {
            throw new System.NotImplementedException();
        }
    }
}