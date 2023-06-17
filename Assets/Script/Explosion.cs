using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public enum DebugExplodeType
    { 
        MouseClick,
        QRDetection
    }
    
    [SerializeField] DebugExplodeType _debugType;
    public DebugExplodeType DebugType => _debugType;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Explode(Vector3 pos)
    {
        Debug.Log(pos);
    }
}
