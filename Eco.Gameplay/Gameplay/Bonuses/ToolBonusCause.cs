// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.ToolBonusCause
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary> Triggers when the user is using a specific type of tool. </summary>
public class ToolBonusCause : BonusCause
{
  /// <summary> Tool types to match against <see cref="P:Eco.Gameplay.Bonuses.BonusContext.Tool" />. Uses IsInstanceOfType for inheritance support. Empty = any tool. </summary>
  public HashSet<Type> ToolTypes { get; init; }

  public override bool IsTriggered(BonusContext context);

  public override LocString Description();
}
