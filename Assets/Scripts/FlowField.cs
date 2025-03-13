using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
	
	private GridSystem gridSystem; 

	public void Awake(){
		
		gridSystem = new GridSystem(100,100,1,this.transform.position);
		
	}

    	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{	
		
	}

    	// Update is called once per frame
	void Update()
	{
        
		gridSystem.SetOrigin(this.transform.position);
		gridSystem.drawDebugLines(); 
	}
}
