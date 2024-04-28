using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TPMOD10;


namespace TPMOD10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>
    {
        new Mahasiswa(" Muhammad Izhar Fahriansyah", "1302220056"),
        new Mahasiswa(" Fauzan Arrizqy Putra", "1302223012"),
        new Mahasiswa(" Fauzan Arrizqy Putra", "1302220004"),
        new Mahasiswa(" Nabiel Ascar Mochamae", "1302220080")
    };
        [HttpGet]




        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            listMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMahasiswa.RemoveAt(id);
        }
    }

}
