using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCTaskmanager.identity;
using MVCTaskmanager.Models;

namespace MVCTaskmanager.Controllers
{
    public class ClientLocationsController : Controller
    {
        private ApplicationDbContext _db;

        public ClientLocationsController(ApplicationDbContext db)
        {
            this._db = db;
        }

        [HttpGet]
        [Route("api/clientlocations")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult Get()
        {
            List<ClientLocation> clientLocations = _db.ClientLocations.ToList();
            return Ok(clientLocations);
        }

        [HttpGet]
        [Route("api/clientlocations/searchByIdClientlocationId/{ClientLocationID}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult GetByClientLocationID(int ClientLocationID)
        {
            ClientLocation clientLocation = _db.ClientLocations.Where(temp => temp.ClientLocationID == ClientLocationID).FirstOrDefault();  
            if(clientLocation != null)
            {
                return Ok(clientLocation);
            }
            else
            {
                return NoContent();
            }
        }

        [HttpPost]
        [Route("api/clientlocations")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public ClientLocation Post([FromBody] ClientLocation clientLocation)
        {
            _db.ClientLocations.Add(clientLocation);
            _db.SaveChanges();

            ClientLocation existingClientLocation = _db.ClientLocations.Where(temp => temp.ClientLocationID == clientLocation.ClientLocationID).FirstOrDefault();
            return clientLocation;
        }

        [HttpPut]
        [Route("api/clientlocations")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public ClientLocation Put([FromBody] ClientLocation clientLocation)
        {
            ClientLocation existingClientLocation = _db.ClientLocations.Where(temp => temp.ClientLocationID == clientLocation.ClientLocationID).FirstOrDefault();
            if(existingClientLocation != null)
            {
                existingClientLocation.ClientLocationName = clientLocation.ClientLocationName;
                _db.SaveChanges();
                return existingClientLocation;
            }
            else
            {
                return null;
            }
        }

        [HttpDelete]
        [Route("api/clientlocations")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public int Delete(int clientLocationID)
        {
            ClientLocation existingClientLocation = _db.ClientLocations.Where(temp => temp.ClientLocationID == clientLocationID).FirstOrDefault();
            if (existingClientLocation != null)
            {
                _db.ClientLocations.Remove(existingClientLocation);
                _db.SaveChanges();
                return clientLocationID;
            }
            else
            {
                return -1;
            }
        }
    }
}
