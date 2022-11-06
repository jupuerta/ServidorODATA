using Microsoft.AspNet.OData;
using System.Linq;
using System.Web.Http;

namespace ServidorODATA.Controllers
{
    [EnableQuery]
    public class EjercitoController : ODataController
    {
        public IHttpActionResult Get()
        {
            return Ok(EjercitoDataSource.Instance.Ejercitosos.AsQueryable());
        }
    }
}