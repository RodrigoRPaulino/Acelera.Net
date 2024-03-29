﻿using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;



namespace WebApplication2.Controllers
{
    public class LivroController : Controller
    {
        Data.ContextoDB contexto = new Data.ContextoDB();

        public IActionResult Index()
        {
            var livros = contexto.Livros.ToList();

            return View(livros);
        }



        [HttpPost]
        public IActionResult Index(LivroModel book)
        {
            contexto.Livros.Add(book);

            contexto.SaveChanges();

            var livrosDB = contexto.Livros.ToList();

            return View(livrosDB);
        }

        public IActionResult Cadastra()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastra(LivroModel livros)
        {
            contexto.Add(livros);
            return View(livros);
        }



    }
}