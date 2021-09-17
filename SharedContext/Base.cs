using System;
using OrientacaoaObjetos.NotificationContext;

namespace OrientacaoaObjetos.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
            // vai gerar uma hash de 36 caracteres para o ID.
        }
        public Guid Id { get; set; }
        //Guid = Global Unique Identifier.

    }
}