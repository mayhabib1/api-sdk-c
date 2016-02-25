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
    public class Project : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string name;
        private int sourceLanguage;
        private int contentType;
        private string organizationId;
        private List<int> targetLanguages;
        private List<MilestoneLanguage> milestones;
        private List<StringFile> stringFiles;

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
        [JsonProperty("source_language")]
        public int SourceLanguage 
        { 
            get 
            {
                return this.sourceLanguage; 
            } 
            set 
            {
                this.sourceLanguage = value;
                onPropertyChanged("SourceLanguage");
            }
        }

        /// <summary>
        /// TODO: 
        /// </summary>
        [JsonProperty("content_type")]
        public int ContentType 
        { 
            get 
            {
                return this.contentType; 
            } 
            set 
            {
                this.contentType = value;
                onPropertyChanged("ContentType");
            }
        }

        /// <summary>
        /// TODO: 
        /// </summary>
        [JsonProperty("organization_id")]
        public string OrganizationId 
        { 
            get 
            {
                return this.organizationId; 
            } 
            set 
            {
                this.organizationId = value;
                onPropertyChanged("OrganizationId");
            }
        }

        /// <summary>
        /// TODO: 
        /// </summary>
        [JsonProperty("target_languages")]
        public List<int> TargetLanguages 
        { 
            get 
            {
                return this.targetLanguages; 
            } 
            set 
            {
                this.targetLanguages = value;
                onPropertyChanged("TargetLanguages");
            }
        }

        /// <summary>
        /// TODO: 
        /// </summary>
        [JsonProperty("milestones")]
        public List<MilestoneLanguage> Milestones 
        { 
            get 
            {
                return this.milestones; 
            } 
            set 
            {
                this.milestones = value;
                onPropertyChanged("Milestones");
            }
        }

        /// <summary>
        /// TODO: 
        /// </summary>
        [JsonProperty("string_files")]
        public List<StringFile> StringFiles 
        { 
            get 
            {
                return this.stringFiles; 
            } 
            set 
            {
                this.stringFiles = value;
                onPropertyChanged("StringFiles");
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