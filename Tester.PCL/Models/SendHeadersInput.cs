/*
 * Tester.PCL
 *
 * This file was automatically generated for Stamplay by APIMATIC v2.0 ( https://apimatic.io ) on 09/08/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Tester.PCL;

namespace Tester.PCL.Models
{
    public class SendHeadersInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string customHeader;
        private string mvalue;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("custom-header")]
        public string CustomHeader 
        { 
            get 
            {
                return this.customHeader; 
            } 
            set 
            {
                this.customHeader = value;
                onPropertyChanged("CustomHeader");
            }
        }

        /// <summary>
        /// Represents the value of the custom header
        /// </summary>
        [JsonProperty("value")]
        public string Value 
        { 
            get 
            {
                return this.mvalue; 
            } 
            set 
            {
                this.mvalue = value;
                onPropertyChanged("Value");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 