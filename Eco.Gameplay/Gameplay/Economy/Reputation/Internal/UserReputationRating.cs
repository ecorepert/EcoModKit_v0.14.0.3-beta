// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Reputation.Internal.UserReputationRating
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Economy.Reputation.Internal;

[Serialized]
public class UserReputationRating
{
  [Serialized]
  public float Value;
  [Serialized]
  public string Review;
  public float RelativeRepCached;
  public double LastUpdatedRelativeRep;

  public float Adjust(float val, string note, bool ignoreLimit);

  public static float ClampRep(float value);

  public void Set(float val, string note);
}
