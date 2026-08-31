// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.DynamicValues.LayerModifiedValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.DynamicValues;

public class LayerModifiedValue : IDynamicValue, IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  public string Layer { get; }

  [SyncToView(null, true)]
  public bool CheckArea { get; }

  [SyncToView(null, true)]
  public float Radius { get; set; }

  public ref int ControllerID { get; }

  public LayerModifiedValue(string layer, float radius);

  public float GetBaseValue { get; }

  public float GetCurrentValue(IDynamicValueContext context, object obj);

  public int GetCurrentValueInt(IDynamicValueContext context, object obj, float multiplier = 1f);
}
