using Domain.DTO;
using Domain.Entities;
using Domain.IRepository;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ICategoriaService
    {
        //Task<bool> Incluir(Categoria categoria);
        //Task<bool> Update(Categoria categoria);
        //Task<bool> Excluir(int id);
        IEnumerable<CategoriaDTO> GetAll();
        Categoria GetById(int idCategoria);

    }
}
