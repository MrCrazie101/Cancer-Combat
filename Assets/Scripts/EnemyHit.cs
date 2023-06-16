using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    private int health = 2;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            health -= 1;

            if (health <= 0)
                Destroy(gameObject);

            Destroy(collision.gameObject);
        }
    }
}