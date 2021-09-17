using System.Collections.Generic;
using System.Linq;
using OrientacaoaObjetos.NotificationContext;
using OrientacaoaObjetos.SharedContext;

namespace OrientacaoaObjetos.SubscriptionContext
{
    public class Student : Base
    //o usuario é separado de aluno pq nem sempre um usuario vai ser um aluno, pois as vezes pode ser um usuario de escritório contábil que está consultando pagamentos, por exemplo.
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        //assinaturas do aluno

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premiuim", "O aluno já tem assinatura ativa"));
                return;
                //return para sair da função
            }

            Subscriptions.Add(subscription);
            //se ele nao for premium
        }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}