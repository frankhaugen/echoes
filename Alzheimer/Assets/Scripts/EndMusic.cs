using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EndMusic : MonoBehaviour
{
    public MusicPlayer MusicPlayer;
    
    void OnMouseDown()
    {
        MusicPlayer.End();
    }
}
