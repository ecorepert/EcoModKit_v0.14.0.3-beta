// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.IContainsDynamicFlags
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Utils;

/// <summary> Properties with [DynamicFlags] attribute will result client side's selector to try to look for this container in their parent.
/// If there is an entry with the same name, then selector will use contained flags instead of the default ones.
/// Nothing will be replaced if there is no such entry.
/// For a demo see how wages declare their WagesPaidFromAccount and how AppointedTitle clears its InJurisdiction flag. </summary>
[ForceCreateView]
public interface IContainsDynamicFlags : IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  Dictionary<string, ViewSelectorFlags> PropNameToDynamicFlags { get; set; }
}
