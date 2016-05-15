using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using System.Linq;

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
        public Speaker Get(int id)
        {
            return speakerRepository.GetAllSpeakers().FirstOrDefault(s => s.Id == id);
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
