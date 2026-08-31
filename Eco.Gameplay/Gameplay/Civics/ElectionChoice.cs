// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.ElectionChoice
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Civics;

[Serialized]
public abstract class ElectionChoice
{
  [Serialized]
  public double TimeAdded;

  [Serialized]
  public ElectionChoiceID ID { get; }

  public abstract string Name { get; }

  public abstract LocString MarkedUpName { get; }

  [Eco.Shared.Serialization.OnDeserialized]
  public void OnDeserialized();

  public abstract string Describe { get; }
}
