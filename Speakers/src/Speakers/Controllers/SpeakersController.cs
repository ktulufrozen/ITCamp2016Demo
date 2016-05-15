using System.Collections.Generic;
using Microsoft.AspNet.Mvc;

namespace Speakers.Controllers
{
    [Route("api/[controller]")]
    public class SpeakersController : Controller
    {
        private readonly SpeakerRepository speakerRepository;

        public SpeakersController()
        {
            speakerRepository = new SpeakerRepository();
        }

        [HttpGet]
        public IEnumerable<Speaker> Get()
        {
            return speakerRepository.GetAllSpeakers();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
