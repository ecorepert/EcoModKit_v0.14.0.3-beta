// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.InfluenceObjects.IHasBaseInfluence
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.InfluenceObjects;

/// <summary>Placed on a worldobject component that has base influence, meaning it generates influence without culture. Only works for a deed host object.</summary>
public interface IHasBaseInfluence
{
  float BaseInfluence { get; }
}
