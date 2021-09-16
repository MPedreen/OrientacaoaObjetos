namespace OrientacaoaObjetos.ContentContext
{
    public class CareerItem
    //o objeto "CareerItem" serve justamente para ter uma ordem dos cursos, por exemplo, se eu for na classe "Career" e por uma propriedade "public IList<Course> Courses", eu não vou ter uma ordem certa de Cursos, então não sei qual que o aluno tem que fazer primeiro.
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}