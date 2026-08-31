// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.DataTransferObjects.V1.EntityV1
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using System.Numerics;

#nullable disable
namespace Eco.WebServer.DataTransferObjects.V1;

public class EntityV1
{
  public Vector3 Position { get; }

  public string EntityType { get; }

  public EntityV1(string entityType, Vector3 pos);
}
