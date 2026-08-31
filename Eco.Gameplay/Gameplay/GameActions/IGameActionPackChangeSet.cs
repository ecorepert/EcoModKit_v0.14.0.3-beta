// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.IGameActionPackChangeSet
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.GameActions;

/// <summary>Objects with this interface will be used in GameActionPack to do PreTest, PostEffect or GameActionPack Dispose callback.</summary>
public interface IGameActionPackChangeSet
{
  LocString GameActionPackPostEffect();

  Result GameActionPackPretest();

  void GameActionPackDispose();

  bool NeedsDispose { get; }
}
