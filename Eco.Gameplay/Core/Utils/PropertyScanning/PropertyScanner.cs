// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.PropertyScanning.PropertyScanner
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System.Collections.Generic;

#nullable enable
namespace Eco.Core.Utils.PropertyScanning;

/// <summary>PropertyScanner that does a scan on an object, using reflection to examine and update its properties.  It can do the following things:
/// - Detect if the object is valid, using attributes like [AllowNull] and others to help it determine what is valid or not.
/// - Caches validity if has the ICachesValidity interface. Returns the Result.
/// - Returns paths of all the properties that were invalid, which allows the client to display markers and text on them.
/// - Updates tracked references and referenced-by, which are stored in  ker.
/// - Fixes parameters referencing bad context
/// - Can apply reference updating (when an object gets swapped for another, modified through election for example).
/// - Sets up any instances of IParentedController it finds, configuring the hierarchy.
/// </summary>
public static class PropertyScanner
{
  /// <summary>Can be subscribed to in order to perform an action after full scan is complete. </summary>
  public static 
  #nullable disable
  Initializer FirstFullScanInitializer;

  public static ScanResults Scan(IEnumerable<object> objs);

  public static ScanResults Scan(object obj);

  public static ScanResults ScanAll();

  public static ScanResults Scan(ScanSettings settings, bool firstScan = false);
}
