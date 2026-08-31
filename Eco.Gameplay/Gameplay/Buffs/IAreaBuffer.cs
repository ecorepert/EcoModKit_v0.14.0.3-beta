// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Buffs.IAreaBuffer
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Math;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Buffs;

[ForceCreateView]
public interface IAreaBuffer : IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  string BuffMarkedUpName { get; }

  [SyncToView(null, true)]
  string BuffIconName { get; }

  [SyncToView(null, true)]
  bool AllowStackingBuffs { get; }

  [SyncToView(null, true)]
  AreaDiminVal StrengthAtPos { get; }

  List<string[]> OverlayCategories { get; }

  IEnumerable<string> Keys { get; }

  INamed BuffSourceObject { get; }

  bool CanBuff(IBuffable target);

  BuffDesc? ApplyBuff(IBuffable target, float strength);

  float StrengthOnBuffable(IBuffable target);
}
