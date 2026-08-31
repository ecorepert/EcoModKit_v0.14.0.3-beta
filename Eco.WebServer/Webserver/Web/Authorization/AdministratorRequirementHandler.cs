// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Authorization.AdministratorRequirementHandler
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

#nullable enable
namespace Eco.WebServer.Web.Authorization;

/// <summary>
/// Custom AuthorizationHandler for admin check due to needing to also check if dev.
/// See "Policy-based authorization in ASP.NET Core".
/// </summary>
public class AdministratorRequirementHandler : AuthorizationHandler<
#nullable disable
AdministratorRoleRequirement>
{
  protected override Task HandleRequirementAsync(
    AuthorizationHandlerContext context,
    AdministratorRoleRequirement requirement);
}
