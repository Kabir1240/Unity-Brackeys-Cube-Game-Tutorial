using UnityEngine;

public class followPLayer : MonoBehaviour
{
    //instance of the player object
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
