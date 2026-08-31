// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.CreateComponentTabLoc
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.View;

#nullable disable
namespace Eco.Core.Controller;

/// <summary>For WorldObjectComponents, ensures that a tab is created in the UI for it. The client looks for a property named ComponentTabName to determine the name. If not available then it will use class DisplayName. </summary>
public class CreateComponentTabLoc : ViewClassAttribute
{
  public string IconName;

  public CreateComponentTabLoc(string tabName = null, bool activeWhenDisabled = false);

  public override ViewClassFlags Flags { get; }
}
