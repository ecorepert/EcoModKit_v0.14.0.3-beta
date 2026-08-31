// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.LawTriggerIndex
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Civics.Laws;

/// <summary>Maps a game-action trigger <see cref="T:System.Type" /> to the laws containing at least one section triggered by that type, so law evaluation can skip every law that can't possibly match. Rebuilt lazily whenever the law registrar changes; state/validity/settlement are filtered live by the caller, so only the trigger mapping needs invalidation.</summary>
internal sealed class LawTriggerIndex
{
  /// <summary>All laws with a section triggered by <paramref name="actionType" />, in registrar order. Unfiltered by settlement/state/validity (callers filter live).</summary>
  public 
  #nullable disable
  IReadOnlyList<Law> LawsFor(Type actionType);
}
