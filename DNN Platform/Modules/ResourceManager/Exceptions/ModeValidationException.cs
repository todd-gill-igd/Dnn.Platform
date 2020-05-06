﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

using System;

namespace Dnn.Modules.ResourceManager.Exceptions
{
    public class ModeValidationException : Exception
    {
        public ModeValidationException(string message) : base(message)
        {
        }
    }
}