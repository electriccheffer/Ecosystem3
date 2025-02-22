using UnityEngine;

public class ChaseParticle : MonoBehaviour
{
	
    GameObject prey; 
    [SerializeField] private float accelleration; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

	if(this.prey != null){

		// Look at particle 
		this.transform.LookAt(this.prey.transform);
		Vector3 towardsPrey = (prey.transform.position - this.transform.position).normalized; 
		this.transform.position += accelleration * towardsPrey;			
					
	}
	 
    }
	
    public void Chase(GameObject prey){
		
	this.prey = prey; 

    }
}
