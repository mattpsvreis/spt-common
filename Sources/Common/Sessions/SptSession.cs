using EFT;
using SwiftXP.SPT.Common.EFT;

namespace SwiftXP.SPT.Common.Sessions;

public static class SptSession
{
    public static EftClientBackendSession Session => EFTGameExtensions.Session;
}
