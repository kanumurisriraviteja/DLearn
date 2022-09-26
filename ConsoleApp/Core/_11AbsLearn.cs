using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core
{
    abstract class _11AbsLearn : _10IntLearn
    {
        int i = 5;
        public void IntrestRate()
        {
            i = 5;
            Console.Write(_10IntLearn.iVar);
        }

        private void Test() { }
        public abstract void CreditCard();
        public abstract void AddBalance();
        public abstract void WithBalance();
        public abstract void DebitCard();
        public abstract void SavingAccount();
    }


    class FederalBank : _11AbsLearn
    {
        public override void AddBalance()
        {
            throw new NotImplementedException();
        }

        public override void CreditCard()
        {
            throw new NotImplementedException();
        }

        public override void DebitCard()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void SavingAccount()
        {
            throw new NotImplementedException();
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public override void WithBalance()
        {
            throw new NotImplementedException();
        }
    }

    class IdfcFirstBank : _10IntLearn
    {
        public void AddBalance()
        {
            throw new NotImplementedException();
        }

        public void DebitCard()
        {
            throw new NotImplementedException();
        }

        public void SavingAccount()
        {
            throw new NotImplementedException();
        }

        public void WithBalance()
        {
            throw new NotImplementedException();
        }
    }

}
