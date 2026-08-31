// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.ResidencyManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.GameActions;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

#nullable enable
namespace Eco.Gameplay.Property;

[Serialized]
public class ResidencyManager : Singleton<ResidencyManager>, IGameActionAware, ICanOverrideAuth
{
  void IGameActionAware.ActionPerformed(GameAction action);

  public LazyResult ShouldOverrideAuth(IAlias? alias, IOwned? property, GameAction? action);
}
