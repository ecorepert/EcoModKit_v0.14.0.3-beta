// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.ISingleEditingUser
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Utils;

/// <summary>This is used when we want an object to be edited by only one user at one time (but can be viewed by multiple users concurrently which we add to the <see cref="P:Eco.Gameplay.Utils.IPlayerUseTracking.UsingPlayers" /> list).</summary>
public interface ISingleEditingUser : 
  IPlayerUseTracking,
  IController,
  IViewController,
  IHasUniversalID
{
  [ClientInterfaceProperty]
  User CurrentEditingUser { get; set; }
}
