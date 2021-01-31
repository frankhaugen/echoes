using UnityEngine;

public class StartMusic : MonoBehaviour
{
    private void Start()
    {
        var audioSource = GlobalStore.GetAudioSource();
        
        audioSource.Play();

    }
}