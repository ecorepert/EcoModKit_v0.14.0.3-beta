// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Tutorial.UserTaskTemplate
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Tutorial;

public class UserTaskTemplate
{
  public string Name { get; }

  public float Index { get; }

  public LocString LocalizedTitle { get; }

  public bool AutoOpen { get; set; }

  public int AutoOpenPriority { get; set; }

  public string Popup { get; set; }

  public string TargetUIName { get; set; }

  public bool ActionsAtEnd { get; set; }

  public Action<IList<UserSubTask>, User, string> SubTasksAdder { get; set; }

  public string UIStateToSet { get; set; }

  public List<UserTaskTemplate> ChainedTasks { get; }

  public Func<User, bool> AutoSkip { get; set; }

  public bool AutoExpandable { get; set; }

  public int ChainsNeededToActivate { get; set; }

  public UserTaskTemplate(
    string name,
    float index,
    LocString localizedTitle,
    Action<IList<UserSubTask>> subTasksAdder);

  public UserTaskTemplate(
    string name,
    float index,
    LocString localizedTitle,
    Action<IList<UserSubTask>, User, string> subTasksAdder);
}
