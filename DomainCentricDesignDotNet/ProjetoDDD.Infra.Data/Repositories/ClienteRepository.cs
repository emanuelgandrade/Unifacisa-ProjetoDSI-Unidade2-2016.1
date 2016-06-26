﻿using ProjetoDDD.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Infra.Data.Entity;

namespace ProjetoDDD.Infra.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private BancoDeDados bd = new BancoDeDados();

        public void AdicionaCliente(Cliente cliente)
        {
            bd.Clientes.Add(cliente);
            bd.SaveChanges();
        }

        public void AtualizaCliente(Cliente cliente)
        {
            bd.Clientes.Add(cliente);
            bd.SaveChanges();
        }

        public void DefinirClienteVip()
        {
            throw new NotImplementedException();
        }
        
        public List<Cliente> ObtemTodos()
        {
            return bd.Clientes.ToList();
        }

        public Cliente ObterCliente(int id)
        {
            return bd.Clientes.Find(id);
        }

        public void RemoveCliente(int id)
        {
            bd.Clientes.Remove(bd.Clientes.Find(id));
            bd.SaveChanges();
        }
    }
}