﻿using Microsoft.AspNetCore.Mvc;
using WebApp_Tarde.Entidades;

namespace WebApp_Tarde.Controllers
{
    public class CategoriasController : Controller
    {
        private Contexto contexto;
        public CategoriasController(Contexto _contexto)
        {
            this.contexto = _contexto;
        }

        public IActionResult Lista()
        {
            return View(contexto.Categorias.ToList());
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarDados(CategoriaEntidade dados)
        {
            contexto.Categorias.Add(dados);
            contexto.SaveChanges();
            return RedirectToAction("Lista");

        }
    }
}