/*
 * Tester.PCL
 *
 * This file was automatically generated for Stamplay by APIMATIC v2.0 ( https://apimatic.io ) on 09/15/2016
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
    public class SimpleQueryInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private bool boolean;
        private int number;
        private string mstring;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("boolean")]
        public bool Boolean 
        { 
            get 
            {
                return this.boolean; 
            } 
            set 
            {
                this.boolean = value;
                onPropertyChanged("Boolean");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("number")]
        public int Number 
        { 
            get 
            {
                return this.number; 
            } 
            set 
            {
                this.number = value;
                onPropertyChanged("Number");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("string")]
        public string String 
        { 
            get 
            {
                return this.mstring; 
            } 
            set 
            {
                this.mstring = value;
                onPropertyChanged("String");
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