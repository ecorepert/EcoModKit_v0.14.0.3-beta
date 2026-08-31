// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Skills.TalentManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using PropertyChanged;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Skills;

/// <summary>This manager is responsible for talent collection and also for talents versioning.
/// If the version set in <see cref="F:Eco.Gameplay.Skills.TalentManager.DefaultVersion" /> is higher then <see cref="F:Eco.Gameplay.Skills.TalentManager.CurrentVersion" /> (which loads from serialized data)
/// all talents for all users will be reset.</summary>
[Serialized]
public class TalentManager : Singleton<
#nullable disable
TalentManager>
{
  public static Talent[] AllTalents;
  public static Dictionary<Type, Talent> TypeToTalent;
  /// <summary>Cached list of every concrete Talent Type. Populated once at init so commands don't allocate a fresh list on every invocation.</summary>
  public static IReadOnlyList<Type> AllTalentTypes;
  [Serialized]
  public float CurrentVersion;
  public const float DefaultVersion = 1f;

  [OnDeserialized]
  public void CheckVersion();

  public static void InitializeTalents();

  [DoNotNotify]
  public ref int ControllerID { get; }
}
