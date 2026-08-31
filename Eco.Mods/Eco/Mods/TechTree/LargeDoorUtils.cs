// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.LargeDoorUtils
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Components;
using Eco.Gameplay.Objects;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Mods.TechTree;

public static class LargeDoorUtils
{
  public static void InitializeDoor(WorldObject door);

  /// <summary> Custom messages container for the OnOffComponent of Large Doors.</summary>
  private class LargeDoorMessagesContainer : OnOffComponent.IOnOffMessagesContainer
  {
    public LocString TurnOnMessage { get; }

    public LocString TurnOffMessage { get; }

    public LocString TurnedOnMessage { get; }

    public LocString TurnedOffMessage { get; }

    public LocString NotAuthedMessage { get; }

    public LocString InvalidStatusMessage { get; }
  }
}
