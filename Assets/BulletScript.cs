using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    [SerializeField] private float _BulletSpeed = 60.0f;
    private Rigidbody2D _RigidBody2D;
    private bool _OnScreen;

    void Awake ()
	{;
	    _RigidBody2D = GetComponent<Rigidbody2D>();
	    _RigidBody2D.velocity = Vector2.up*_BulletSpeed;
	}
}
