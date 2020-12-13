using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_A_LEVEL.Models.Category
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}