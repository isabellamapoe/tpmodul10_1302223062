using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302223062.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa("Francisca Isabella Manope", "1302223062"),
            new Mahasiswa("Muhammad Faqih Ainulyaqin", "1302220086"),
            new Mahasiswa("Helmy Farikh Alfarizhi", "1302220077"),
            new Mahasiswa("Irham Baehaqi", "1302220077"),
            new Mahasiswa("Ayu lestari", "1302223008"),
            new Mahasiswa("Naufal Ammar Zaidan", "1302220052")

        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswaList[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            mahasiswaList.Add(mahasiswa);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            mahasiswaList.RemoveAt(id);
        }

    }
}