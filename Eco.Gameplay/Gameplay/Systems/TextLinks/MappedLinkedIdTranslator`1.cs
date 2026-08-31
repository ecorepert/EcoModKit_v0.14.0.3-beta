// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.TextLinks.MappedLinkedIdTranslator`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Systems;

#nullable enable
namespace Eco.Gameplay.Systems.TextLinks;

/// <summary>
/// <see cref="T:Eco.Gameplay.Systems.TextLinks.ObjectLinkIdTranslator`1" /> implementation with mapping between link id and object implementing <see cref="T:Eco.Core.Systems.IHasUniversalID" /> for not-entity objects (without own identity).
/// This mapping required for ensuring that link id is always mapped to same object for tooltip caching.
/// I.e. <see cref="T:Eco.Gameplay.Systems.TextLinks.Vector3Tooltip" /> may be created from link id string and doesn't have own identity, fully defined by content in the link id, but client may want to cache the tooltip by universal id.
/// So instead of creating new <see cref="T:Eco.Gameplay.Systems.TextLinks.Vector3Tooltip" /> object every time it will create it on demand (if not yet exists)
/// and then just return same object with same universal id every time when same link id requested.
/// </summary>
/// <remarks>
/// This mapping will never clear once mapped objects, because those may be remembered on client. Also the objects will be saved in <see cref="T:Eco.Core.Systems.UniversalIDs" /> mapping anyway.
/// It may lead to memory leaks, but as it only creates mapping on demand which starts as empty on every server restart and we assuming daily restart for big servers it shouldn't become an issue.
/// There potential optimizations which may be applied if problem starts being serious:
/// - Server may make regular clean ups for Mapping, removing oldest records, clients will be notified about released IDs and will just invalidate cache and re-request by link id if required;
/// - Don't use universal IDs for such objects and add support for tooltips for custom link ids.
/// But until we have real issue we decided to use simplest approach.
/// </remarks>
public abstract class MappedLinkedIdTranslator<T> : ObjectLinkIdTranslator<T> where T : ILinkable, IHasUniversalID
{
  /// <summary>Returns mapped <see cref="T:Eco.Core.Systems.IHasUniversalID" /> for <paramref name="linkId" /> or creates new if not yet mapped.</summary>
  protected sealed override T GetTypedLinkTarget(string linkId);

  /// <summary>Creates new <typeparamref name="T" /> object by content of <paramref name="linkId" />.</summary>
  protected abstract T CreateTypedLinkTarget(string linkId);
}
