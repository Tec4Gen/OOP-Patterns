using Adapter.Interface;
using System;

namespace Adapter.Entityes
{
    public class Gnome : IAttack, IMoving
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
