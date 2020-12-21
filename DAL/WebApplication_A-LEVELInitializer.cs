﻿using Bogus;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WebApplication_A_LEVELInitializer : CreateDatabaseIfNotExists<WebApplication_A_LEVELContext>
    {
        public void Initialize(WebApplication_A_LEVELContext context)
        {
            var faker = new Faker();

            var transactionBogus = new Faker<Transaction>()
                .RuleFor(c => c.Title, f => f.Lorem.Word())
                .RuleFor(c => c.Description, f => f.Lorem.Paragraph())
                .RuleFor(c => c.Value, f => f.Random.Decimal() + f.Random.Number(-100000, 100000))
                .RuleFor(c => c.CreatedDate, f => DateTime.Now)
                .RuleFor(c => c.UpdatedDate, f => DateTime.Now);

            var transactions = transactionBogus.Generate(faker.Random.Number(20, 30));

            var categoryBogus = new Faker<Category>()
                .RuleFor(c => c.Title, f => f.Lorem.Word())
                .RuleFor(c => c.CreatedDate, f => DateTime.Now)
                .RuleFor(c => c.UpdatedDate, f => DateTime.Now);

            var categories = categoryBogus.Generate(faker.Random.Number(20, 30));

            context.Categories.AddRange(categories);
            context.Transactions.AddRange(transactions);
            context.SaveChanges();
        }

        protected override void Seed(WebApplication_A_LEVELContext ctx)
        {
            Initialize(ctx);
        }
    }
}
