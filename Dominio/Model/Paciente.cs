namespace Domain.Model
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sintoma { get; set; }
        public string Email { get; set; }
        public string Plano { get; set; }

        public Paciente(int id, string nome, int idade, string sintoma, string email, string plano)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Sintoma = sintoma;
            Email = email;
            Plano = plano;
        }

        public Paciente()
        {
        }
    }
}