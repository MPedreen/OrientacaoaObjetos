using System.Collections.Generic;

namespace OrientacaoaObjetos.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url)
            : base(title, url)
        {
            Items = new List<CareerItem>();
            //inicializando a lista Items. (Sempre que for usar lista, tem que iniciar a mesma)
        }
        public IList<CareerItem> Items { get; set; }
        //lista dos Cursos. Cada item tem 1 curso.
        public int TotalCourses
        // nessa propriedade, eu tirei o "set" pois não quero setar a quantidade de cursos, por exemplo: var career = new Career(); career.TotalCourses = 25; O total de cursos tem que ser o resultado da contagem de Items.
        //Quando só temos 1 linha dentro do get, da para usar o Expression Body, ficando assim: public int TotalCourses => Items.Count;

        {
            get
            {
                return Items.Count;
            }
        }
    }
}