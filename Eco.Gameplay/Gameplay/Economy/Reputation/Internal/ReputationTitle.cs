// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Reputation.Internal.ReputationTitle
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Economy.Reputation.Internal;

/// <summary>Defines a vanity title (a text string) we apply when reaching a given reputation level.</summary>
[TypeConverter(typeof (ExpandableObjectConverter))]
public class ReputationTitle
{
  public float MaxReputation { get; set; }

  public string UserTitle { get; set; }

  public string ObjectTitle { get; set; }

  public string Color { get; set; }

  public string ToString(bool useUserTitle);
}
