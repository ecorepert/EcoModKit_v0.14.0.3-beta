// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Money.IDualPermissionManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.View;
using System;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Economy.Money;

internal interface IDualPermissionManager : 
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID
{
  const int MaxAccountsPerPerson = 20;

  #nullable disable
  IRegistrar Registrar { get; }

  LocString[] RandomTitles { get; }

  Type TypeToAdd(Player creator, string listName);

  [RPC]
  object IHasClientControlledContainers.Add(Player player, string listName);

  [RPC]
  Task<bool> IHasClientControlledContainers.Remove(
    Player player,
    string listName,
    IController entry);
}
