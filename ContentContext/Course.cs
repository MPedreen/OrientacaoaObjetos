using System.Collections.Generic;
using OrientacaoaObjetos.ContentContext.Enums;

namespace OrientacaoaObjetos.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string url)
            : base(title, url)
        {
            Modules = new List<Module>();
            // sempre que criar um objeto dentro um objeto, tem que criar o método construtor e iniciar o objeto, se não da erro na hora de executar. No erro vai falar que os "Modules" são inválidos, nome do erro: "System.NullReferenceException". Erro bem comum no dotnet.
        }
        public string Tag { get; set; }
        //Tag seria o numero do curso, por exemplo, Curso 1 Primeiros passos Linux, Curso 2 Como formatar pc, tag 3, tag 4, etc.
        public IList<Module> Modules { get; set; }
        //Módulos do curso.
        public int DurationInMinutes { get; set; }
        //Duração em minutos do curso.
        public EContentLevel Level { get; set; }
        //level do curso.
    }
}