// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ProfaneWords
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary>
/// Singleton instance for loading the profane words used by the <see cref="T:Eco.Shared.Utils.ProfanityFilter" /> singleton.
/// Loads a profanity list obtained from https://github.com/shutterstock/List-of-Dirty-Naughty-Obscene-and-Otherwise-Bad-Words on Eco Server with other languages available at the link.
/// Non Eco Server use cases can be loaded via the <see cref="F:Eco.Shared.Utils.ProfaneWords.OverrideLoad" /> static <see cref="T:System.Func`2" /> variable.
/// </summary>
public class ProfaneWords : AutoSingleton<ProfaneWords>
{
  /// <summary>Hook for providing custom profane word loading instead of the default "Profanity.eco" file in Eco Server. Generally used by Eco Client.</summary>
  public static Func<string[]>? OverrideLoad;

  /// <summary>Loads the local profanity file into memory or loads the words provided by the <see cref="F:Eco.Shared.Utils.ProfaneWords.OverrideLoad" /> attribute if present.</summary>
  /// <returns>Loaded profane words to censor.</returns>
  public IEnumerable<string> Load();
}
