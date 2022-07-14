using CadastrosProdutos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AspNetWebApiRest.Controllers
{
    public abstract class ControllerBase<TModel, TAppService> : ApiController
        where TModel : class
        where TAppService : ICadastroAppService<TModel>
    {

        protected IHttpActionResult IsValid(TModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok();
        }
    }
}