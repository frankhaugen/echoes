using UnityEngine;

public class MusicStarter : MonoBehaviour
{
    public AudioClip Music;
    
    private void Start()
    {
        GlobalStore.SetAudioSource(new AudioSource()
        {
            clip = Music,
            loop = true,
            volume = 1.0f
        });
        
        
    }
}