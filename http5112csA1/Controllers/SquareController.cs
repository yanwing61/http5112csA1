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
        /// It returns the square of the integer input {id}
        /// </summary>
        /// <param name="id">the integer input</param>
        /// <returns> the square of the integer input {id} </returns>
        /// <example>
        /// GET localhost/Square/2 -> 4
        /// GET localhost/Square/-2 -> 4
        /// GET localhost/Square/9 -> 81
        /// </example>
        [HttpGet]
        public int Square(int id)
        {
            return id * id;
        }

    }
}
