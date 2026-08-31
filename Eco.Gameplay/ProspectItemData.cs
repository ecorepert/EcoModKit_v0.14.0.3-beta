// Decompiled with JetBrains decompiler
// Type: ProspectItemData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Math;
using Eco.Shared.View;

#nullable disable
public class ProspectItemData : IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  public int ItemTypeId { get; set; }

  [SyncToView(null, true)]
  public Vector3i Position { get; set; }

  [SyncToView(null, true)]
  public float ProspectSeconds { get; set; }

  public ref int ControllerID { get; }
}
