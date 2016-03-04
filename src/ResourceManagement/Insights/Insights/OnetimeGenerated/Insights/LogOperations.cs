// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

// IMPORTANT: This code was machine generated and then modified by humans.
// Updating this file with the machine generated one might overwrite important changes. 
// Please review and revert unintended changes carefully.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Insights;
using Microsoft.Azure.Insights.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Insights
{
    /// <summary>
    /// Operations for logs.
    /// </summary>
    internal partial class LogOperations : IServiceOperations<InsightsClient>, ILogOperations
    {
        /// <summary>
        /// Initializes a new instance of the LogOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal LogOperations(InsightsClient client)
        {
            this._client = client;
        }

        private InsightsClient _client;

        /// <summary>
        /// Gets a reference to the Microsoft.Azure.Insights.InsightsClient.
        /// </summary>
        public InsightsClient Client
        {
            get { return this._client; }
        }
    }
}