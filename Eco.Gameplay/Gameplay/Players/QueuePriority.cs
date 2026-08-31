// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.QueuePriority
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Players;

[TypeConverter(typeof (ExpandableObjectConverter))]
public class QueuePriority
{
  [LocDescription("Higher value priority means players will enter sooner.")]
  public int Priority { get; set; }

  public string Title { get; set; }

  public string Users { get; set; }

  public override string ToString();
}
