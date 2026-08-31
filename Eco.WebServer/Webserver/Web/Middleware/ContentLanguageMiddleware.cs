// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Middleware.ContentLanguageMiddleware
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

#nullable enable
namespace Eco.WebServer.Web.Middleware;

/// <summary>
/// Custom middleware that adds the current server language as the Content-Language header to all pages the webserver serves
/// </summary>
public class ContentLanguageMiddleware
{
  public ContentLanguageMiddleware(
  #nullable disable
  RequestDelegate next);

  public Task Invoke(HttpContext context);
}
