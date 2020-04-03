using Asp.NetCore_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Asp.NetCore_WebAPI.Controllers
{
    [Route("api/[Controller]")]
    public class AlunosController : Controller
    {
        private static readonly List<Aluno> _alunos = new List<Aluno>();
        [HttpGet]
        public IActionResult MostrarAlunos()
        {
            return Ok(_alunos);
        }
        [HttpPost("add/{nome}/{nota}/{dataNascimento}/{dataTermino?}")]
        public void AdicionarAluno(string nome, float nota, DateTime dataNascimento, DateTime? dataTermino)
        {
            _alunos.Add(new Aluno
            {
                Nome = nome,
                NotaMedia = nota,
                DataNascimento = dataNascimento,
                DataTermino = dataTermino
            });
        }
        [HttpDelete("delete/{id}")]
        public void RemoverAluno(Guid id)
        {
            _alunos.RemoveAt(_alunos.IndexOf(_alunos.First(x => x.Id.Equals(id))));
        }
    }
}