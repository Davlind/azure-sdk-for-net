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

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Optional. Specifies the SSH public keys and key pairs to populate in
    /// the image during provisioning. This element is only used with the
    /// LinuxProvisioningConfiguration set.
    /// </summary>
    public partial class SshSettings
    {
        private IList<SshSettingKeyPair> _keyPairs;
        
        /// <summary>
        /// Optional. Specifies the collection of SSH public keys.
        /// </summary>
        public IList<SshSettingKeyPair> KeyPairs
        {
            get { return this._keyPairs; }
            set { this._keyPairs = value; }
        }
        
        private IList<SshSettingPublicKey> _publicKeys;
        
        /// <summary>
        /// Optional. Specifies the collection of SSH public keys.
        /// </summary>
        public IList<SshSettingPublicKey> PublicKeys
        {
            get { return this._publicKeys; }
            set { this._publicKeys = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SshSettings class.
        /// </summary>
        public SshSettings()
        {
            this._keyPairs = new List<SshSettingKeyPair>();
            this._publicKeys = new List<SshSettingPublicKey>();
        }
    }
}
