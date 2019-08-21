using System;

namespace Asp.NetCore_WebAPI.Models
{
    public class Aluno
    {
        public Aluno()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; }
        public String Nome { get; set; }
        public float NotaMedia { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime? DataTermino { get; set; }
    }
}
