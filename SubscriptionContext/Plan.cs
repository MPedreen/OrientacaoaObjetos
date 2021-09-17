using OrientacaoaObjetos.SharedContext;

namespace OrientacaoaObjetos.SubscriptionContext
{
    //Toda assinatura pertence a um aluno, um aluno pode ter mais de uma assinatura, mas nunca mais de uma assinatura ativa ao mesmo tempo. As assinaturas sao feitas através do paypal, pagarme, e cada uma tem suas especificidades, e as assinaturas estao sempre atreladas a um plano dentro da plataforma Balta.
    public class Plan : Base
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}