/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// This is the response object from the ListLicenseManagerReportGenerators operation.
    /// </summary>
    public partial class ListLicenseManagerReportGeneratorsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ReportGenerator> _reportGenerators = new List<ReportGenerator>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token for the next set of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ReportGenerators. 
        /// <para>
        /// A report generator that creates periodic reports on your license configurations.
        /// </para>
        /// </summary>
        public List<ReportGenerator> ReportGenerators
        {
            get { return this._reportGenerators; }
            set { this._reportGenerators = value; }
        }

        // Check to see if ReportGenerators property is set
        internal bool IsSetReportGenerators()
        {
            return this._reportGenerators != null && this._reportGenerators.Count > 0; 
        }

    }
}