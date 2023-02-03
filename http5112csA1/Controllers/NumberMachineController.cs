using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace http5112csA1.Controllers
{
    public class NumberMachineController : ApiController
    {

        /// <summary>
        /// The function lets us know the result of the integer input {id} with four mathematical operations
        /// </summary>
        /// <param name="id">the integer input</param>
        /// <returns>the result of {id} / 2 + ({id} - 5) * 100</returns>
        /// <example>
        /// GET: api/NumberMachine/10 -> 505
        /// GET: api/NumberMachine/-5 -> -1002
        /// GET: api/NumberMachine/0 -> -500
        /// </example>
        
        [HttpGet]
        public int NumberMachine(int id)
        {
            return id / 2 + (id - 5) * 100;
        }
    }
}
