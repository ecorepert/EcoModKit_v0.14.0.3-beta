// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.ElectionChoiceCandidate
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Civics;

[Serialized]
public class ElectionChoiceCandidate : ElectionChoice
{
  [Serialized]
  public User User;
  [Serialized]
  public string Speech;

  public override string Name { get; }

  public override LocString MarkedUpName { get; }

  public override string Describe { get; }
}
