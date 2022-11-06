using Microsoft.AspNet.OData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ServidorODATA.Controllers
{
    [EnableQuery]
    public class EjercitososController : ODataController
    {
        public IHttpActionResult Get()
        {
            return Ok(EjercitoDataSource.Instance.Ejercitosos.AsQueryable());
        }
    }
}