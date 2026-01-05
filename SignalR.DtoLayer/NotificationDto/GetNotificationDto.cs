using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.NotificationDto
{
    public class GetNotificationDto
    {
        public int NotificationId { get; set; }
        public string NotificationType { get; set; }
        public string NotificationIcon { get; set; }
        public string Description { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool Status { get; set; }
    }
}
