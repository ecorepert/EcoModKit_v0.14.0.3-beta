// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.ILawManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Economy.Transfer;
using Eco.Gameplay.GameActions;

#nullable disable
namespace Eco.Gameplay.Civics.Laws;

public interface ILawManager
{
  PostResult Perform(GameAction action, AccountChangeSet acc);

  /// <summary><paramref name="memo" /> optionally caches the applicable-law lookup across the actions of a single action pack (e.g. a bulk inventory move) so it's resolved once rather than per action. Defaults to the unmemoized path so mods implementing only the two-argument overload stay compatible.</summary>
  PostResult Perform(GameAction action, AccountChangeSet acc, LawSelectionMemo memo);
}
