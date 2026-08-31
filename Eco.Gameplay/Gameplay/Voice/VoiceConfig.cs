// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Voice.VoiceConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Voice;

[Localized(true, false, "", false)]
public class VoiceConfig
{
  [LocDescription("The maximum distance away from a speaker that a listener can hear the speaker.")]
  public int AudibleDistance { get; set; }

  [LocDescription("Controls the range within which a speaker’s audio remains at its original volume, and beyond which the loudness of the voice chat starts to fade out when heard.")]
  public int ConversationalDistance { get; set; }

  [LocDescription("Specifies the formula or curve that controls the shape of how the audio fades between the ConversationalDistance and the AudibleDistance. (1:InverseByDistance) - Fades voice quickly at first, buts slows down as you get further from conversational distance. (2:LinearByDistance) - Fades voice slowly at first, but speeds up as you get further from conversational distance. (3:ExponentialByDistance) - Voice within conversational distance is louder, but fades quickly beyond it.")]
  public AudioFadeModel AudioFadeModel { get; set; }

  [LocDescription("Controls the amplitude of the curve to make the attenuation of the voice chat loudness more or less extreme.")]
  public float AudioFadeIntensityByDistance { get; set; }
}
