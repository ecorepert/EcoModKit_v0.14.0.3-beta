// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.EcopediaRoot.IEcopediaTab
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.EcopediaRoot;

public interface IEcopediaTab : IPrioritizedPage, IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  string IconName { get; set; }

  [SyncToView(null, true)]
  string Summary { get; set; }

  [SyncToView(null, true)]
  string FullName { get; set; }
}
