using UnityEngine;

public class Particle : MonoBehaviour
{
    private Vector3 velocity; 
    private Vector3 accelleration;
    private float lifespan; 
    [SerializeField] private float maxLifespan; 
    private MeshRenderer meshRenderer; 
    private Vector3 wind; 
	
     // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
 	this.velocity = Vector3.zero; 
	this.accelleration = Vector3.zero; 
	this.maxLifespan = 255.0f; 
	this.lifespan = this.maxLifespan; 
    	this.meshRenderer = this.GetComponent<MeshRenderer>(); 
    	this.wind = new Vector3(Random.Range(-0.01f,0.01f),Random.Range(-0.01f,0.01f),Random.Range(-0.01f,0.01f));
    }

    // Update is called once per frame
    void Update()
    {
	ApplyForce(this.wind);	
 	this.velocity += this.accelleration; 
	this.transform.position += this.velocity; 
	this.accelleration = Vector3.zero; 
	this.lifespan -= .5f; 
	Color particlesColor = this.meshRenderer.material.color;
	particlesColor.a = this.lifespan/this.maxLifespan; 
	this.meshRenderer.material.color = particlesColor; 
	if(!isAlive() && this != null){
	
		Destroy(this.gameObject); 
	} 
    }
    

    public bool isAlive(){
		
	return (this.lifespan > 0); 

    }

    private void ApplyForce(Vector3 force){
	
	this.accelleration += force; 		

    }
}
