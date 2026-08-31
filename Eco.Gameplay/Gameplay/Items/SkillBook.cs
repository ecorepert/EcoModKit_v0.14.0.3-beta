// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.SkillBook
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Skills;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
[System.ComponentModel.Category("Hidden/Research")]
[ItemGroup("Skill Books")]
[Tag("Skill Books")]
[Eco.Gameplay.Items.MaxStackSize(1)]
public abstract class SkillBook : Item
{
  public abstract Type SkillType { get; }

  public Skill Skill { get; }

  public abstract Type SkillScrollType { get; }

  public override string OnUsed(Player player, ItemStack itemStack);
}
