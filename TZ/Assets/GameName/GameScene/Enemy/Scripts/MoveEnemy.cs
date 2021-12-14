using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector2.left * Enemy.speed * Time.deltaTime);
        if (transform.position.x < -11f) {
            Destroy(gameObject);
        }
    }
}
