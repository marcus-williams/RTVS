﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.ComponentModel;

namespace Microsoft.UnitTests.Core.XUnit {
    public static class Category {
        public class LinuxAttribute : CategoryAttribute {
            public LinuxAttribute() : base("Linux") { }
        }
    }
}