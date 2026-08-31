// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.LawUtil
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.GameActions;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using System;

#nullable enable
namespace Eco.Gameplay.Civics.Laws;

public static class LawUtil
{
  /// <summary>Create a list of all the laws at the given position.</summary>
  public static LocString DescribeActiveLawsAtPosition(Vector2i pos);

  /// <summary>Counts the active laws of all settlements at this position.</summary>
  public static int CountActiveLawsAtPosition(Vector2i pos);

  public static 
  #nullable disable
  LawSection GetSectionContainingAction(this Law law, LegalAction action);

  public static bool AnyTriggerSpecifies(
    this LawSection section,
    Type triggerType,
    string propertyName,
    Type typeToMatch);

  public static bool AnyTriggerSpecifies(
    this LawSection section,
    Type triggerType,
    string propertyName,
    object obj);

  internal static PostResult TryPrevent(LegalAction legalAction, Law law, IContextObject action);
}
