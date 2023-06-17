using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] QRCodeSet _qrSet;
    [SerializeField] Explosion _explosion;
    Vector3 _qrPos;
    public bool _qrDetection;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_explosion.DebugType == Explosion.DebugExplodeType.QRDetection)
        {
            _qrDetection = true;
        }
        else _qrDetection = false;

        if(_explosion.DebugType == Explosion.DebugExplodeType.MouseClick)
        {
            if(Input.GetMouseButtonDown(1))
            {
                Vector3 tmpPos = Input.mousePosition;
                tmpPos.z = 10f;
                _explosion.Explode(Camera.main.ScreenToWorldPoint(tmpPos));
            }
        }
    }

    public void QRDetection(Vector3 pos)
    {
        _explosion.Explode(pos);
    }
}
