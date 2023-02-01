using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace http5112csA1.Controllers
{

    /// <summary>
    /// It returns 10 more than the integer input {id}
    /// </summary>
    /// <param name="id">the integer input</param>
    /// <returns> 10 more than the integer input {id} </returns>
    /// <example>
    /// GET localhost/AddTen/21 -> 31
    /// GET localhost/AddTen/0 -> 10
    /// GET localhost/AddTen/-9 -> 1
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
