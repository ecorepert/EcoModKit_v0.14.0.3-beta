// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Misc.IProposableContainer
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Civics.Misc;

[ForceCreateView]
public interface IProposableContainer : 
  IController,
  IViewController,
  IHasUniversalID,
  IFullDescribable,
  IDescribable
{
  [SyncToView(null, true)]
  IProposable Element { get; set; }

  IEnumerable<IProposable> AllElements { get; }

  IEnumerable<IProposable> ElementsBecomingActive { get; }

  IEnumerable<IProposable> ElementsBeingRemoved { get; }

  string TableHeader { get; }
}
