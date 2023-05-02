using Data.Context;
using Domain.DTO;
using Domain.Entities;
using Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {

        public CategoriaRepository(AppDbContext appDbContext) : base(appDbContext) { }

        //public void Incluir(Categoria categoria)
        //{
        //    _context.Categoria.Add(categoria);
        //}

        //public void Alterar(Categoria categoria)
        //{
        //    _context.Entry(categoria).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //}

        //public void Excluir(Categoria categoria)
        //{
        //    _context.Categoria.Remove(categoria);
        //}

        //public async Task<Categoria> SelecionarByPK(int id)
        //{
        //    var categoria = await _context.Categoria.Where(c => c.Id == id).FirstOrDefaultAsync();
        //    return categoria;
        //}

        //public async Task<IEnumerable<Categoria>> SelecionarTodos() //GetAll
        //{
        //    return await _context.Categoria.ToListAsync();
        //}


        //public async Task<CategoriaDTO> GetById(int id)
        //{
        //    //var query = (from c in _context.Categoria where c.Id == id select c)
        //    //    .Select(ca => new CategoriaDTO() { Descricao = ca.Descricao, Id = ca.Id }).SingleOrDefaultAsync();

        //    //return await query;

        //    var categoria = await _context.Categoria.Where(c => c.Id == id)
        //        .Select(ca => new CategoriaDTO() { Descricao = ca.Descricao, Id = ca.Id }).SingleOrDefaultAsync();
        //    return categoria;

        //}

        //public async Task<bool> SaveAllAsync()
        //{
        //    return await _context.SaveChangesAsync() > 0;

        //}

    }
}
