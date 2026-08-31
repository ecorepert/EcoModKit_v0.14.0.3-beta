// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Utils.MapLayerAwareFileProvider
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;
using System;

#nullable enable
namespace Eco.WebServer.Web.Utils;

/// <summary>Custom file provider for static resources, which does not resolve layer image files, when they should not be visible according to the layer settings</summary>
public class MapLayerAwareFileProvider : IFileProvider, IDisposable
{
  public MapLayerAwareFileProvider(string webrootPath);

  public IFileInfo GetFileInfo(string subpath);

  public IDirectoryContents GetDirectoryContents(string subpath);

  public IChangeToken Watch(string filter);

  public void Dispose();

  protected virtual void Dispose(bool disposing);
}
