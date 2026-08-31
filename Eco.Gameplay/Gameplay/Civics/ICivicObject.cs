// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.ICivicObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Civics;

/// <summary> Interface for Civic Objects to inherit from. Used to soft-lock the object to a settlement. </summary>
/// <remarks> e.g.: When a Capitol of a country enters the region of a town, since it's soft-locked, it will remain within the country's jurisdiction, instead of the town's. </remarks>
public interface ICivicObject
{
}
