using System;
using OrientacaoaObjetos.SharedContext;

namespace OrientacaoaObjetos.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }
        //uma assinatura sempre vai ter um plano
        public DateTime? EndDate { get; set; }
        //data final da assinatura
        // "?" significa nullabe, ou seja, se a EndDate está nula, o aluno ainda é premium, nao acabou a assinatura dele.
        public bool IsInactive => EndDate <= DateTime.Now;
    }
}