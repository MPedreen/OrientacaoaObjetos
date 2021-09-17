using System.Collections.Generic;
using System.Linq;

namespace OrientacaoaObjetos.NotificationContext
{
    public abstract class Notifiable
    //outras classes vao herdar da Notifiable, nao faz sentido eu ter uma instancia dessa classe.
    {
        public List<Notification> Notifications { get; set; }
        public Notifiable()
        {
            Notifications = new List<Notification>();
        }
        public void AddNotification(Notification notification)
        //Adiciona 1 notificação
        {
            Notifications.Add(notification);
        }
        public void AddNotifications(IEnumerable<Notification> notifications)
        //Adiciona várias notificações
        {
            Notifications.AddRange(notifications);
        }
        public bool IsInvalid => Notifications.Any();
        //propriedade só com o get, então usei o Expression Body (=>)
        //Any retorna um booleano, se tiver uma notificação, esse objeto vai estar invalido. se tiver uma erro, esse objeto vai estar invalido
        //a partir disso, posso fazer: if(courseOOP.IsInvalid) {tomo alguma decisão}
    }
}