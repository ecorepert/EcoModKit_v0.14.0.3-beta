// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Skills.Talent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Bonuses;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Skills;

[Serialized]
public abstract class Talent : IHasBonuses
{
  public float Value { get; set; }

  public virtual Type TalentType { get; }

  public virtual Type TalentGroupType { get; }

  public virtual bool Active(object obj, User user = null);

  public virtual bool Base { get; }

  public virtual bool HasActiveRequirements { get; }

  /// <summary>
  /// This method called when talent just learned to apply modifications to existing objects (like reduce requirements, update statuses etc).
  /// </summary>
  /// <param name="user"></param>
  public virtual void OnLearned(User user);

  public virtual void OnUnLearned(User user);

  /// <summary>
  /// This method called every time when talent added to user either when learned or deserialized.
  /// Use this method for callbacks registration.
  /// </summary>
  /// <param name="user"></param>
  public virtual void RegisterTalent(User user);

  public virtual void UnRegisterTalent(User user);

  /// <summary> Bonuses provided by this talent. Subclasses populate during construction. </summary>
  public List<Bonus> Bonuses { get; }

  IEnumerable<Bonus> IHasBonuses.Bonuses { get; }
}
