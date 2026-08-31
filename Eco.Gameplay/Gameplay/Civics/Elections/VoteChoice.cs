// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Elections.VoteChoice
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Serialization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Civics.Elections;

[Serialized]
[Eco.Shared.Networking.Eco(true)]
public class VoteChoice : IController, IViewController, IHasUniversalID
{
  [Serialized]
  public ElectionChoiceID ChoiceID;

  [Eco.Shared.Networking.Eco(true)]
  [AllowNullInView]
  public string Description { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public int Rank { get; set; }

  public ref int ControllerID { get; }
}
