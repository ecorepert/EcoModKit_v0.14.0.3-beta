// Decompiled with JetBrains decompiler
// Type: Eco.Shared.SharedTypes.ClientSideEnvVars
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.SharedTypes;

/// <summary> Client side environment variables guaranteed to be on client at all times. </summary>
/// <remarks> Can be used in a string with the %VARNAME% syntax to get replaced with the respective text in client. </remarks>
public class ClientSideEnvVars
{
  public const string Selected = "Selected";
  public const string SelectedNonTool = "SelectedNonTool";
  public const string Carried = "Carried";
  public const string Exitable = "Exitable";
  public const string Mounted = "Mounted";
  public const string Targeted = "Targeted";
  public const string HasDebrisPickup = "HasDebrisPickup";
  public const string TargetHasRoutedPipe = "TargetHasRoutedPipe";
}
