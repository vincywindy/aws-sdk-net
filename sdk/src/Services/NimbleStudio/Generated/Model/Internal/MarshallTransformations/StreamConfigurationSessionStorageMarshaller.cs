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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NimbleStudio.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.NimbleStudio.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StreamConfigurationSessionStorage Marshaller
    /// </summary>       
    public class StreamConfigurationSessionStorageMarshaller : IRequestMarshaller<StreamConfigurationSessionStorage, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StreamConfigurationSessionStorage requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetMode())
            {
                context.Writer.WritePropertyName("mode");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectModeListValue in requestObject.Mode)
                {
                        context.Writer.Write(requestObjectModeListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRoot())
            {
                context.Writer.WritePropertyName("root");
                context.Writer.WriteObjectStart();

                var marshaller = StreamingSessionStorageRootMarshaller.Instance;
                marshaller.Marshall(requestObject.Root, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static StreamConfigurationSessionStorageMarshaller Instance = new StreamConfigurationSessionStorageMarshaller();

    }
}