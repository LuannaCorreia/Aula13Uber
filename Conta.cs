namespace Aula13Uber
{
    public class Conta
    {
         private string agencia;
        public string Agencia
        {
            get {return agencia;}
            set {agencia = value;}
        }
        private string conta;
        public string _Conta
        {
            get {return conta;}
            set {conta = value;}
        }

        public string Cadastrar(){
            if (agencia==null || conta==null) 
                return "Agencia ou conta inválida.";
            else 
                return "Cadastro realizado com êxito!";
        }

        public void Excluir(){
            if (agencia==null || conta==null) 
                System.Console.WriteLine("Não é possiível excluir esta conta, por que ela não existe.");
            else {
                agencia=null;
                conta=null;
                System.Console.WriteLine("Conta excluída!");
            }
        }
    }
} 