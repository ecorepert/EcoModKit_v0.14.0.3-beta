// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.LawManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Utils;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Civics.Laws;

[Eco.Shared.Networking.Eco(true)]
public class LawManager : 
  ILawManager,
  IController,
  IViewController,
  IHasUniversalID,
  IHasClientControlledContainers
{
  public 
  #nullable disable
  PostResult Perform(GameAction action, AccountChangeSet acc);

  public PostResult Perform(GameAction action, AccountChangeSet acc, LawSelectionMemo memo);

  /// <summary>The active+valid laws applicable to this action, ordered identically to the legacy settlement-driven selection (outer: settlements in scope order, inner: registrar order), but resolved via the trigger index so laws with no matching trigger are skipped. Memoized per pack when a <paramref name="memo" /> is supplied.</summary>
  internal IReadOnlyList<Law> SelectLaws(GameAction action, LawSelectionMemo memo = null);

  public void SlowTick();

  public ref int ControllerID { get; }
}
