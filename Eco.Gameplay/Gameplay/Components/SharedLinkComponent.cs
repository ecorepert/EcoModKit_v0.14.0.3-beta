// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.SharedLinkComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary> This link component uses parent owner's shared link settings if provided alias has full access to the property.
/// In other words, users with full access can change linked objects and expect that other owners will also receive these changes.
/// Currently used for stores. </summary>
[Serialized]
[Priority(2147483647 /*0x7FFFFFFF*/)]
[CreateComponentTabLoc("Storage", false)]
[HasIcon("StorageComponent")]
public class SharedLinkComponent : LinkComponent
{
  /// <summary> Checks whether this alias has full access to the property. </summary>
  protected bool HasFullAccess(IAlias alias);

  /// <summary> Overrides provided alias if it has full access (replaces it with parent owner). </summary>
  protected override IAlias LinkSettingsAlias(IAlias alias);

  protected override bool SharesSettingsFor(IAlias alias);
}
