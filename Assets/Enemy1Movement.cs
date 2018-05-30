using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Enemy1Movement : MonoBehaviour
{
    [SerializeField] private float _Speed;
    private Rigidbody2D _RigidBody2D;

    void Awake()
    {
        _RigidBody2D = GetComponent<Rigidbody2D>();
        _RigidBody2D.velocity=new Vector2(0,_Speed*-1);
    }
}
