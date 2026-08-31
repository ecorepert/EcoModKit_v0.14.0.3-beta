// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.IClearRequestHandler
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary> Item data class with this interface will be notified when someone decides to manually reset the item's persistent data (e.g. via a tooltip).
/// Result message will be shown to the player. Entries that return failed result will not be removed from the list. </summary>
public interface IClearRequestHandler
{
  Result TryHandleClearRequest(Player player);

  bool HasDataThatCanBeCleared { get; }
}
