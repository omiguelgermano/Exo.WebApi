// auxiliar a coleta no banco de dados e entrga para os controllers

using Exo.WebApi.Contexts;
using Exo.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exo.WebApi.Repositories
{
    public class ProjetoRepository
    {

        private readonly ExoContext _context;
        public ProjetoRepository(ExoContext context)
        {
            _context = context;
        }

        // [HttpGet]
        public List<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }

        //Código complemento do CRUD
        // [HttpGet{"id"}]
        public Projeto BuscarporId(int id)
        {
            return _context.Projetos.Find(id);
        }

        //[HttpPost]
        public void Cadastrar(Projeto projeto)
        {
            _context.Projetos.Add(projeto);
            _context.SaveChanges();
        }

        // [HttpPut]
        public void Atualizar(int id, Projeto projeto)
        {
            Projeto projetoBuscado = _context.Projetos.Find(id);
            if (projetoBuscado != null)
            {
                projetoBuscado.NomeDoProjeto = projeto.NomeDoProjeto;
                projetoBuscado.Area = projeto.Area;
                projetoBuscado.Status = projeto.Status;
            }
            _context.Projetos.Update(projetoBuscado);
            _context.SaveChanges();
        }

        //[HttpDelete]
        public void Deletar(int id)
        {
            Projeto projetoDelBuscado = _context.Projetos.Find(id);
            _context.Projetos.Remove(projetoDelBuscado);
            _context.SaveChanges();
        }
    }
}