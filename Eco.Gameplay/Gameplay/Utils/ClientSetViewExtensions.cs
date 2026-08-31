// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.ClientSetViewExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Shared.Networking;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Utils;

public static class ClientSetViewExtensions
{
  [RPC]
  public static void SetClassOfProperty(
    this 
    #nullable disable
    object target,
    Player player,
    string newClassName,
    [ControllerPropertyName("target")] string propertyName,
    int listIndex);

  [RPC]
  public static void SetName(this IHasID reference, Player player, string newName);

  public static Task<bool> ShowRenamedEntries<T>(
    Type reference,
    Player player,
    List<(T Entry, string OldName)> newNames)
    where T : INamed;
}
