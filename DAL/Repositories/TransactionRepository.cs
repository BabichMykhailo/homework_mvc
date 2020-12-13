﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class TransactionRepository
    {
        private readonly WebApplication_A_LEVELContext _ctx;

        public TransactionRepository()
        {
            _ctx = new WebApplication_A_LEVELContext();
        }

        public void Create(Transaction model)
        {
            _ctx.Transactions.Add(model);

            _ctx.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var entity = _ctx.Transactions.FirstOrDefault(x => x.Id == id);
            _ctx.Transactions.Remove(entity);

            _ctx.SaveChanges();
        }

        public Transaction GetById(int id)
        {
            var transaction = _ctx.Transactions.FirstOrDefault(x => x.Id == id);

            return transaction;
        }

        public IEnumerable<Transaction> GetTransactions()
        {
            return _ctx.Transactions.ToList();
        }
    }
}
