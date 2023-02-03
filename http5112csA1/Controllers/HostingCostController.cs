using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace http5112csA1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// The function lets us know the cost of web hosting and maintainance.
        /// </summary>
        /// <param name="id"> 
        /// It represents the number of days which has elapsed since the beginning of the hosting.
        /// Input by user.
        /// </param>
        /// <returns>
        /// Output 3 strings which describe the total hosting cost,
        /// where 1 fortnight = 14 days {var FN}, with a minium value of 1 {var stay}
        /// plus an additional 13% HST {var HSTtotal}.
        /// all values round up to 2 demical place.
        /// </returns>
        /// <example>
        /// GET: api/HostingCost/0 ->
        ///     “1 fortnights at $5.50/FN = $5.5 CAD”  “HST 13% = $0.72 CAD”   “Total = $6.22 CAD”
        /// GET: api/HostingCost/14 ->
        ///     “2 fortnights at $5.50/FN = $11 CAD”  “HST 13% = $1.43 CAD”   “Total = $12.43 CAD”
        /// GET: api/HostingCost/15 ->
        ///     “2 fortnights at $5.50/FN = $11 CAD”  “HST 13% = $1.43 CAD”   “Total = $12.43 CAD”
        /// GET: api/HostingCost/21 ->
        ///     “2 fortnights at $5.50/FN = $11 CAD”  “HST 13% = $1.43 CAD”   “Total = $12.43 CAD”
        /// GET: api/HostingCost/28 ->
        ///     “3 fortnights at $5.50/FN = $16.5 CAD”  “HST 13% = $2.14 CAD”   “Total = $18.64 CAD”
        /// </example>

        [HttpGet]
        public IEnumerable<string> Get(int id)
        {
            int FN = 14;
            double rate = 5.5;
            double HST = 0.13;
            int stay = (id / FN) + 1;
            double subtotal = Math.Round(stay * rate, 2);
            double HSTtotal = Math.Round(subtotal * HST, 2);
            double total = Math.Round(subtotal + HSTtotal, 2);

            return new string[] 
            { stay + " fortnights at $5.50/FN = $" + subtotal + " CAD", 
                "HST 13% = $" + HSTtotal + " CAD",
                "Total = $" + total + " CAD"};
        }

    }
}
