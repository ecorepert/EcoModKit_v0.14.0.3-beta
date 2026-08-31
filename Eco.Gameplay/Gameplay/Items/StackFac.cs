// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.StackFac
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;

#nullable disable
namespace Eco.Gameplay.Items;

public static class StackFac
{
  public static IStack Make(IController t, int quantity);

  public static void Modify(this IStack stack, int quantity);

  public static void AddQuantity(this IStack stack, int delta);
}
