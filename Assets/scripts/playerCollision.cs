using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public Transform player;
    public Rigidbody rb;

    // called whenever this object collides with another object

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
