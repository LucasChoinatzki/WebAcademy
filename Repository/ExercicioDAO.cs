using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class ExercicioDAO : IRepository<Exercicio>
    {

        private readonly Context ctx;
        public ExercicioDAO(Context context)
        {
            ctx = context;
        }


        public bool Cadastrar(Exercicio ex)
        {
            ctx.Exercicios.Add(ex);
            ctx.SaveChanges();
            return true;
        }
        public List<Exercicio> ListarTodos()
        {
            return ctx.Exercicios.ToList();
        }


        public List<Exercicio> ListarporLista(ListaTreino listaTreino)
        {
            return ctx.Exercicios.Include(x => x.ListaTreino).Include(x => x.Equipamento).Include(x => x.Quantidade).Include(x => x.Repeticoes).Where(x => x.ListaTreino == listaTreino).ToList();
            
        }
        public Exercicio BuscarPorId(int id)
        {
            return ctx.Exercicios.Find(id);
        }

    }
}
