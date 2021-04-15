using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Test : MonoBehaviour
{ float Speed= 20;
    private Vector3 wayPoint;
    float Range= 10; 
 
    private void Start()
    {
      
        Wander();
    }
 
    private void Update() 
    {
        
        transform.position += transform.TransformDirection(Vector3.forward)*Speed*Time.deltaTime;
        if((transform.position - wayPoint).magnitude < 3)
        {
            
            Wander();
 
 
        }
    }
 
    private void Wander()
    { 
      
     
        wayPoint= new Vector3(Random.Range(transform.position.x - Range, transform.position.x + Range), 1, Random.Range(transform.position.z - Range, transform.position.z + Range));
        wayPoint.y = 1;
     
        transform.LookAt(wayPoint);
        Debug.Log(wayPoint + " and " + (transform.position - wayPoint).magnitude);
    }
}