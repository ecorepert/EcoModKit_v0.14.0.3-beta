// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.ICopyPasteComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Objects;

/// <summary>Implemented by components whose player-editable settings can be pasted from another component of the same group.</summary>
public interface ICopyPasteComponent
{
  /// <summary>Components are paste-compatible only when their groups match, usually the shared base type that holds the copyable data.</summary>
  Type CopyPasteGroup { get; }

  /// <summary>Overwrite this component's settings from a compatible source. Returns a result for user feedback.</summary>
  Result CopyFrom(WorldObjectComponent source, Player player);

  /// <summary>What pasting would destroy on this component, asked for confirmation first. Empty when there is nothing worth warning about.</summary>
  LocString OverwriteWarning { get; }
}
