using AutoMapper;
using Domain.DTO;
using Domain.Entities;
using Domain.IRepository;
using Domain.ViewModel;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;
        public CategoriaService(ICategoriaRepository categoriaRepository, IMapper mapper) 
        {
            this._categoriaRepository = categoriaRepository;
            this._mapper = mapper;
        }

        public IEnumerable<CategoriaDTO> GetAll()
        {
            var categorias = this._categoriaRepository.GetAll();
            var categoriasDTO = _mapper.Map<IEnumerable<CategoriaDTO>>(categorias);
            return categoriasDTO;
        }


        public Categoria GetById(int idCategoria)
        {
            var categoria = _categoriaRepository.GetById(idCategoria);
            return categoria;
            

        }

        //public async Task<bool> Incluir(Categoria categoria)
        //{
        //    this._categoriaRepository.Incluir(categoria);
        //    if(await _categoriaRepository.SaveAllAsync())
        //        return true;
        //    return false;
        //}

        //public async Task<bool> Update(Categoria categoria)
        //{
        //    this._categoriaRepository.Alterar(categoria);
        //    if (await _categoriaRepository.SaveAllAsync())
        //        return true;
        //    return false;
        //}

        //public async Task<bool> Excluir(int id)
        //{
        //    var categoria = await this._categoriaRepository.SelecionarByPK(id);
        //    if (categoria == null) 
        //    {
        //        throw new ArgumentException("categoria nao encontrada");
        //    }
        //    this._categoriaRepository.Excluir(categoria);
        //    if (await _categoriaRepository.SaveAllAsync())
        //        return true;
        //    return false;
        //}

        //public async Task<IEnumerable<Categoria>> SelecionarTodos()
        //{
        //    var categoria = await this._categoriaRepository.SelecionarTodos();
        //    return categoria;
        //}


        //public async Task<CategoriaVM> GetById(int idCategoria)
        //{
        //    var categoria = await this._categoriaRepository.GetById(idCategoria);
        //    return _mapper.Map<CategoriaVM>(categoria);

        //}


    }
}
