using System.Collections.Generic;

namespace OrientacaoaObjetos.NotificationContext
{
    public abstract class Notifiable
    //outras classes vao herdar da Notifiable, nao faz sentido eu ter uma instancia dessa classe.
    {
        public List<Notification> Notifications { get; set; }
        public void Add(Notification notification)
        //Adiciona 1 notificação
        {
            Notifications.Add(notification);
        }
        public void AddRange(IEnumerable<Notification> notifications)
        {
            //Adiciona várias notificações
            Notifications.AddRange(notifications);
        }
    }
}