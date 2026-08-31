// Decompiled with JetBrains decompiler
// Type: Eco.Core.Systems.IHasID
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Core.Systems;

[ForceCreateView]
[Serialized]
public interface IHasID : 
  IController,
  IViewController,
  IHasUniversalID,
  INamed,
  IReInitializable,
  IHasReferenceableSerializableID,
  IHasSerializableID
{
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  static int GetId(IHasID hasID);

  [ClientInterfaceProperty]
  int Id { get; }

  void Initialize();

  void Destroyed();

  /// <summary>If true, can be deleted by admins</summary>
  bool CanBeDeleted { get; }

  /// <summary>Entity state verification function. Used by <see cref="T:Eco.Core.Systems.IRegistrar" /> to verify if entity's state isn't corrupted. All corrupted entities will be removed from registry. Called when serialization finished (fixups applied and PostLoad methods invoked).</summary>
  Result Verify();

  /// <summary>Return a name that can be used for forming a link, e.g. used in ObjectFinders.cs. Some objects require a specific string to be parsed as a link, e.g. Channels.</summary>
  string GetLinkableName();

  void OnRemovingDueVerifyFailed();

  LocString INamed.SafeMarkedUpName { get; }

  new LocString SafeMarkedUpName { get; }
}
