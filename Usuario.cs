namespace Aula13Uber
{
    public class Usuario
    {
         private string login;
        public string Login
        {
            get { return login;}
            set { login = value;}
        }
        private string senha;
        public string Senha
        {
            get { return senha;}
            set { senha = value;}
        }
        private string nome;
        public string Nome
        {
            get { return nome;}
            set { nome = value;}
        }
        private string foto;
        public string Foto
        {
            get { return foto;}
            set { foto = value;}
        }
        private string localizacaoAtual;
        public string LocalizacaoAtual
        {
            get { return localizacaoAtual;}
            set { localizacaoAtual = value;}
        }
        private string tokenLogin;
        public string TokenLogin
        {
            get { return tokenLogin;}
            set { tokenLogin = value;}
        }

        public bool FazerLogin(string l, string s){
            if ((l!=Login) || (s!=Senha)) {
                System.Console.WriteLine("Login ou senha inválidos!.");
                return false;
            }
            
            else if (TokenLogin!=null) {
                System.Console.WriteLine("Você já está logado!.");
                return false;
            }

            else {
                TokenLogin="skufdgkasfuhguydaf";
                System.Console.WriteLine("Login efetuado com êxito!");
                return true;
            }
        }

        public void FazerLogout(){
            if (TokenLogin==null) 
                System.Console.WriteLine("Você não pode realizar o logout, porque você não está logado.");
            else {
                TokenLogin = null;
                System.Console.WriteLine("Logout efetuado com êxito.");
            }
        }
    }
} 
