// Decompiled with JetBrains decompiler
// Type: Eco.Shared.StrangeCloudShared.StrangeItemInWorld
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Shared.StrangeCloudShared;

/// <summary>Tracks how many strange items are usable within this world, and also how many are owned but not allowed here (bought in a server that
/// has not been listed to allow items to originate from in the strange world config).</summary>
[Serialized]
public struct StrangeItemInWorld
{
  [Serialized]
  public string Type;
  [Serialized]
  public int AllowedQuantity;
  [Serialized]
  public int UnallowedQuantity;
}
