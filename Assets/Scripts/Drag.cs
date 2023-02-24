using UnityEngine;

public class Drag : MonoBehaviour
{
    public float slowDownFactor; // adjust this to control how much the object slows down
    public GameObject obj;

    private Rigidbody rb;

    private void Start()
    {
        rb = obj.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Slow down the object in the x and z-axis
        Vector3 currentVelocity = rb.velocity;
        currentVelocity.x *= slowDownFactor;
        currentVelocity.z *= slowDownFactor;
        rb.velocity = currentVelocity;
    }
}
