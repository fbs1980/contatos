using Microsoft.AspNetCore.Mvc;
using sistemacontatos.Models;
using sistemacontatos.Repositorio;
using System.Collections.Generic;

namespace sistemacontatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }

        //Listar contatos
        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();
            return View(contatos);
        }

        
        public IActionResult Criar()
        {
            return View();
        }


        public IActionResult Editar(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListaPorId(id);
            return View(contato);
        }

        public IActionResult ConfirmacaoExcluir(int id)   
        {
            ContatoModel contato = _contatoRepositorio.ListaPorId(id);
            return View(contato);
        }

        public IActionResult Excluir(int id)
        {
            _contatoRepositorio.Excluir(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            if (ModelState.IsValid)
            {
                _contatoRepositorio.Adicionar(contato);
                return RedirectToAction("Index");
            }

            return View(contato);
        }

        [HttpPost]
        public IActionResult Editar(ContatoModel contato)
        {
            if (ModelState.IsValid)
            {
                _contatoRepositorio.Atualizar(contato);
                return RedirectToAction("Index");
            }

            return View(contato);
        }
    }
}
