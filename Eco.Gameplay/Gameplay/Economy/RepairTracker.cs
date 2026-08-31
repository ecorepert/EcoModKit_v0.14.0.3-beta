// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.RepairTracker
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Items;
using Eco.Shared.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Economy;

public class RepairTracker : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  public event PropertyChangedEventHandler PropertyChanged;

  [SyncToView(null, true)]
  public string ObjectToRepair { get; set; }

  [SyncToView(null, true)]
  public float RepairPayment { get; set; }

  [SyncToView(null, true)]
  public Currency Currency { get; set; }

  [SyncToView(null, true)]
  public float Working { get; set; }

  [SyncToView(null, true)]
  public string NeededItems { get; set; }

  [SyncToView(null, true)]
  public float IntegrityRequired { get; set; }

  [SyncToView(null, true)]
  public string RequiredSkill { get; set; }

  [SyncToView(null, true)]
  public Vector3 Position { get; set; }

  [SyncToView(null, true)]
  public List<SkillAndLevel> NeededSkills { get; set; }

  public ref int ControllerID { get; }

  public ref ThreadSafeSubscriptions Subscriptions { get; }
}
