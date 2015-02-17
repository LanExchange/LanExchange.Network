﻿using System;
using System.Runtime.InteropServices;

namespace LanExchange.Network.Models
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    [CLSCompliant(false)]
    public sealed class SHARE_INFO_1
    {
        [MarshalAs(UnmanagedType.LPWStr)]
        public string netname;
        [MarshalAs(UnmanagedType.U4)]
        public uint type;
        [MarshalAs(UnmanagedType.LPWStr)]
        public string remark;
    }
}