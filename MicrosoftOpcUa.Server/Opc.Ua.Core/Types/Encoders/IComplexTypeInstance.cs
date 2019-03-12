﻿/* Copyright (c) 1996-2016, OPC Foundation. All rights reserved.
   The source code in this file is covered under a dual-license scenario:
     - RCL: for OPC Foundation members in good-standing
     - GPL V2: everybody else
   RCL license terms accompanied with this source code. See http://opcfoundation.org/License/RCL/1.00/
   GNU General Public License as published by the Free Software Foundation;
   version 2 of the License are accompanied with this source code. See http://opcfoundation.org/License/GPLv2
   This source code is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
*/

namespace Opc.Ua
{
    /// <summary>
    /// Interface implemented by complex data type instances.
    /// </summary>
    public interface IComplexTypeInstance
    {
        /// <summary>
        /// Gets or sets the UA type identifier for the encodeable type.
        /// </summary>
        /// <value>
        /// The UA type identifier.
        /// </value>
        ExpandedNodeId TypeId { get; set; }
    }
}
