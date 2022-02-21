namespace TesteArq.Domain.Entity
{
    public class Curso : BaseEntity
    {
        public Curso(String name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}