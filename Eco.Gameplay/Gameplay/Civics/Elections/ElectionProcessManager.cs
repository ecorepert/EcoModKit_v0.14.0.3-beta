// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Elections.ElectionProcessManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Systems;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Gameplay.Civics.Elections;

public class ElectionProcessManager : 
  Singleton<ElectionProcessManager>,
  IRegistrarManager<ElectionProcess, SpecialElectionProcess>,
  IRegistrarManager
{
  public Eco.Core.Systems.Registrar<ElectionProcess> Registrar { get; }

  public ElectionProcess[] SpecialEntries { get; set; }

  public ElectionProcess BasicElection { get; }

  public void Initialize();

  bool IRegistrarManager<ElectionProcess, SpecialElectionProcess>.ShouldMakeSpecialEntry(
    SpecialElectionProcess entry);

  public void InitSpecialEntry(ElectionProcess specialEntry);
}
