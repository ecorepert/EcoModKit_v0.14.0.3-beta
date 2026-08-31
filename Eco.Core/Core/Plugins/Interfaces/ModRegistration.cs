// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.Interfaces.ModRegistration
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.View;
using StrangeCloud.Service.Client.Contracts;

#nullable disable
namespace Eco.Core.Plugins.Interfaces;

public class ModRegistration : IController, IViewController, IHasUniversalID
{
  /// <summary>Name matched to the mod database in strange cloud, if registered there.</summary>
  [SyncToView(null, true)]
  public string ModName { get; set; }

  [SyncToView(null, true)]
  public string ModDisplayName { get; set; }

  [SyncToView(null, true)]
  public string ModDescription { get; set; }

  [SyncToView(null, true)]
  public StrangeMod StrangeMod { get; set; }

  public ref int ControllerID { get; }
}
