namespace ConsoleApp4
{
    public class Agenda
    {
        public Agenda(string nome, string telefone, int idade, string sexo)
        {
            Nome = nome;
            Telefone = telefone;
            Idade = idade;
            Sexo = sexo;
        }

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
    }
}
