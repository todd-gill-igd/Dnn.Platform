﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace Dnn.Modules.ResourceManager.Services.Dto
{
    public class DeleteFolderRequest
    {
        public int FolderId { get; set; }

        public bool UnlinkAllowedStatus { get; set; }
    }
}