using UnityEngine;
using System.Collections.Generic; 

public class Emitter : MonoBehaviour
{
    [SerializeField] private Particle particlePrefab; 
    private Vector3 startPosition; 
    [SerializeField] private float makePollen; 
    private float totalTime; 
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        this.startPosition = this.transform.position; 
	this.totalTime = 0f; 
	this.makePollen = 1f; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
	this.totalTime += Time.deltaTime; 
	if(this.totalTime >= this.makePollen){

    		Instantiate(particlePrefab,startPosition,Quaternion.identity);
		this.makePollen += 1f; 
	}

	
    }
}
