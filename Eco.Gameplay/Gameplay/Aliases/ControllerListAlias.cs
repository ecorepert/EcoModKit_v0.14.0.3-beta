// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Aliases.ControllerListAlias
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Players;

#nullable enable
namespace Eco.Gameplay.Aliases;

public class ControllerListAlias : ControllerList<
#nullable disable
IAlias>
{
  /// <summary>Called when the built list of all users in all aliases changes.</summary>
  public ThreadSafeAction UserSetChanged;

  public ThreadSafeHashSet<User> UserSet { get; }

  protected ControllerListAlias();

  public ControllerListAlias(
    IThreadSafeSubscriptions subs,
    IController parent,
    [ControllerPropertyName(null)] string propertyName);
}
