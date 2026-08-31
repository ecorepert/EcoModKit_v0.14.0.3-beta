// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.LiquidProducerAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary> Attribute for items which produces Liquid (or Gases). </summary>
public class LiquidProducerAttribute : ItemAttribute
{
  public Type OutputType { get; }

  public float OutputRate { get; }

  public LiquidProducerAttribute(Type outputType, float outputRate);
}
