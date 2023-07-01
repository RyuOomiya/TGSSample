using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreate : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    [SerializeField] List<GameObject> _maps = new List<GameObject>();

    void Start()
    {
        for(int i =  0; i < _maps.Count; i++)
        {
            RandamCreate(i);
        }
    }

    void Update()
    {
        
    }

    void RandamCreate(int num)
    {
        int createNum = 0;
        int createPosX = 0;
        int fieldSize = 0;

        switch (num)
        {
            case 0: createNum = 10; createPosX = 0; fieldSize = 10; break;
            case 1: createNum = 60; createPosX = 60; fieldSize = 25; break;
            case 2: createNum = 250; createPosX = 150; fieldSize = 50; break;
        }

        Debug.Log(createPosX);

        int tmp = fieldSize / 2;

        for (int i  = 0; i < createNum; i++)
        {
            Instantiate(_prefab, new Vector3(UnityEngine.Random.Range(createPosX-tmp, createPosX+ tmp),
            0.5f, UnityEngine.Random.Range(-tmp, tmp)), Quaternion.identity);
        }
    }
}
