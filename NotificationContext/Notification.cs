namespace OrientacaoaObjetos.NotificationContext
{
    public sealed class Notification
    //classe para substituir uma Exception, pois a Exception para a execução do programa e uma mensagem não.
    //sealed serve para não conseguir criar variações dessa classe, por exemplo, nao consigo fazer isso> public class ErrorNotification : Notification {}
    {
        public Notification()
        //construtor vazio, caso alguem queira instanciar um construtor sem nada.
        {

        }

        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property { get; set; }
        //propriedade que apresentou o erro
        public string Message { get; set; }
        //Mensagem de erro
    }
}