// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.MaxStackSizeAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>
/// Define the max stack size of the item. Difficulty Settings may increase this value (<see cref="P:Eco.Gameplay.Items.ItemModifiers.StackSizeModifier" />)
/// </summary>
public class MaxStackSizeAttribute : ItemAttribute
{
  /// <summary>Controls the default maximum stack size of items. Override this to change the global stack size of items that don't already have an instance of <see cref="T:Eco.Gameplay.Items.MaxStackSizeAttribute" />. Defaults to 100.</summary>
  public static int Default { get; set; }

  public int MaxStackSize { get; }

  public MaxStackSizeAttribute();

  public MaxStackSizeAttribute(int maxStackSize);
}
