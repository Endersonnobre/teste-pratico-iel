using teste_pratico_iel.Context;
using teste_pratico_iel.Models;
using System.Collections.Generic;
namespace teste_pratico_iel.Repository
{
    public class EstudanteRepository
    {
        public readonly IELContext _context;

        public EstudanteRepository(IELContext context)
        {
            _context = context;
        }

        public List<Estado> ListarEstados()
        {
            return _context.Estados.ToList();
        }

        public List<Cidade> ListarCidades()
        {
            return _context.Cidades.ToList();
        }

        public List<Instituicao> ListarInstituicoes()
        {
            return _context.Instituicoes.ToList();
        }

        public List<Estudante> ListarEstudantes()
        {
            return _context.Estudantes.ToList();
        }

        public List<Estudante> BuscaEstudantePorNome(string name)
        {
            return _context.Estudantes.Where(c => c.Nome.Contains(name)).ToList();
        }

        public void CadastrarEstudante(Estudante estudante)
        {
            _context.Estudantes.Add(estudante);
            _context.SaveChanges();
        }

        public void RemoverEsudante(int id)
        {
            var estudante = _context.Estudantes.Find(id);
            if(estudante != null)
            {
                _context.Estudantes.Remove(estudante);
                _context.SaveChanges();
            }  
        }
    }
}
