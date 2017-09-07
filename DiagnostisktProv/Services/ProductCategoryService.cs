using DiagnostisktProv.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DiagnostisktProv.Services
{
    public class ProductCategoryService
    {
        public SelectList GetSelectList()
        {
            return new SelectList(new List<ProductCategory>
            {
                new ProductCategory { Id = 1, Name = "TV" },
                new ProductCategory { Id = 2, Name = "DVD" },
                new ProductCategory { Id = 3, Name = "VHS" }
            }, "Id", "Name");
        }
    }
}
