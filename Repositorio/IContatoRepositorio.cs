using sistemacontatos.Models;
using System.Collections.Generic;

namespace sistemacontatos.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel ListaPorId(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);

        ContatoModel Atualizar(ContatoModel contato);
        bool Excluir(int id);
        
    }
}
