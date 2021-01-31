using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour 
{
    private static MusicManager _instance;
 
    public static MusicManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = GameObject.FindObjectOfType<MusicManager>();
 
                //Tell unity not to destroy this object when loading a new scene!
                DontDestroyOnLoad(_instance.gameObject);
            }
 
            return _instance;
        }
    }
 
    void Awake() 
    {
        if(_instance == null)
        {
            //If I am the first instance, make me the Singleton
            _instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            //If a Singleton already exists and you find
            //another reference in scene, destroy it!
            if(this != _instance)
                Destroy(gameObject);
        }
    }

    public AudioSource Music;

    public AudioClip[] AudioClips;
    private int playingSong = 0;
    
    public void Start()
    {
        if (!Music.isPlaying)
        {
            Music.clip = AudioClips[playingSong];
            Music.Play();
        }
    }

    public void NextSong()
    {
        playingSong += 1;
        
        Music.Stop();
        Music.clip = AudioClips[playingSong];
    }
}