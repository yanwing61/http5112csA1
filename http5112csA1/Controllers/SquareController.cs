using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace http5112csA1.Controllers
{

    public class SquareController : ApiController
    {
        /// <summary>
        /// The function lets us know the square of the integer input {id}
        /// </summary>
        /// <param name="id">the integer input</param>
        /// <returns> 
        /// the square of the integer input {id} 
        /// </returns>
        /// <example>
        /// GET: api/Square/2 -> 4
        /// GET: api/Square/-2 -> 4
        /// GET: api/Square/9 -> 81
        /// </example>
        
        [HttpGet]
        public int Square(int id)
        {
            return id * id;
        }

    }
}
