using teste_pratico_iel.Models;

namespace teste_pratico_iel.Models
{
    public class Estudante
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public Cidade Cidade { get; set; }
        public Estado Estado { get; set; }
        public Instituicao Instituicao { get; set; }
        public string NomeCurso { get; set; }
        public DateTime DataConclusao { get; set; }

    }
}
