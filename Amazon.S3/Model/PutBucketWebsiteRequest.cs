﻿/*******************************************************************************
 *  Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The PutBucketWebsiteRequest contains the parameters used for the PutBucketWebsiteRequest operation.
    /// <br />Required Parameters: BucketName, WebsiteConfiguration.IndexDocumentSuffix
    /// </summary>
    public class PutBucketWebsiteRequest : S3Request
    {
        string _bucketName;
        WebsiteConfiguration _websiteConfiguration;

        #region BucketName

        /// <summary>
        /// Gets and sets the BucketName property.
        /// </summary>
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        /// <summary>
        /// Sets the BucketName property for this request.
        /// This is the S3 Bucket where the website configuration will be put.
        /// </summary>
        /// <param name="bucketName">The value that BucketName is set to</param>
        /// <returns>the request with the BucketName set</returns>
        public PutBucketWebsiteRequest WithBucketName(string bucketName)
        {
            this._bucketName = bucketName;
            return this;
        }

        /// <summary>
        /// Checks if BucketName property is set.
        /// </summary>
        /// <returns>true if BucketName property is set.</returns>
        internal bool IsSetBucketName()
        {
            return !System.String.IsNullOrEmpty(this._bucketName);
        }

        #endregion

        #region WebsiteConfiguration


        /// <summary>
        /// Gets and sets the WebsiteConfiguration property.
        /// 
        /// This is where the index document suffix and custom error page are defined.
        /// </summary>
        public WebsiteConfiguration WebsiteConfiguration
        {
            get 
            {
                if (this._websiteConfiguration == null)
                {
                    this._websiteConfiguration = new WebsiteConfiguration();
                }
                return this._websiteConfiguration; 
            }
            set 
            { 
                this._websiteConfiguration = value; 
            }
        }

        /// <summary>
        /// Sets the WithWebsiteConfiguration property for this request.
        /// </summary>
        /// <param name="config">The value that WithWebsiteConfiguration is set to</param>
        /// <returns>the request with the WebsiteConfiguration set</returns>
        public PutBucketWebsiteRequest WithWebsiteConfiguration(WebsiteConfiguration config)
        {
            this.WebsiteConfiguration = config;
            return this;
        }

        #endregion
    }
}
