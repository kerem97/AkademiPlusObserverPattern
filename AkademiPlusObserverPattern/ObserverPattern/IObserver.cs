using AkademiPlusObserverPattern.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkademiPlusObserverPattern.ObserverPattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}
