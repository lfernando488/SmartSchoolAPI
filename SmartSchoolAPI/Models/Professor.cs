namespace SmartSchoolAPI.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Disciplina { get; set; }

        public Professor()
        {
        }

        public Professor(int id, string nome, string disciplina)
        {
            this.Id = id;
            this.Nome = nome;
            this.Disciplina = disciplina;
        }
    }
}
