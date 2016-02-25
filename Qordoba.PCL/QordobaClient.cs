/*
 * Qordoba.PCL
 *
 *   by Qordoba BETA v2.0 on 02/25/2016
 */
using System;
using Qordoba.PCL.Controllers;

namespace Qordoba.PCL
{
    public partial class QordobaClient
    {

        /// <summary>
        /// Singleton access to Qordoba controller
        /// </summary>
        public QordobaController Qordoba
        {
            get
            {
                return QordobaController.Instance;
            }
        }

        /// <summary>
        /// Client constructor
        /// </summary>
        public QordobaClient(string basicAuthUserName, string basicAuthPassword)
        {
            Configuration.BasicAuthUserName = basicAuthUserName;
            Configuration.BasicAuthPassword = basicAuthPassword;
        }
    }
}