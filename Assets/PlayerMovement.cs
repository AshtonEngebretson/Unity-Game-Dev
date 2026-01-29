using UnityEngine;

public class PlayerMovement : MonoBehaviour
{  
    public float speed = 5f; // How fast the player moves  
    Rigidbody rb;  
  
    void Start()  
    {  
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody on this object  
    }  
  
    void FixedUpdate()  
    {  
        float moveX = Input.GetAxis("Horizontal"); // A/D or Left/Right  
        float moveZ = Input.GetAxis("Vertical");   // W/S or Up/Down  
  
        Vector3 move = new Vector3(moveX, 0, moveZ) * speed;  
        rb.linearVelocity = new Vector3(move.x, rb.linearVelocity.y, move.z); // Move the player  
    }  
}
