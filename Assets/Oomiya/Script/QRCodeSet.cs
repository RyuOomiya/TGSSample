using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QRCodeSet : MonoBehaviour
{
    [SerializeField] GameObject _qrCube;
    private Vector3 _mousePos;
    public Vector3 MousePos => _mousePos;
    public bool _qrCodeSet = false;
    
    private void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 tmpPos = Input.mousePosition;
            tmpPos.z = 10f;
            _mousePos = Camera.main.ScreenToWorldPoint(tmpPos);
            _qrCodeSet = true;
            Instantiate(_qrCube,_mousePos,Quaternion.identity);
        }
    }
}
