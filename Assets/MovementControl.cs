using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovementControl : MonoBehaviour
{

    [SerializeField] private float m_MaxSpeed = 10f;
    private Animator m_Anim;
    private Rigidbody2D m_Rigidbody2D;

    private void Awake()
    {
        m_Anim = GetComponent<Animator>();
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 direction = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W)) direction += new Vector2(0, 1);
        if (Input.GetKey(KeyCode.S)) direction += new Vector2(0, -1);
        if (Input.GetKey(KeyCode.A)) direction += new Vector2(-1, 0);
        if (Input.GetKey(KeyCode.D)) direction += new Vector2(1, 0);

        if (direction.x != 0 || direction.y != 0)
        {
            direction.Normalize();
            m_Rigidbody2D.MovePosition(m_Rigidbody2D.position + direction * m_MaxSpeed * Time.fixedDeltaTime);
        }
    }
}
