// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.ElectionChoiceID
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Civics;

/// <summary>Simple int wrapper to lend some type safety to elections. </summary>
[Serialized]
public struct ElectionChoiceID
{
  public static ElectionChoiceID None;
  [Serialized]
  public int Id;

  public ElectionChoiceID(int id);

  public bool IsSet { get; }

  public override bool Equals(object obj);

  public override int GetHashCode();

  public static bool operator ==(ElectionChoiceID left, ElectionChoiceID right);

  public static bool operator !=(ElectionChoiceID left, ElectionChoiceID right);
}
