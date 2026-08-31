// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.ResourceTagCause
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary> Triggers when the item in context has one of the specified tags. </summary>
public class ResourceTagCause : BonusCause
{
  /// <summary> Tag names to match against <see cref="P:Eco.Gameplay.Bonuses.BonusContext.Item" />'s tags. Any match triggers. </summary>
  public HashSet<string> Tags { get; init; }

  public override bool IsTriggered(BonusContext context);

  public override LocString Description();
}
