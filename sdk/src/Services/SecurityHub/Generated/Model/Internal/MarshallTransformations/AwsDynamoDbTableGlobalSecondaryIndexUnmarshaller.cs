/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsDynamoDbTableGlobalSecondaryIndex Object
    /// </summary>  
    public class AwsDynamoDbTableGlobalSecondaryIndexUnmarshaller : IUnmarshaller<AwsDynamoDbTableGlobalSecondaryIndex, XmlUnmarshallerContext>, IUnmarshaller<AwsDynamoDbTableGlobalSecondaryIndex, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsDynamoDbTableGlobalSecondaryIndex IUnmarshaller<AwsDynamoDbTableGlobalSecondaryIndex, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsDynamoDbTableGlobalSecondaryIndex Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsDynamoDbTableGlobalSecondaryIndex unmarshalledObject = new AwsDynamoDbTableGlobalSecondaryIndex();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Backfilling", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Backfilling = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IndexArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IndexArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IndexName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IndexName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IndexSizeBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.IndexSizeBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IndexStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IndexStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ItemCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ItemCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeySchema", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsDynamoDbTableKeySchema, AwsDynamoDbTableKeySchemaUnmarshaller>(AwsDynamoDbTableKeySchemaUnmarshaller.Instance);
                    unmarshalledObject.KeySchema = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Projection", targetDepth))
                {
                    var unmarshaller = AwsDynamoDbTableProjectionUnmarshaller.Instance;
                    unmarshalledObject.Projection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProvisionedThroughput", targetDepth))
                {
                    var unmarshaller = AwsDynamoDbTableProvisionedThroughputUnmarshaller.Instance;
                    unmarshalledObject.ProvisionedThroughput = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsDynamoDbTableGlobalSecondaryIndexUnmarshaller _instance = new AwsDynamoDbTableGlobalSecondaryIndexUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsDynamoDbTableGlobalSecondaryIndexUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}