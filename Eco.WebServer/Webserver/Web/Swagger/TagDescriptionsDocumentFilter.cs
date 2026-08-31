// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Swagger.TagDescriptionsDocumentFilter
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

#nullable disable
namespace Eco.WebServer.Web.Swagger;

/// <summary>Custom implementation of <seealso cref="T:Swashbuckle.AspNetCore.SwaggerGen.IDocumentFilter" /> for automatically populating the root level tags used by our DocFX generator.</summary>
internal class TagDescriptionsDocumentFilter : IDocumentFilter
{
  public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context);
}
