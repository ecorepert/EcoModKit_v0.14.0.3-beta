// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Constitutional.CivicConditionAllOtherCivicAbilities
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Civics.Constitutional;

/// <summary></summary>
[Eco.Shared.Networking.Eco(true)]
[LocDisplayName("All Other Civic Abilites")]
[LocDescription("Covers any other civic action, if it's not referenced in any other condition.")]
public class CivicConditionAllOtherCivicAbilities : CivicConditionBase
{
  public override LocString Description();

  public override bool AppliesTo(CivicAction action);

  public override bool AppliesTo(Type type);

  public override bool UndercutAllPriorities { get; }

  public override IEnumerable<Type> AllTypes { get; }
}
