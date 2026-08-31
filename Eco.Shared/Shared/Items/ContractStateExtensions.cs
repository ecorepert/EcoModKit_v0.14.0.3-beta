// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.ContractStateExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Shared.Items;

public static class ContractStateExtensions
{
  public static bool Done(this ProposableState state);

  /// <summary>Return the state's localized name with some nice coloring.</summary>
  public static LocString MarkedUpName(this ProposableState state);

  public static Color StateColor(this ProposableState state);
}
