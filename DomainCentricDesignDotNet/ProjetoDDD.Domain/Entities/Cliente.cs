﻿using System;

namespace ProjetoDDD.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}
