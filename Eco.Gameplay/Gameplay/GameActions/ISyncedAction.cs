// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.ISyncedAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;
using LiteDB;

#nullable disable
namespace Eco.Gameplay.GameActions;

/// <summary> An action that should be run in synced way. Both with "IPretestAction" works to avoid bugs with simultaneous running of two actions, like pick up same item twice by different users. Pair of (syncObject, GameActionType) will be locked while action is running.</summary>
public interface ISyncedAction
{
  [JsonIgnore]
  [BsonIgnore]
  object SyncObject { get; }
}
