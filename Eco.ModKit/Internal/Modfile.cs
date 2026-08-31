// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.Internal.Modfile
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

#nullable disable
namespace Eco.ModKit.Internal;

public class Modfile
{
  public int id { get; set; }

  public int mod_id { get; set; }

  public int date_added { get; set; }

  public int date_scanned { get; set; }

  public Modfile.VirusStatus virus_status { get; set; }

  public Modfile.VirusResult virus_positive { get; set; }

  public string virustotal_hash { get; set; }

  public int filesize { get; set; }

  public Filehash filehash { get; set; }

  public string filename { get; set; }

  public string version { get; set; }

  public string changelog { get; set; }

  public string metadata_blob { get; set; }

  public Download download { get; set; }

  public enum VirusStatus
  {
    NotScanned,
    ScanComplete,
    ScanInProgress,
    TooLargeToScan,
    FileNotFound,
    ErrorScanning,
  }

  public enum VirusResult
  {
    NoThreatsDetected,
    FlaggedAsMalicious,
  }
}
