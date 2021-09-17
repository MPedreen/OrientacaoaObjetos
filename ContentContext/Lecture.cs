using OrientacaoaObjetos.ContentContext.Enums;

namespace OrientacaoaObjetos.ContentContext
{
    public class Lecture : Base
    //Lecture são as aulas do curso.
    {
        public int Order { get; set; }
        //ordem da aula.
        public string Title { get; set; }
        //título da aula.
        public int DurationInMinutes { get; set; }
        //duração da aula.
        public EContentLevel Level { get; set; }
        //level da aula.
    }
}