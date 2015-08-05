using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apptite.Domain
{
    public class User
    {
        #region --//Properties//--
        public virtual string Name { get; protected set; }
        public virtual string SurName { get; protected set; }
        public string FullName => Name + " " + SurName;

        public virtual string Login { get; protected set; }
        public virtual string Email { get; protected set; }
        public virtual string Password { get; protected set; }
        public virtual string FacebookId { get; protected set; }
        // public virtual string GoogleId { get; private set; }  Hora de implementar?

        #endregion

        #region  --//Constructors//--
        private User() { }

        internal User(string name, string surName, string login, string email, string password, string facebookId = null)
        {
            Name = name;
            SurName = surName;
            Login = login;
            Email = email;
            Password = password;
            FacebookId = facebookId;
        }

        #endregion
    }
}

