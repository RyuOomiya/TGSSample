using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QRCodeSet : MonoBehaviour
{
    [SerializeField] GameObject _qrCube;
    [SerializeField] GameManager _gameManager; //‘ŠŒÝŽQÆ‚É‚È‚é‚Ì‚Å‚ ‚ñ‚Ü‚æ‚­‚Í‚È‚¢
    private Vector3 _mousePos;
    public Vector3 MousePos => _mousePos;
    public bool _qrCodeSet;
    
    private void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 tmpPos = Input.mousePosition;
            tmpPos.z = 10f;
            _mousePos = Camera.main.ScreenToWorldPoint(tmpPos);
            if (_gameManager._qrDetection) _gameManager.QRDetection(_mousePos);
            Instantiate(_qrCube,_mousePos,Quaternion.identity);

           
        }
    }
}
