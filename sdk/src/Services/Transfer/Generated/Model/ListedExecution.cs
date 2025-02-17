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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Returns properties of the execution that is specified.
    /// </summary>
    public partial class ListedExecution
    {
        private string _executionId;
        private FileLocation _initialFileLocation;
        private ServiceMetadata _serviceMetadata;
        private ExecutionStatus _status;

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// A unique identifier for the execution of a workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ExecutionId
        {
            get { return this._executionId; }
            set { this._executionId = value; }
        }

        // Check to see if ExecutionId property is set
        internal bool IsSetExecutionId()
        {
            return this._executionId != null;
        }

        /// <summary>
        /// Gets and sets the property InitialFileLocation. 
        /// <para>
        /// A structure that describes the Amazon S3 or EFS file location. This is the file location
        /// when the execution begins: if the file is being copied, this is the initial (as opposed
        /// to destination) file location.
        /// </para>
        /// </summary>
        public FileLocation InitialFileLocation
        {
            get { return this._initialFileLocation; }
            set { this._initialFileLocation = value; }
        }

        // Check to see if InitialFileLocation property is set
        internal bool IsSetInitialFileLocation()
        {
            return this._initialFileLocation != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceMetadata. 
        /// <para>
        /// A container object for the session details associated with a workflow.
        /// </para>
        /// </summary>
        public ServiceMetadata ServiceMetadata
        {
            get { return this._serviceMetadata; }
            set { this._serviceMetadata = value; }
        }

        // Check to see if ServiceMetadata property is set
        internal bool IsSetServiceMetadata()
        {
            return this._serviceMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status is one of the execution. Can be in progress, completed, exception encountered,
        /// or handling the exception.
        /// </para>
        /// </summary>
        public ExecutionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}