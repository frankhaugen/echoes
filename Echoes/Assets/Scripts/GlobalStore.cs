using UnityEngine;

public static class GlobalStore
{
    private static AudioSource _audioSource;

    public static AudioSource GetAudioSource()
    {
        return _audioSource;
    }
        
    public static void SetAudioSource(AudioSource audioSource)
    {
        _audioSource = audioSource;
    }
}