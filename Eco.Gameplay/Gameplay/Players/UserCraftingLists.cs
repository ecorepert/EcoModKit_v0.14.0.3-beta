// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.UserCraftingLists
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Players;

/// <summary> Used for crafting lists saved by players for different workbenches.
/// Players may save crafting lists, add and remove recipes to and from them, and use them to filter recipes at any bench. </summary>
[Serialized]
public class UserCraftingLists : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  public bool TryGetListById(string id, out CraftingList list);

  public string CreateCraftingList(string name);

  public void DeleteCraftingList(string id);

  public void AddRecipeToCraftingList(string id, int recipeTypeId);

  public void RemoveRecipeFromCraftingList(string id, int recipeTypeId);
}
