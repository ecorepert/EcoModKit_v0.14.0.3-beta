// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Misc.CivicsClipboard
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;

#nullable disable
namespace Eco.Gameplay.Civics.Misc;

/// <summary>Per-user server-side clipboard for civics list entries. Stores a snapshot at copy time (the source can be freely edited or deleted afterwards) and hands out a fresh clone per paste. Session-lifetime, not serialized.</summary>
public static class CivicsClipboard
{
  /// <summary>Snapshots <paramref name="entry" /> into <paramref name="user" />'s clipboard.</summary>
  public static void Set(User user, object entry);

  /// <summary>Outputs a fresh clone of the clipboard content so repeated pastes give independent instances. Returns false when the clipboard is empty.</summary>
  public static bool TryGetFresh(User user, out object clone);
}
