using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityRealWorld
{
    public abstract class Approver
    {
        protected Approver successor;
        public void SetSuccesor(Approver successor)
        {
            this.successor = successor;
        }
        public abstract void ProcessRequest(Purchase purchase);
    }
}
