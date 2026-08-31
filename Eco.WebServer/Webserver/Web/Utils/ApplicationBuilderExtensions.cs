// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Utils.ApplicationBuilderExtensions
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;

#nullable disable
namespace Eco.WebServer.Web.Utils;

public static class ApplicationBuilderExtensions
{
  public static void UseEcoWebBin(this IApplicationBuilder appBuilder, IFileProvider fileProvider);
}
