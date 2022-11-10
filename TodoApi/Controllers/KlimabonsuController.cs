using Microsoft.AspNetCore.Mvc;
using TodoApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KlimabonsuController : ControllerBase
    {

        IKlimabonusCalculatorService _calculator;

        //Constructor Injection
        public KlimabonsuController(IKlimabonusCalculatorService calculator)
        {
            _calculator = calculator;
        }
        // GET: api/<KlimabonsuController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<KlimabonsuController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<KlimabonsuController>
        [HttpPost]
        public ActionResult Post([FromBody] KlimabonusRequest request)
        {
            //starke Abhängigkeit auf KlimabonsuCalculatorService - strong dependency
            //Lösung DI - Dependency Injection - Service-Klasse wird von Runtime zur Verfügung gesellt
           // KlimabonusCalculatorService _calculator = new KlimabonusCalculatorService();

            /*
            IKlimabonusCalculatorService _calculator =new KlimabonusCalculatorService();
            _calculator = new KlimabonusCalculatorServiceBurgenland();
            _calculator = new KlimabonusCalculatorServiceSteiermark();
            */


            double ergebnis = _calculator.CalcKlimabonus(request);

            return Ok(ergebnis);
        }

       

        // PUT api/<KlimabonsuController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<KlimabonsuController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
