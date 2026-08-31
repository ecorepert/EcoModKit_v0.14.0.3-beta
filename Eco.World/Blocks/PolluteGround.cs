// Decompiled with JetBrains decompiler
// Type: Eco.World.Blocks.PolluteGround
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

#nullable disable
namespace Eco.World.Blocks;

public sealed class PolluteGround : BlockAttribute
{
  public GroundPollutionType Type { get; set; }

  public float Amount { get; set; }

  public PolluteGround(GroundPollutionType type, float amount);
}
