// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies any dependencies of a task. Any task that is explicitly specified or within a dependency range must complete 
    /// before the dependant task will be scheduled.
    /// </summary>
    public partial class TaskDependencies : ITransportObjectProvider<Models.TaskDependencies>, IPropertyMetadata
    {
        #region Constructors

        internal TaskDependencies(Models.TaskDependencies protocolObject)
        {
            this.TaskIdRanges = TaskIdRange.ConvertFromProtocolCollectionReadOnly(protocolObject.TaskIdRanges);
            this.TaskIds = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.TaskIds, o => o.ToList().AsReadOnly());
        }

        #endregion Constructors

        #region TaskDependencies

        /// <summary>
        /// Gets the list of task IDs that this task depends on. All tasks in this list must complete successfully before 
        /// the dependent task can be scheduled.
        /// </summary>
        public IReadOnlyList<TaskIdRange> TaskIdRanges { get; }

        /// <summary>
        /// Gets the list of task ID ranges that this task depends on. All tasks in all ranges must complete successfully 
        /// before the dependent task can be scheduled.
        /// </summary>
        public IReadOnlyList<string> TaskIds { get; }

        #endregion // TaskDependencies

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata

        #region Internal/private methods

        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.TaskDependencies ITransportObjectProvider<Models.TaskDependencies>.GetTransportObject()
        {
            Models.TaskDependencies result = new Models.TaskDependencies()
            {
                TaskIdRanges = UtilitiesInternal.ConvertToProtocolCollection(this.TaskIdRanges),
                TaskIds = UtilitiesInternal.CreateObjectWithNullCheck(this.TaskIds, o => o.ToList()),
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}