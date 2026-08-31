// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Gameplay.EditableEntryStatus
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Gameplay;

public class EditableEntryStatus
{
  [Eco.Shared.Networking.Eco(true)]
  public bool AllowNameChange { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public int MaxArea { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public bool Readonly { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public bool AllowDelete { get; set; }
}
