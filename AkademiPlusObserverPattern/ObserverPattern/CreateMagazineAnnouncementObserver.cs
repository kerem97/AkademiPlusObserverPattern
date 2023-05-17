using AkademiPlusObserverPattern.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkademiPlusObserverPattern.ObserverPattern
{
    public class CreateMagazineAnnouncementObserver : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateMagazineAnnouncementObserver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.UserName,
                Magazine = "Bilim Teknoloji Dergisi",
                Content = "Mayıs sayısı bayimize gelmiştir"
            });
            context.SaveChanges();
        }
    }
}
