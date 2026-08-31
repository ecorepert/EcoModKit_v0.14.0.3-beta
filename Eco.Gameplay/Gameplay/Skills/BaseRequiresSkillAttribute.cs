// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Skills.BaseRequiresSkillAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Gameplay.Skills;

public abstract class BaseRequiresSkillAttribute : 
  Attribute,
  IController,
  IViewController,
  IHasUniversalID
{
  public Skill SkillItem { get; }

  public ref int ControllerID { get; }

  [SyncToView(null, true)]
  public Type SkillType { get; }

  [SyncToView(null, true)]
  public int SkillTypeID { get; }

  [SyncToView(null, true)]
  public int Level { get; }

  [SyncToView(null, true)]
  public LocString Description();

  public LocString DescriptionNoText();

  public BaseRequiresSkillAttribute(Type requiredSkillType, int requiredSkillLevel);

  public bool IsMet(Player player);

  public bool IsMet(User user);

  public bool IsValid { get; }
}
