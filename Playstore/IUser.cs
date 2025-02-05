using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playstore
{
    public interface IUser
    {
        void AddUser();

        void UpdateUser();

        void DeleteUser();

        void GetUser();
    }

    public abstract class UserAbs
    {
        public abstract void AddUser();

        public abstract void UpdateUser();

        public abstract void DeleteUser();

        public abstract void GetUser();
    }
}
