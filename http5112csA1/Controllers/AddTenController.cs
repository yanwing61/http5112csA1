using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace http5112csA1.Controllers
{

    /// <summary>
    /// The function lets us know the result of 10 more than the integer input {id}
    /// </summary>
    /// <param name="id"> 
    /// the integer input 
    /// </param>
    /// <returns> 
    /// 10 more than the integer input {id} 
    /// </returns>
    /// <example>
    /// GET: api/AddTen/21 -> 31
    /// GET: api/AddTen/0 -> 10
    /// GET: api/AddTen/-9 -> 1
    /// </example>
    public class AddTenController : ApiController
    {
        [HttpGet]
        public int AddTen(int id)
        {
            return id + 10;
        }
    }
}
