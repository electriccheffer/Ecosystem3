using UnityEngine;
using System; 
using System.Collections.Generic; 

public class PersonalSpace : MonoBehaviour
{

    List<GameObject> tooClose; 
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
	
	this.tooClose.Add(collision.gameObject); 
		
    }
}
