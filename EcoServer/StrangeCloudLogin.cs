// Decompiled with JetBrains decompiler
// Type: Eco.Server.StrangeCloudLogin
// Assembly: EcoServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F98E0BA7-72DE-473F-BCD0-D64424883057
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\EcoServer.dll

using Eco.Shared.Localization;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Server;

public static class StrangeCloudLogin
{
  public static 
  #nullable disable
  Task Initialize();

  public static Task ForgetCredentialsAsync();

  private readonly struct Arguments : IEquatable<StrangeCloudLogin.Arguments>
  {
    public Arguments(
      #nullable enable
      string? Username,
      string? Password,
      string? UserToken,
      string? SteamToken,
      bool IsAnyOfflineModeArgumentSet);

    public string? Username { get; init; }

    public string? Password { get; init; }

    public string? UserToken { get; init; }

    public string? SteamToken { get; init; }

    public bool IsAnyOfflineModeArgumentSet { get; init; }

    [CompilerGenerated]
    public override 
    #nullable disable
    string ToString();

    [CompilerGenerated]
    public static bool operator !=(
      StrangeCloudLogin.Arguments left,
      StrangeCloudLogin.Arguments right);

    [CompilerGenerated]
    public static bool operator ==(
      StrangeCloudLogin.Arguments left,
      StrangeCloudLogin.Arguments right);

    [CompilerGenerated]
    public override int GetHashCode();

    [CompilerGenerated]
    public override bool Equals(object obj);

    [CompilerGenerated]
    public bool Equals(StrangeCloudLogin.Arguments other);

    [CompilerGenerated]
    public void Deconstruct(
      out 
      #nullable enable
      string? Username,
      out string? Password,
      out string? UserToken,
      out string? SteamToken,
      out bool IsAnyOfflineModeArgumentSet);
  }

  private readonly struct AuthenticationAttempt
  {
    public readonly StrangeCloudLogin.AuthenticationResult Result;
    public readonly string Error;

    public static StrangeCloudLogin.AuthenticationAttempt Online();

    public static StrangeCloudLogin.AuthenticationAttempt Offline();

    public static StrangeCloudLogin.AuthenticationAttempt Failure(string error);
  }

  private enum AuthenticationResult
  {
    None,
    Online,
    Error,
    Offline,
  }

  private abstract class AuthenticationMethod
  {
    public abstract LocString Name { get; }

    public abstract bool IsAvailable(in StrangeCloudLogin.Arguments arguments);

    public Task<StrangeCloudLogin.AuthenticationAttempt> AuthenticateAsync(
      StrangeCloudLogin.Arguments arguments);

    public abstract Task<StrangeCloudLogin.AuthenticationAttempt> AuthenticateInternal(
      StrangeCloudLogin.Arguments arguments);

    protected StrangeCloudLogin.AuthenticationAttempt ErrorIfNotAuthenticated(string? message);
  }

  private class UserTokenAuthentication : StrangeCloudLogin.AuthenticationMethod
  {
    public override LocString Name { get; }

    public override bool IsAvailable(in StrangeCloudLogin.Arguments arguments);

    public override Task<StrangeCloudLogin.AuthenticationAttempt> AuthenticateInternal(
      StrangeCloudLogin.Arguments arguments);
  }

  private class SteamTicketAuthentication : StrangeCloudLogin.AuthenticationMethod
  {
    public override LocString Name { get; }

    public override bool IsAvailable(in StrangeCloudLogin.Arguments arguments);

    public override Task<StrangeCloudLogin.AuthenticationAttempt> AuthenticateInternal(
      StrangeCloudLogin.Arguments arguments);
  }

  private class UsernameAndPasswordArgumentsAuthentication : StrangeCloudLogin.AuthenticationMethod
  {
    public override LocString Name { get; }

    public override bool IsAvailable(in StrangeCloudLogin.Arguments arguments);

    public override Task<StrangeCloudLogin.AuthenticationAttempt> AuthenticateInternal(
      StrangeCloudLogin.Arguments arguments);
  }

  private class DebugUsernameAndPasswordAuthentication : 
    StrangeCloudLogin.UsernameAndPasswordArgumentsAuthentication
  {
    public override LocString Name { get; }

    public override bool IsAvailable(in StrangeCloudLogin.Arguments arguments);

    public override Task<StrangeCloudLogin.AuthenticationAttempt> AuthenticateInternal(
      StrangeCloudLogin.Arguments arguments);
  }

  private class UsernameAndPasswordDialogAuthentication : StrangeCloudLogin.AuthenticationMethod
  {
    public override LocString Name { get; }

    public override bool IsAvailable(in StrangeCloudLogin.Arguments arguments);

    public override Task<StrangeCloudLogin.AuthenticationAttempt> AuthenticateInternal(
      StrangeCloudLogin.Arguments arguments);
  }

  private class OfflineModeArguments : StrangeCloudLogin.AuthenticationMethod
  {
    public override LocString Name { get; }

    public override bool IsAvailable(in StrangeCloudLogin.Arguments arguments);

    public override Task<StrangeCloudLogin.AuthenticationAttempt> AuthenticateInternal(
      StrangeCloudLogin.Arguments arguments);
  }

  [Serializable]
  public class SessionInfo
  {
    public 
    #nullable disable
    List<StrangeCloudLogin.SessionEntry> SessionEntries { get; set; }
  }

  [Serializable]
  public class SessionEntry
  {
    public string Name { get; set; }

    public string SessionToken { get; set; }
  }
}
