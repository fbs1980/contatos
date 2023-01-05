using sistemacontatos.Models;
using System.Collections.Generic;

namespace sistemacontatos.Repositorio
{
    public interface IUsuarioRepositorio
    {

        List<UsuarioModel> BuscarTodos();
        UsuarioModel ListaPorId(int id);
       
        UsuarioModel Adicionar(UsuarioModel usuario);

        UsuarioModel Atualizar(UsuarioModel usuario);
        bool Excluir(int id);
        
    }
}
