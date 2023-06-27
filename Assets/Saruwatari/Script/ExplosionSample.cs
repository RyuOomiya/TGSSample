using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSample : MonoBehaviour
{
    [SerializeField] GameObject gameObject;//�����n�_�A�}�E�X�̍��W�ɕς�����
    [SerializeField] float _force = 20;//�^�����
    [SerializeField] float _radius = 5;//�͈�
    [SerializeField] float _upwards = 0;//������̗�
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
        _position = gameObject.transform.position;//�����n�_�A�}�E�X�̍��W���~�����i����gameObject�̍��W�ɂȂ��Ă�j

        // �͈͓���Rigidbody��AddExplosionForce
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
