using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Giris.Controllers
{
    public class ValuesController : ApiController
    {

        static List<string> degerler = new List<string>()
        {
            "value0","value1","value2"
        };
        //Convention Based Routing
        // GET api/values
        public IEnumerable<string> Get()
        {
            //return new string[] { "value1", "value2","value3" };
            return degerler;
        }

        [HttpGet]
        public IEnumerable<string> DegerGetir()
        {
            return degerler;
        }

        // GET api/values/5
        public string Get(int id)
        {
            //return "value";
            return degerler[id];
        }
        [HttpGet]
        public string DegerGetir(int id)
        {
            return degerler[id];
        }

        [HttpPost]
        public void DegerOlustur([FromBody]string value)
        {
           degerler.Add(value);
        }
        [HttpPut]
        public void DegerGuncelle(int id, [FromBody]string value)
        {
            degerler[id] = value;
        }

        [HttpDelete]
        public void DegerSil(int id )
        {
            degerler.RemoveAt(id);
        }
        // POST api/values
        public void Post([FromBody]string value)
        {
            degerler.Add(value);
        }



        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            degerler[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            degerler.RemoveAt(id);
        }
    }
}
