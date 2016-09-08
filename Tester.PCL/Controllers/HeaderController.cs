/*
 * Tester.PCL
 *
 * This file was automatically generated for Stamplay by APIMATIC v2.0 ( https://apimatic.io ) on 09/08/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tester.PCL;
using Tester.PCL.Http.Request;
using Tester.PCL.Http.Response;
using Tester.PCL.Http.Client;
using Tester.PCL.Exceptions;
using Tester.PCL.Models;

namespace Tester.PCL.Controllers
{
    public partial class HeaderController: BaseController, IHeaderController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static HeaderController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static HeaderController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new HeaderController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Sends a single header params
        /// </summary>
        /// <param name="SendHeadersInput">Object containing request parameters</param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public ServerResponse SendHeaders(SendHeadersInput input)
        {
            Task<ServerResponse> t = SendHeadersAsync(input);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Sends a single header params
        /// </summary>
        /// <param name="SendHeadersInput">Object containing request parameters</param>
        /// <return>Returns the ServerResponse response from the API call</return>
        public async Task<ServerResponse> SendHeadersAsync(SendHeadersInput input)
        {
            //validating required parameters
            if (null == input.CustomHeader)
                throw new ArgumentNullException("customHeader", "The property \"CustomHeader\" in the input object cannot be null.");

            if (null == input.Value)
                throw new ArgumentNullException("mvalue", "The property \"Value\" in the input object cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/header");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "Stamplay SDK" },
                { "accept", "application/json" },
                { "custom-header", input.CustomHeader }
            };

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                { "value", input.Value }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //return null on 404
            if (_response.StatusCode == 404)
                 return null;

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<ServerResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 