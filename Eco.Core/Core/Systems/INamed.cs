// Decompiled with JetBrains decompiler
// Type: Eco.Core.Systems.INamed
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.View;

#nullable disable
namespace Eco.Core.Systems;

[ForceCreateView]
public interface INamed : IController, IViewController, IHasUniversalID
{
  [ClientInterfaceProperty]
  [EcoTextLimit(EcoTextLimitAttribute.TextRangeStyle.Title)]
  string Name { get; set; }

  [ClientInterfaceProperty]
  LocString MarkedUpName { get; }

  LocString SafeMarkedUpName { get; }

  void OnRenamed(string oldName);

  string ToString();
}
