// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.MiningSweepingHandsTalent
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
public class MiningSweepingHandsTalent : SweepingHandsTalent
{
  public readonly int PickUpRange;

  public override bool Base { get; }

  public override Type TalentGroupType { get; }

  public override void RegisterTalent(User user);

  public override void UnRegisterTalent(User user);
}
