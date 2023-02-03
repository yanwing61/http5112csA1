using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace http5112csA1.Controllers
{
    public class GreetingController : ApiController
    {

        /// <summary>
        /// Received the POST request and display "Hello World!"
        /// </summary>
        /// <returns> A string "Hello World!"</returns>
        /// <example>
        /// POST: api/Greeting -> "Hello World!"
        /// </example>
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// The function returns the string “Greetings to {id} people!” where id is an integer value
        /// </summary>
        /// <param name="id">the integer input</param>
        /// <returns> string "Greetings to {id} people!"</returns>
        /// <example>
        /// GET localhost/Greeting/3 -> Greetings to 3 people!
        /// GET localhost/Greeting/6 -> Greetings to 6 people!
        /// GET localhost/Greeting/0 -> Greetings to 0 people!
        /// </example>
        public string Get(int id)
        {
            return "Greetings to " + id.ToString() + " people!";
        }

    }
}
