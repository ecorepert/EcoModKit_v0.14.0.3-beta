// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ChangeNotificationUtils
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller;
using System.ComponentModel;

#nullable disable
namespace Eco.Shared.Utils;

public static class ChangeNotificationUtils
{
  /// <summary>Glue coded to connect a fody automatic change notification (which happens through the INotifyPropertyChanged interface) to a separate controller./// </summary>
  public static void PropagateChange(
    this IController controller,
    object sender,
    PropertyChangedEventArgs e);
}
