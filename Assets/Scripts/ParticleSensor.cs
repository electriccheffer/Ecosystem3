using UnityEngine;

public class ParticleSensor : MonoBehaviour
{

    [SerializeField] GameObject bug; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider prey){

	if(prey.gameObject.name.StartsWith("Particle")){
		
		Debug.Log("Collision! With sense sphere"); 
		this.bug.GetComponent<ChaseParticle>().Chase(prey.gameObject); 
	}
    }
}
