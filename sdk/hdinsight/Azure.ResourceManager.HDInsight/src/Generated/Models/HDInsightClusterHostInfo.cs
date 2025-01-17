// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The cluster host information. </summary>
    public partial class HDInsightClusterHostInfo
    {
        /// <summary> Initializes a new instance of <see cref="HDInsightClusterHostInfo"/>. </summary>
        internal HDInsightClusterHostInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterHostInfo"/>. </summary>
        /// <param name="name"> The host name. </param>
        /// <param name="fqdn"> The Fully Qualified Domain Name of host. </param>
        /// <param name="effectiveDiskEncryptionKeyUri"> The effective disk encryption key URL used by the host. </param>
        internal HDInsightClusterHostInfo(string name, string fqdn, Uri effectiveDiskEncryptionKeyUri)
        {
            Name = name;
            Fqdn = fqdn;
            EffectiveDiskEncryptionKeyUri = effectiveDiskEncryptionKeyUri;
        }

        /// <summary> The host name. </summary>
        public string Name { get; }
        /// <summary> The Fully Qualified Domain Name of host. </summary>
        public string Fqdn { get; }
        /// <summary> The effective disk encryption key URL used by the host. </summary>
        public Uri EffectiveDiskEncryptionKeyUri { get; }
    }
}
