using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSample : MonoBehaviour
{
    [SerializeField] GameObject gameObject;//爆発地点、マウスの座標に変えたい
    [SerializeField] float _force = 20;//与える力
    [SerializeField] float _radius = 5;//範囲
    [SerializeField] float _upwards = 0;//上向きの力
    Vector3 _position;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Explosion();
        }
    }

    public void Explosion()
    {
        _position = gameObject.transform.position;//爆発地点、マウスの座標が欲しい（今はgameObjectの座標になってる）

        // 範囲内のRigidbodyにAddExplosionForce
        Collider[] hitColliders = Physics.OverlapSphere(_position, _radius);
        for (int i = 0; i < hitColliders.Length; i++)
        {
            var rb = hitColliders[i].GetComponent<Rigidbody>();
            if (rb)
            {
                rb.AddExplosionForce(_force, _position, _radius, _upwards, ForceMode.Impulse);
            }
        }
    }
}
