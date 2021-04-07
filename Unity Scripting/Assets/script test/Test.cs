using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Test : MonoBehaviour
{
    public float jumpHeight = 7f;
    public bool isGrounded;
    public float NJumps = 0f;
    public float MJumps = 2;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (NJumps > MJumps - 1)
        {
            isGrounded = false;
        }

        if (isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.AddForce(Vector3.up * jumpHeight);
                NJumps += 1;
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        isGrounded = true;
        NJumps = 0;
    }
 
}