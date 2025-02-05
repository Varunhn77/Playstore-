using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playstore;

namespace Playstore
{
    public abstract class BankAccount
    {
        public abstract void deposit();
        
        public abstract void withdraw();
    }
}

public class SavingsAccount : BankAccount
{
    public override void deposit()
    {
        throw new NotImplementedException();
    }

    public override void withdraw()
    {
        throw new NotImplementedException();
    }
}

public class CurrentAccount : BankAccount
{
    public override void deposit()
    {
        throw new NotImplementedException();
    }

    public override void withdraw()
    {
        throw new NotImplementedException();
    }
}

