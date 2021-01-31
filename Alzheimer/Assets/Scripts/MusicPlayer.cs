using System.Collections;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource Intro;
    public AudioSource Loop;
        
    void Start()
    {
        StartCoroutine(FadeIn());
    }

    private void OnDestroy()
    {
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeIn() {
        Intro.volume = 0;
        var speed = 0.01f;   
        Intro.Play();
        
        for (float i = 0; i < 1; i += speed)
        {
            Intro.volume = i;
            yield return new WaitForSeconds(0.2f);
        }
        
        Loop.loop = true;
        Loop.Play();
    }
        
    IEnumerator FadeOut() {
        Loop.volume = 1;
        var speed = 0.01f;   
        Loop.Stop();
        StopCoroutine(FadeIn());
        for (float i = 1; i > 0; i -= speed)
        {
            Loop.volume = i;
            yield return new WaitForSeconds(0.2f);
        }
        Loop.Stop();
    }

    public void End() => StartCoroutine(FadeOut());
}