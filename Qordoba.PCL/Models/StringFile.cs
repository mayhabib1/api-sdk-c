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
    public class StringFile : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string id;
        private string fileName;
        private string fileType;
        private List<int> sourceColumns;

        /// <summary>
        /// TODO: 
        /// </summary>
        [JsonProperty("id")]
        public string Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// TODO: 
        /// </summary>
        [JsonProperty("file_name")]
        public string FileName 
        { 
            get 
            {
                return this.fileName; 
            } 
            set 
            {
                this.fileName = value;
                onPropertyChanged("FileName");
            }
        }

        /// <summary>
        /// TODO: 
        /// </summary>
        [JsonProperty("file_type")]
        public string FileType 
        { 
            get 
            {
                return this.fileType; 
            } 
            set 
            {
                this.fileType = value;
                onPropertyChanged("FileType");
            }
        }

        /// <summary>
        /// TODO: 
        /// </summary>
        [JsonProperty("source_columns")]
        public List<int> SourceColumns 
        { 
            get 
            {
                return this.sourceColumns; 
            } 
            set 
            {
                this.sourceColumns = value;
                onPropertyChanged("SourceColumns");
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