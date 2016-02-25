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
    public class Milestone : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int milestoneId;
        private string name;
        private int order;

        /// <summary>
        /// TODO: 
        /// </summary>
        [JsonProperty("milestone_id")]
        public int MilestoneId 
        { 
            get 
            {
                return this.milestoneId; 
            } 
            set 
            {
                this.milestoneId = value;
                onPropertyChanged("MilestoneId");
            }
        }

        /// <summary>
        /// TODO: 
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// TODO: 
        /// </summary>
        [JsonProperty("order")]
        public int Order 
        { 
            get 
            {
                return this.order; 
            } 
            set 
            {
                this.order = value;
                onPropertyChanged("Order");
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