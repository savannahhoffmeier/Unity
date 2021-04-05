using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Test : MonoBehaviour
{
    float movementSpeed = 100f;
    private Rigidbody rb;
    private void FaceTarget(Vector3 destination)
    {
        Vector3 lookPos = destination - transform.position;
        lookPos.y = 0;
        Quaternion rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 15);  
        rb.GetComponent<Rigidbody>().velocity = transform.forward * Time.deltaTime * movementSpeed;
        
    }
}