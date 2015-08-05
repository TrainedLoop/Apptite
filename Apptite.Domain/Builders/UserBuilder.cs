using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apptite.Domain.Builder
{
    public class UserBuilder
    {
        #region --//Properties//--
        private string Name;
        private string SurName;
        private string Login;
        private string Email;
        private string Password;
        private string FacebookId;

        #endregion



        #region --//Insert Methods//--
        public UserBuilder WithName(string name)
        {
            if (name.Trim().Length < 2)
                throw new ArgumentException("Nome Invalido Minimo 2 caracteres");
            if (name.Trim().Length > 20)
                throw new ArgumentException("Nome Invalido Maximo 20 caracteres");
            Name = name;
            return this;
        }
        public UserBuilder WithSurname(string surname)
        {
            if (surname.Trim().Length < 2)
                throw new ArgumentException("Sobrenome Invalido Minimo 2 caracteres");
            if (surname.Trim().Length > 20)
                throw new ArgumentException("Sobrenome Invalido Maximo 20 caracteres");
            SurName = surname;
            return this;
        }

        public UserBuilder SetLogin(string login)
        {
            if (login.Trim().Length < 4)
                throw new ArgumentException("Login Invalido Minimo 4 caracteres");
            if (login.Trim().Length > 20)
                throw new ArgumentException("Login Invalido Maximo 20 caracteres");
            Login = login;
            return this;
        }

        public UserBuilder SetPassword(string password, string passwordConfirmation)
        {
            if (password != passwordConfirmation)
                throw new ArgumentException("Senhas não conferem");

#warning  inserir validacao de letra e numero???
            Password = password;
            return this;
        }

        public UserBuilder SetEmail(string email)
        {
#warning  inserir validacao
            Email = email;
            return this;
        }

        public UserBuilder SetFacebookId(string facebookId)
        {
#warning  inserir validacao
            FacebookId = facebookId;
            return this;
        }

        #endregion


        #region --//Conversor//--
        public static implicit operator User(UserBuilder ub)
        {

            if (string.IsNullOrWhiteSpace(ub.Name))
                throw new ArgumentNullException("O Nome está vazio");
            if (string.IsNullOrWhiteSpace(ub.SurName))
                throw new ArgumentNullException("O Sobrenome está vazio");
            if (string.IsNullOrWhiteSpace(ub.Login))
                throw new ArgumentNullException("O Login está vazio");
            if (string.IsNullOrWhiteSpace(ub.Password))
                throw new ArgumentNullException("A senha está vazia");


            return new User(ub.Name, ub.SurName, ub.Login,ub.Email, ub.Password, ub.FacebookId);

        }

        #endregion
    }
}