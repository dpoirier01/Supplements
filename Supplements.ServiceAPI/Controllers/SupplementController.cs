using Supplements.ServiceAPI.Models.DTO;
using Supplements.ServiceAPI.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Supplements.ServiceAPI.Controllers
{
    public class SupplementController : ApiController
    {
        SupplementContextEntities _db = new SupplementContextEntities();

        [HttpGet]
        [Route("api/Supplement/GetSupplements")]
        [ResponseType(typeof(SupplementTypeDTO))]
        public IEnumerable<SupplementTypeDTO> GetSupplements()
        {
            var supplements = (from s in _db.SupplementTypes
                              select new SupplementTypeDTO()
                              {
                                  Id = s.ID,
                                  Name = s.Name,
                                  Distributer = s.Distributer,
                                  IsThirdPartyTesting = s.ThirdPartyTesting
                              }).ToList();
            return supplements;
        }

        [HttpPost]
        [Route("api/Supplement/CreateSupplement")]
        [ResponseType(typeof(HttpResponseMessage))]
        public HttpResponseMessage CreateSupplement([FromBody] SupplementTypeDTO supplements)
        {
            try
            {
                var supplement = new Models.EF.SupplementType();
                supplement.Name = supplements.Name;
                supplement.Distributer = supplements.Distributer;
                supplement.ThirdPartyTesting = supplements.IsThirdPartyTesting;
                _db.SupplementTypes.Add(supplement);

                if (_db.SaveChanges() > 0)
                {
                    return Request.CreateResponse(HttpStatusCode.Created);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "A problem was encountered saving this category.");
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.ToString());
            }
        }

    }
}
