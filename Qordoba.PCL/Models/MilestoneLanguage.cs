/*
 * Qordoba.PCL
 *
 *   by Qordoba BETA v2.0 on 02/25/2016
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
using Qordoba.PCL;

namespace Qordoba.PCL.Models
{
    public class MilestoneLanguage : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private Milestone milestone;
        private List<Language> languages;

        /// <summary>
        /// TODO: 
        /// </summary>
        [JsonProperty("milestone")]
        public Milestone Milestone 
        { 
            get 
            {
                return this.milestone; 
            } 
            set 
            {
                this.milestone = value;
                onPropertyChanged("Milestone");
            }
        }

        /// <summary>
        /// TODO: 
        /// </summary>
        [JsonProperty("languages")]
        public List<Language> Languages 
        { 
            get 
            {
                return this.languages; 
            } 
            set 
            {
                this.languages = value;
                onPropertyChanged("Languages");
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