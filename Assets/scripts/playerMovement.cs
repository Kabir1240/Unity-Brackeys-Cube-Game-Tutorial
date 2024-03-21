using UnityEngine;

public class playerMovement : MonoBehaviour
{

    // used to call different properties of an object
    public Rigidbody rb;
    public Transform transform;

    // other variables
    public float forwardForce = 2000f;
    public float horizontalForce = 50f;


    // same as Update method (called once per frame, but unity prefers this for physics related stuff
    void FixedUpdate()
    {
        // adds force, Time,deltaTime makes sure force is same even when framerate is high or low
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // adds a forward force on z axis

        // moves player to the right using right key or 'D'
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // moves player to the left using left key or 'A'
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Ends game when player falls off the edge
        if (transform.position.y < -0.21f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
