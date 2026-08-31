// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.IDeedOwned
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Shared.Networking;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Property;

/// <summary>An object which can be owned by a deed.</summary>
public interface IDeedOwned : IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  string FriendlyName { get; }

  void OnAuthChanged();

  void OnAuthSet(Deed deed);

  Deed GetDeed();

  [RPC]
  void OnClick(Player clickingPlayer);
}
