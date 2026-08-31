// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.EducationContext
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Components;

[Eco.Shared.Networking.Eco(true)]
public class EducationContext : IContextObject, IController, IViewController, IHasUniversalID
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The student being educated.")]
  public User Student { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The teacher of the class.")]
  public User Teacher { get; set; }

  public ref int ControllerID { get; }
}
