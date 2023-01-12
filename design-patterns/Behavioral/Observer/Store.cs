using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Behavioral.Observer
{
    internal class Store
    {
        private readonly NotificationService notificationService;

        public Store()
        {
            notificationService = new NotificationService();
        }

        public void NewItemPromotion()
        {
            notificationService.notify();
        }

        public NotificationService GetNotificationService()
        {
            return notificationService;
        }
    }
}
