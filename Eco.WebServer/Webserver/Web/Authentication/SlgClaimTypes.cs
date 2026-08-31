// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Authentication.SlgClaimTypes
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

#nullable disable
namespace Eco.WebServer.Web.Authentication;

/// <summary>A list of non-standard claims for an Eco user. These come from the user in the accounts database.</summary>
public class SlgClaimTypes
{
  /// <summary> Name of user. </summary>
  public const string Name = "Name";
  /// <summary> Strange ID of user. </summary>
  public const string StrangeId = "StrangeId";
  /// <summary> SteamId of user if available </summary>
  public const string SteamId = "SteamId";
  /// <summary> "true" if the user is an api user. </summary>
  public const string IsApiUser = "IsApiUser";
  /// <summary> "true" if the user is a server admin. </summary>
  public const string IsAdmin = "IsAdmin";
  /// <summary> "true" if the user is developer tier. </summary>
  public const string IsDev = "IsDev";
  /// <summary> "true" if the user is a developer from SLG. </summary>
  public const string IsSlgDev = "IsSlgDev";
  /// <summary> The user's selected icon. </summary>
  public const string SelectedIcon = "SelectedIcon";
}
