namespace ClasseInterface
{
    /// <summary>
    /// Herda da classe Cliente, implementa de interface IAcao
    /// </summary>
    public class PJ : Cliente, IAcao
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        
        public PJ()
        {
            
        }

        public PJ(int _Id, string _RazaoSocial, string _CNPJ, string _Email, string _Telefone, Endereco _End)
        {
            this.Id = _Id;
            this.RazaoSocial = _RazaoSocial;
            this.CNPJ = _CNPJ;
            this.Email = _Email;
            this.Telefone = _Telefone;
            this.End = _End;
        }

        public string Cadastro()
        {
            string composicao = "Id do Cliente: "+Id+
                                "\nRazão Social: "+RazaoSocial+
                                "\nEndereco: "+End.Logradouro+" ,"+End.Numero+" - "+End.Bairro+
                                "\nE-mail: "+Email+
                                "\nTelefone: "+Telefone+
                                "\nCNPJ: "+CNPJ;
        
            return "Dados do Cliente\n"+composicao;
        }

        public string Consulta()
        {
            throw new System.NotImplementedException();
        }
    }
}