/*
 * Tester.PCL
 *
 * This file was automatically generated for Stamplay by APIMATIC v2.0 ( https://apimatic.io ) on 09/15/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tester.PCL;
using Tester.PCL.Http.Request;
using Tester.PCL.Http.Response;
using Tester.PCL.Http.Client;
using Tester.PCL.Models;

namespace Tester.PCL.Controllers
{
    public partial interface IHeaderController
    {
        /// <summary>
        /// Sends a single header params
        /// </summary>
        /// <param name="SendHeadersInput">Object containing request parameters</param>
        /// <return>Returns the ServerResponse response from the API call</return>
        ServerResponse SendHeaders(SendHeadersInput input);

        /// <summary>
        /// Sends a single header params
        /// </summary>
        /// <param name="SendHeadersInput">Object containing request parameters</param>
        /// <return>Returns the ServerResponse response from the API call</return>
        Task<ServerResponse> SendHeadersAsync(SendHeadersInput input);

    }
} 