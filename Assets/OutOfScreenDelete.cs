using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class OutOfScreenDelete : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private bool _OnScreen;

    void Awake ()
	{
	    _spriteRenderer= GetComponent<SpriteRenderer>();
	}
	
	void FixedUpdate ()
	{
		CheckIfOnScreen();
	}

    void CheckIfOnScreen()
    {
        if (_spriteRenderer.isVisible)
        {
            _OnScreen = true;
        }
        if (_OnScreen && !_spriteRenderer.isVisible)
        {
            Destroy(gameObject);
        }
    }
}
