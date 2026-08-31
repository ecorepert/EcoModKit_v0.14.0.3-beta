// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.IController
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Systems;
using Eco.Shared.View;

#nullable disable
namespace Eco.Core.Controller;

/// <summary>
/// 1. Needs this block to implement the interfaces
/// int IHasUniversalID.ControllerID { get; set; }
/// 2. Add [SyncToView] to properties/methods you wish to synchronize with the view.
/// </summary>
public interface IController : IViewController, IHasUniversalID
{
}
