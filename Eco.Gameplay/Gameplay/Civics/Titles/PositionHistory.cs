// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Titles.PositionHistory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.Civics.Titles;

[Serialized]
public class PositionHistory
{
  [Serialized]
  public ThreadSafeList<User> OfficeHolders { get; set; }

  [Serialized]
  public double TimeStarted { get; set; }

  [Serialized]
  public double TimeEnded { get; set; }

  [Serialized]
  public string ReasonJoined { get; set; }

  [Serialized]
  public string ReasonLeft { get; set; }

  [Serialized]
  public bool RemoveOccupant { get; set; }

  public override string ToString();

  public bool HasUser(User user);

  public void SetStartLoc(FormattableString desc);

  public void SetEndLoc(FormattableString desc);
}
