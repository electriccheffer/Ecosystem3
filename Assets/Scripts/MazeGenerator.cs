using UnityEngine;

public class MazeGenerator : MonoBehaviour
{
    
    private MazeSystem maze; 
    [SerializeField] private int numberOfIterations; 
    private int totalIterations; 
	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
	this.maze = new MazeSystem(100,100,1.0f,new Vector3(0f,0f,0f));	        
	this.totalIterations = 0; 

	for(;this.totalIterations < this.numberOfIterations;this.totalIterations++){
		
		if(this.totalIterations  < this.numberOfIterations ){
		
			this.totalIterations++; 
			this.maze.applyRules(); 
					
		}

	}

	// Create the game objects
		

    }

    // Update is called once per frame
    void Update()
    {
    	
    }
}
