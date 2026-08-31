// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Tutorial.Internal.UserSubTaskInteract
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.Tutorial.Internal;

/// <summary>Detects a count of interactions using an item with a name containing a given string</summary>
public class UserSubTaskInteract : UserSubTaskSubscribe<User.InteractionEvent>, IStatefulUserSubTask
{
  public string InteractionName;
  public string ItemNameContains;
  public Type ItemType;
  public string TargetObjectName;
  public string TargetBlockName;
  public string RestrictedTargetBlockName;
  public string[] TargetBlockNames;

  public object State { get; set; }

  public int CountNeeded { get; set; }

  protected override ThreadSafeAction<User.InteractionEvent> Subscription { get; }

  protected override bool IsComplete(User.InteractionEvent interaction);

  [Serialized]
  public class CountState
  {
    [Serialized]
    public int Remaining;
  }
}
