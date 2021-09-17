using System.Collections.Generic;
using OrientacaoaObjetos.SharedContext;

namespace OrientacaoaObjetos.ContentContext
{
    public class Module : Base
    //Módulos do curso, 1 curso tem vários modulos e 1 módulo tem varias aulas.
    {
        public Module()
        {
            Lectures = new List<Lecture>();
            //inicializando o método Lectures para não correr risco de ficar nulo, igual fiz com o "Modules".
        }
        public int Order { get; set; }
        // ordem do módulo, modulo 1,2,3,4 e assim vai.
        public string Title { get; set; }
        //título do módulo.
        public IList<Lecture> Lectures { get; set; }
        //aulas do módulo.
    }
}

