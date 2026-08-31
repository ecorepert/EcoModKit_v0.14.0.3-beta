// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Filters.DebugCallAttribute
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Microsoft.AspNetCore.Mvc.Filters;

#nullable disable
namespace Eco.WebServer.Web.Filters;

/// <summary>
/// Attribute for actions that should only be available when UserManager.Config.AllowDebugCalls is true.
/// </summary>
public class DebugCallAttribute : ActionFilterAttribute
{
  public static string Message;

  public override void OnActionExecuting(ActionExecutingContext context);
}
