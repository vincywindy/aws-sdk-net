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
    /// Response Unmarshaller for AwsRdsDbSubnetGroup Object
    /// </summary>  
    public class AwsRdsDbSubnetGroupUnmarshaller : IUnmarshaller<AwsRdsDbSubnetGroup, XmlUnmarshallerContext>, IUnmarshaller<AwsRdsDbSubnetGroup, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsRdsDbSubnetGroup IUnmarshaller<AwsRdsDbSubnetGroup, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsRdsDbSubnetGroup Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsRdsDbSubnetGroup unmarshalledObject = new AwsRdsDbSubnetGroup();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DbSubnetGroupArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbSubnetGroupArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DbSubnetGroupDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbSubnetGroupDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DbSubnetGroupName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbSubnetGroupName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubnetGroupStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubnetGroupStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Subnets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRdsDbSubnetGroupSubnet, AwsRdsDbSubnetGroupSubnetUnmarshaller>(AwsRdsDbSubnetGroupSubnetUnmarshaller.Instance);
                    unmarshalledObject.Subnets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsRdsDbSubnetGroupUnmarshaller _instance = new AwsRdsDbSubnetGroupUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsRdsDbSubnetGroupUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}