// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.DirectoryServices.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal struct AdsSearchPreferenceInfo
    {
        public int /*AdsSearchPreferences*/ dwSearchPref;
        internal int pad;
        public AdsValue vValue;
        public int /*AdsStatus*/ dwStatus;
        internal int pad2;
    }
}

