// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.WorkParties.KnowledgeSharePayment
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Players;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using System.Text;

#nullable enable
namespace Eco.Gameplay.Economy.WorkParties;

[Eco.Shared.Networking.Eco(true)]
[LocDescription("Payment made as transferring knowledge. Must be creating a skillbook, or have the skillbook in your inventory at posting time.")]
public class KnowledgeSharePayment : ThresholdPayment
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Which skills to share.  Must have access to the skillbook at posting time, or the work party is creating the skillbooks.")]
  public 
  #nullable disable
  GamePickerList<Skill> Skills { get; set; }

  [SyncToView(null, true)]
  public override string Description { get; }

  public override string RewardDesc { get; }

  public override string ShortDescription();

  public override void Posted(User user);

  protected override void GainReward(Laborer laborer, StringBuilder sb);
}
