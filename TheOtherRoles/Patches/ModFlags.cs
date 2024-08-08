using System;

namespace TheOtherRoles.Patches;

[Flags]
public enum ModFlags : ushort
{
    None = 0,

    RequireOnAllClients = 1 << 0,

    RequireOnServer = 1 << 1,

    RequireOnHost = 1 << 2,
}
