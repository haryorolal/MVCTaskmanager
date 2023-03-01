using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCTaskmanager.identity;
using MVCTaskmanager.Models;

namespace MVCTaskmanager.Controllers
{
    public class CountriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CountriesController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        [Route("api/countries")]
        public IActionResult GetCountries()
        {
            List<country> countries = _db.Countries.OrderBy(temp => temp.CountryName).ToList(); 

            return Ok(countries);
        }

        [HttpGet]
        [Route("api/countries/searchBycountryid/{CountryID}")]
        public IActionResult GetCountriesById(int CountryID)
        {
            country country = _db.Countries.Where(temp => temp.CountryID == CountryID).FirstOrDefault();
            if(country != null)
            {
                return Ok(country);
            }
            else
            {
                return NoContent();
            }
        }

        [HttpPost]
        [Route("api/countries")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public country Post([FromBody] country country)
        {
            _db.Countries.Add(country);
            _db.SaveChanges();

            country existingCountry = _db.Countries.Where(temp => temp.CountryID == country.CountryID).FirstOrDefault();
            
            return existingCountry;
        }

        [HttpPut]
        [Route("api/countries")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public country Put([FromBody] country country)
        {
            country existingCountry = _db.Countries.Where(temp => temp.CountryID == country.CountryID).FirstOrDefault();

            if(existingCountry != null)
            {
                existingCountry.CountryName = country.CountryName;
                _db.SaveChanges();
                return existingCountry;
            }
            else
            {
                return null;
            }
            
        }

        [HttpDelete]
        [Route("api/countries")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public int Delete(int countryID)
        {
            country existingCountry = _db.Countries.Where(temp => temp.CountryID == countryID).FirstOrDefault();
            if(existingCountry != null)
            {
                _db.Countries.Remove(existingCountry);
                _db.SaveChanges();
                return countryID;
            }
            else
            {
                return -1;
            }
        }


    }
}
