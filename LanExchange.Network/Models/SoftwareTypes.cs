using System;

namespace LanExchange.Network.Models
{
    /// <summary>
    /// SV_TYPE_101
    /// </summary>
    [Flags]
    [CLSCompliant(false)]
    public enum SoftwareTypes : uint
    {
        SV_TYPE_WORKSTATION = 0x00000001,
        SV_TYPE_SERVER = 0x00000002,
        SV_TYPE_SQLSERVER = 0x00000004,
        SV_TYPE_DOMAIN_CTRL = 0x00000008,
        SV_TYPE_DOMAIN_BAKCTRL = 0x00000010,
        SV_TYPE_TIME_SOURCE = 0x00000020,
        SV_TYPE_AFP = 0x00000040,
        SV_TYPE_NOVELL = 0x00000080,
        SV_TYPE_DOMAIN_MEMBER = 0x00000100,
        SV_TYPE_PRINTQ_SERVER = 0x00000200,
        SV_TYPE_DIALIN_SERVER = 0x00000400,
        SV_TYPE_XENIX_SERVER = 0x00000800,
        SV_TYPE_SERVER_UNIX = SV_TYPE_XENIX_SERVER,
        SV_TYPE_NT = 0x00001000,
        SV_TYPE_WFW = 0x00002000,
        SV_TYPE_SERVER_MFPN = 0x00004000,
        SV_TYPE_SERVER_NT = 0x00008000,
        SV_TYPE_POTENTIAL_BROWSER = 0x00010000,
        SV_TYPE_BACKUP_BROWSER = 0x00020000,
        SV_TYPE_MASTER_BROWSER = 0x00040000,
        SV_TYPE_DOMAIN_MASTER = 0x00080000,
        SV_TYPE_SERVER_OSF = 0x00100000,
        SV_TYPE_SERVER_VMS = 0x00200000,
        SV_TYPE_WINDOWS = 0x00400000,
        SV_TYPE_DFS = 0x00800000,
        SV_TYPE_CLUSTER_NT = 0x01000000,
        SV_TYPE_TERMINALSERVER = 0x02000000,
        SV_TYPE_CLUSTER_VS_NT = 0x04000000,
        SV_TYPE_DCE = 0x10000000,
        SV_TYPE_ALTERNATE_XPORT = 0x20000000,
        SV_TYPE_LOCAL_LIST_ONLY = 0x40000000,
        SV_TYPE_DOMAIN_ENUM = 0x80000000,
        SV_TYPE_ALL = 0xFFFFFFFF
    }
}