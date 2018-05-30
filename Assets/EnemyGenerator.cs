using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private float _spawnTimeSpan;
    private float _spawnTimer;
    private float _positionY;
    private Quaternion _quaternion;

    void Awake()
    {
        _positionY = GetComponent<Transform>().position.y;
        _quaternion=new Quaternion(0,0,0,0);
        _spawnTimer = _spawnTimeSpan;
    }

    void FixedUpdate()
    {
        _spawnTimer -= Time.fixedDeltaTime;
        if (_spawnTimer <= 0)
        {
            GenerateEnemy();
            _spawnTimer = _spawnTimeSpan;
        }
    }

    //-25<->25
    private void GenerateEnemy()
    {
        for (int i = -25; i <= 25; i+=7)
        {
            GameObject.Instantiate(_enemy, new Vector3(i, _positionY+Math.Abs(i/2), -1), _quaternion);
        }
        
    }
}
