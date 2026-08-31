// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Buffs.AreaBuffCaloriesComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Buffs;

[Serialized]
[HasIcon(null)]
public class AreaBuffCaloriesComponent : AreaBuffComponent
{
  public HashSet<string> ToolTagsToLimitTo;

  [SyncToView(null, true)]
  public override string BuffMarkedUpName { get; }

  public override string BoostIcons { get; }

  public override string BuffDesc { get; }

  public override void Initialize();

  public override bool CanBuff(IBuffable buffable);

  public override Eco.Gameplay.Buffs.BuffDesc? ApplyBuff(IBuffable target, float strength);
}
