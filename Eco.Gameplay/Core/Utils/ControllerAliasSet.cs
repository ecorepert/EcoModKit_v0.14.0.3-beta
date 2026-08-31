// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ControllerAliasSet
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Players;
using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Utils;

public class ControllerAliasSet : ControllerHashSet<IAlias>
{
  public ThreadSafeAction<IEnumerable<User>> UserSetChangedEvent { get; set; }

  public ControllerAliasSet(IController parent, [ControllerPropertyName(null)] string propertyName);

  public ControllerAliasSet();

  public bool HasUser(User user);

  public void Destroy();
}
