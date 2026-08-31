// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.ElectionChoiceYesNo
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Civics;

[Serialized]
public class ElectionChoiceYesNo : ElectionChoice
{
  public const string YesName = "Yes";
  public const string NoName = "No";
  [Serialized]
  public bool Yes;

  public static LocString YesMarkedUpName { get; }

  public static LocString NoMarkedUpName { get; }

  public override string Name { get; }

  public override LocString MarkedUpName { get; }

  public override string Describe { get; }
}
