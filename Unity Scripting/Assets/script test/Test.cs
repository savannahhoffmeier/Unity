using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Test : MonoBehaviour
{
    private GameObject Point;
    private Vector3 wayPointPos;
   
    private float speed = 6.0f;
    void Start ()
    {
       
        wayPoint = GameObject.Find("wayPoint");
    }
 
    void move()
    {
        wayPointPos = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
        
        transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
    }
 


    
    public GameObject wayPoint;
    
    private float timer = 0.5f;
 
    void Update ()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if(timer <= 0)
        {
            
            UpdatePosition();
            timer = 0.5f;
        }
    }

    void UpdatePosition()
    {

        wayPoint.transform.position = transform.position;
    }
}