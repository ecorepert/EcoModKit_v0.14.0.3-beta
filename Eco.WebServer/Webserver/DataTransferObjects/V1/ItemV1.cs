// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.DataTransferObjects.V1.ItemV1
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Gameplay.Items;
using System;

#nullable disable
namespace Eco.WebServer.DataTransferObjects.V1;

public class ItemV1
{
  public string DisplayName { get; set; }

  public string TypeName { get; set; }

  public float Weight { get; set; }

  public ItemV1();

  public ItemV1(Item other);

  public ItemV1(Type itemType);
}
