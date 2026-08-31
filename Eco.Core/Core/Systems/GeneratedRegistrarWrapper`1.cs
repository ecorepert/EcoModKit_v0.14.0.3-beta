// Decompiled with JetBrains decompiler
// Type: Eco.Core.Systems.GeneratedRegistrarWrapper`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable enable
namespace Eco.Core.Systems;

/// <summary>
/// A generated registrar is one whose data is created entirely dynamically, but then stored as an ID.
/// It wraps a regular registrar, allowing it to save references and get the usual registrar benefits (linking, etc)
/// It functions by only saving names-&gt;IDs, and fixing up on load. This allows us to use regular reference serialization (ie, you
/// can store references to Tags instead of some TagHandle class), as well as makes the storage of tags a direct reference when
/// running, and simply an int ID otherwise.
/// We make this a templated class so we have separate statics for each type that implements it (a trick to allow us to have serialization and
/// static data in a single structure).
/// </summary>
[Serialized]
public class GeneratedRegistrarWrapper<TContained> where TContained : class, IHasID
{
  public static GeneratedRegistrar<TContained> Reg;

  public void Init(
    LocString registrarName,
    bool shareWithClient,
    ISaveablePlugin save,
    string? ecopediaPageName = null);

  public static void SetupDone();
}
