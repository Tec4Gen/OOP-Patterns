using Adapter.Interface;
using System;

namespace Adapter.Entityes
{
    public class Orc : IAttack, IMoving
    {
        public void DealDemage()
        {
            throw new NotImplementedException();
        }

        public void Moving()
        {
            throw new NotImplementedException();
        }
    }
}
