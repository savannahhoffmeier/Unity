using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Test : MonoBehaviour
{
 public float attackSpeed = 4;
     public float attackDistance;
     public float waitDistance;
     public GameObject player;
 
     Transform playerTransform;
 
     void GetPlayerTransform()
     {
         if (player != null)
         {
             playerTransform = player.transform;
         }
         else
         {
             Debug.Log("Player is seen");
         }
     }
 
     // Start is called before the first frame update
     void Start()
     {
         GetPlayerTransform();
     }
 
     // Update is called once per frame
     void Update()
     {
         var distance = Vector3.Distance(playerTransform.position, transform.position);
         
         if (distance <= attackDistance)
         {
             if (distance >= waitDistance)
             {
                 transform.position += transform.forward * attackSpeed * Time.deltaTime;
             }
         }
     }
}