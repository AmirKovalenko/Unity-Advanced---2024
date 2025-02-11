using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    private static string MASTER_VOLUME_PARAMETER = "Master";
    private static string SFX_VOLUME_PARAMETER = "SFX";
    private static string MUSIC_VOLUME_PARAMETER = "Music";

    [SerializeField] private AudioMixerGroup mainMixer;
    [SerializeField] private AudioMixerGroup SFXMixer;
    [SerializeField] private AudioMixerGroup musicMixer;
    private float savedVolume = 0;
    private bool isMuted = false;

    public void MasterVolumeSliderChanged(float newValue)
    {
        float actualVolumeValue = (newValue);
        savedVolume = newValue;
        if (!isMuted)
            mainMixer.audioMixer.SetFloat(MASTER_VOLUME_PARAMETER, newValue);
    }

    public void SFXVolumeSliderChanged(float newValue)
    {
        float actualVolumeValue = (newValue);
        SFXMixer.audioMixer.SetFloat(SFX_VOLUME_PARAMETER, newValue);
    }

    public void MusicVolumeSliderChanged(float newValue)
    {
        float actualVolumeValue = (newValue);
        musicMixer.audioMixer.SetFloat(MUSIC_VOLUME_PARAMETER, newValue);
    }

    public void MuteToggle()
    {
        if (!isMuted)
        {
            mainMixer.audioMixer.SetFloat(MASTER_VOLUME_PARAMETER, -80);
            isMuted = true;
        }
        else if (isMuted)
        {
            mainMixer.audioMixer.SetFloat(MASTER_VOLUME_PARAMETER, savedVolume);
            isMuted = false;
        }
    }

}
