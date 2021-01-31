using UnityEngine;

public class EndMusic : MonoBehaviour
{
    public MusicPlayer MusicPlayer;
    
    void OnMouseDown()
    {
        MusicPlayer.End();
    }
}
