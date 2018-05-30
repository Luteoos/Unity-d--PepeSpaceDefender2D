using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private int _score;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
           var playerData=other.GetComponent<PlayerData>();
            playerData.ChangeHP(-_damage);
            playerData.ChangeScore(_score);
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Bullet")
        {
            GameObject.FindWithTag("Player").GetComponent<PlayerData>().ChangeScore(_score);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
