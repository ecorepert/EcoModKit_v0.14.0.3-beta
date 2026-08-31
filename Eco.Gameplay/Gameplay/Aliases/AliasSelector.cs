// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Aliases.AliasSelector
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Aliases;

[Serialized]
public class AliasSelector : IController, IViewController, IHasUniversalID, IExternalReferencer
{
  public 
  #nullable disable
  Func<Player, IAlias, Task<bool>> TryRemove;
  public Func<Player, IAlias, Task<bool>> TryAdd;
  public ThreadSafeAction Changed;

  [SyncToView(null, true)]
  public AliasRestrictions Restriction { get; }

  public event Action<IEnumerable<User>> OnAdd;

  public event Action<IEnumerable<User>> OnRemove;

  public int SelectionCount { get; }

  public IEnumerable<IAlias> CurrentSelection { get; }

  public bool Empty { get; }

  [Eco.Shared.Serialization.OnPostLoad]
  public void OnPostLoad();

  public override string ToString();

  public string OneLineDescription { get; }

  public string Description { get; }

  public bool ContainsUser(User user);

  public bool ContainsExactAlias(IAlias alias);

  public void SetRestriction(AliasRestrictions restriction);

  public void SetBlackList(IEnumerable<IAlias> blackList);

  public void Add(User user);

  public void Delete(User user);

  public void AddRange(IEnumerable<IAlias> aliases);

  public void Add(IAlias alias);

  public void Delete(IAlias alias);

  public void Clear();

  public IEnumerable<User> AllUsers { get; }

  [RPC]
  public Task<bool> Add(Player player, IAlias alias);

  public Task<bool> AddAsync(Player player, IAlias alias);

  [RPC]
  public Task<bool> Delete(Player player, IAlias alias);

  public Task<bool> DeleteAsync(Player player, IAlias alias);

  public void SwapRefs(Dictionary<IHasID, IHasID> refsToSwap);

  public bool HasOnlyUsers { get; }

  public IEnumerable<User> UsersOnly { get; }

  public ref int ControllerID { get; }

  public LocString MarkedUpName { get; }
}
