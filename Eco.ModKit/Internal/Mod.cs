// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.Internal.Mod
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

#nullable disable
namespace Eco.ModKit.Internal;

public class Mod
{
  public int id { get; set; }

  public int game_id { get; set; }

  public int status { get; set; }

  public int visible { get; set; }

  public User submitted_by { get; set; }

  public int date_added { get; set; }

  public int date_updated { get; set; }

  public int date_live { get; set; }

  public Logo logo { get; set; }

  public string name { get; set; }

  public string name_id { get; set; }

  public string summary { get; set; }

  public string description { get; set; }

  public string metadata_blob { get; set; }

  public string profile_url { get; set; }

  public Modfile modfile { get; set; }

  public ModMedia media { get; set; }

  public RatingSummary rating_summary { get; set; }

  public ModTag[] tags { get; set; }

  public string Filename { get; }

  public string UserCode { get; }

  public string Pathname { get; }

  public string Fullpath { get; }

  public string ExtractPath { get; }

  public string ManifestPath { get; }

  public bool Downloaded { get; }

  public bool Installed { get; }

  public bool Subscribed { get; }

  public enum Status
  {
    NotAccepted,
    Accepted,
    Archived,
    Deleted,
  }
}
