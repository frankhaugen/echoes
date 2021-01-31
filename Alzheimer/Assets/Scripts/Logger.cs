using UnityEngine;

public class Logger : MonoBehaviour
{
    void LogV1()
    {
        Debug.Log(gameObject.name);
    }
    
    public void LogV2()
    {
        Debug.Log(gameObject.name);
    }
    
    bool LogV3()
    {
        Debug.Log(gameObject.name);

        return true;
    }
}
