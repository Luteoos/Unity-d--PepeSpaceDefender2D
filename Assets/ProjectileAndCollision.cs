using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ProjectileAndCollision : MonoBehaviour
{

    [SerializeField] private GameObject _projectile;
    [SerializeField] private float _rateOfFire;
    private float _RoFTimer;
    private Rigidbody2D _rigidBody2D;

	void Awake ()
	{
	    _rigidBody2D = GetComponent<Rigidbody2D>();
	}
    
	void FixedUpdate ()
	{
	    _RoFTimer -= Time.fixedDeltaTime;
        
	    if (_RoFTimer<=0 && Input.GetKey(KeyCode.Space))
	    {
	        _RoFTimer = _rateOfFire;

            Vector3 deployPosition = new Vector3(_rigidBody2D.position.x,_rigidBody2D.position.y,-1);
            Quaternion rotation = new Quaternion(0,0,0,0);
	        GameObject.Instantiate(_projectile,deployPosition,rotation);
        }
	}
}
