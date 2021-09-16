using System;

namespace OrientacaoaObjetos.ContentContext
{
    public abstract class Content
    //a classe Conteúdo é abstract pq nao tem sentido criar uma instância dessa classe, pq o conteúdo sempre vai ser um curso, um artigo ou uma carreira, entao nao tem pq criar um novo conteudo
    {
        public Content(string title, string url)
        // método construtor que tem o mesmo nome da classe.
        {
            Id = Guid.NewGuid();
            // vai gerar uma hash de 36 caracteres para o ID.
            Title = title;
            Url = url;
        }
        public Guid Id { get; set; }
        //Guid = Global Unique Identifier.
        public string Title { get; set; }
        public string Url { get; set; }
    }
}