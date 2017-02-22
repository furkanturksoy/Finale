using Finale.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Finale.UI.Controllers
{
    public class CategoryApiController : ApiController
    {
        FinaleContext service;
        public CategoryApiController()
        {
            service = new FinaleContext();
        }

        [HttpGet]
        [Route("api/categories")]
        public List<string> Categories()
        {
            List<string> categories = service.Categorie.SelectMany(x => new List<string>
            {
                x.CategoryName
            }).ToList();

            return categories;
        }
    }
}
