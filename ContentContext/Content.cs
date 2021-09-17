using System;
using OrientacaoaObjetos.SharedContext;

namespace OrientacaoaObjetos.ContentContext
{
    public abstract class Content : Base
    //a classe Conteúdo é abstract pq nao tem sentido criar uma instância dessa classe, pq o conteúdo sempre vai ser um curso, um artigo ou uma carreira, entao nao tem pq criar um novo conteudo
    {
        public Content(string title, string url)
        // método construtor que tem o mesmo nome da classe.
        {
            Title = title;
            Url = url;
        }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}