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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataExchange.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataExchange.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportAssetFromApiGatewayApiRequestDetails Marshaller
    /// </summary>       
    public class ImportAssetFromApiGatewayApiRequestDetailsMarshaller : IRequestMarshaller<ImportAssetFromApiGatewayApiRequestDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ImportAssetFromApiGatewayApiRequestDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetApiDescription())
            {
                context.Writer.WritePropertyName("ApiDescription");
                context.Writer.Write(requestObject.ApiDescription);
            }

            if(requestObject.IsSetApiId())
            {
                context.Writer.WritePropertyName("ApiId");
                context.Writer.Write(requestObject.ApiId);
            }

            if(requestObject.IsSetApiKey())
            {
                context.Writer.WritePropertyName("ApiKey");
                context.Writer.Write(requestObject.ApiKey);
            }

            if(requestObject.IsSetApiName())
            {
                context.Writer.WritePropertyName("ApiName");
                context.Writer.Write(requestObject.ApiName);
            }

            if(requestObject.IsSetApiSpecificationMd5Hash())
            {
                context.Writer.WritePropertyName("ApiSpecificationMd5Hash");
                context.Writer.Write(requestObject.ApiSpecificationMd5Hash);
            }

            if(requestObject.IsSetDataSetId())
            {
                context.Writer.WritePropertyName("DataSetId");
                context.Writer.Write(requestObject.DataSetId);
            }

            if(requestObject.IsSetProtocolType())
            {
                context.Writer.WritePropertyName("ProtocolType");
                context.Writer.Write(requestObject.ProtocolType);
            }

            if(requestObject.IsSetRevisionId())
            {
                context.Writer.WritePropertyName("RevisionId");
                context.Writer.Write(requestObject.RevisionId);
            }

            if(requestObject.IsSetStage())
            {
                context.Writer.WritePropertyName("Stage");
                context.Writer.Write(requestObject.Stage);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ImportAssetFromApiGatewayApiRequestDetailsMarshaller Instance = new ImportAssetFromApiGatewayApiRequestDetailsMarshaller();

    }
}