using OrientacaoaObjetos.SharedContext;

namespace OrientacaoaObjetos.SubscriptionContext
{
    public class Student : Base
    //o usuario é separado de aluno pq nem sempre um usuario vai ser um aluno, pois as vezes pode ser um usuario de escritório contábil que está consultando pagamentos, por exemplo.
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
    }
}