// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Authorization.PolicyNames
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

#nullable enable
namespace Eco.WebServer.Web.Authorization;

/// <summary>
/// Names of policies that are used with Authorize attribute, eg `[Authorize(Policy = PolicyNames.RequireAdmin)]`.
/// See "Policy-based authorization in ASP.NET Core".
/// </summary>
public class PolicyNames
{
  public const string RequireAdmin = "RequireAdmin";
  public const string RequireDev = "RequireDev";
  public const string RequireSlgDev = "RequireSlgDev";
  public const string RequiresEcoUser = "RequiresEcoUser";
}
