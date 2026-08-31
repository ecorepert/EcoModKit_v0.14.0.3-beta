// Decompiled with JetBrains decompiler
// Type: Eco.Core.Systems.GlobalRefBase
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Core.Systems;

public abstract class GlobalRefBase : IController, IViewController, IHasUniversalID
{
  [Serialized]
  [SyncToView(null, true)]
  public Type Type { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public int Id { get; set; }

  public ref int ControllerID { get; }
}
