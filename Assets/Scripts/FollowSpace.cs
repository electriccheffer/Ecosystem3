using UnityEngine;
using System; 
using System.Collections.Generic; 

public class FollowSpace : MonoBehaviour
{
    GameObject target; 
    List<GameObject> flock;
    [SerializeField] GameObject boid;    
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    	 
    }

    // Update is called once per frame
    void Update()
    {
			        
    }

    void OnTriggerEnter(Collider collision){

	if(collision.gameObject.name.StartsWith("FlockingSphere")){

		this.target = collision.gameObject; 
		
	}
	if(collision.gameObject.name.StartsWith("FollowerSphere")){

		this.flock.Add(collision.gameObject);
	}
	

    }
}
