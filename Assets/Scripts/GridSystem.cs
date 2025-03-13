using UnityEngine;

public class GridSystem
{
	private int width; 
	private int height; 
	private float cellSize; 
	private Vector3 origin; 
	private GridObject[,] gridObjectArray; 
	

	public GridSystem(int width, int height,float cellSize,Vector3 origin){
	
		this.width = width; 
		this.height = height; 
		this.cellSize = cellSize; 
		this.origin = origin; 
		
		this.gridObjectArray = new GridObject[width,height]; 
		
		for(int x = 0;  x < this.width; x++){
			for(int z = 0 ; z < this.height ; z++){
				
				GridPosition gridPosition = new GridPosition(x,z);
				gridObjectArray[x,z] = new GridObject(this,gridPosition);
	
			}
		}	

	}


	public void drawDebugLines(){
		for(int x = 0 ; x < this.width ; x++){
			
			for(int z = 0 ; z < this.height  ; z++){
			
					
	
			}
		
		}
	}

	
	public Vector3 GetWorldPosition(GridPosition gridPosition){

		return new Vector3(gridPosition.x,0,gridPosition.z) * cellSize + origin; 	
	
	}


	public Vector3 GetWorldPosition(int x, int z){
		
		return GetWorldPosition(GetGridPosition(x,z)); 
		
	}
	

	public GridPosition GetGridPosition(int x, int z){
			
		return gridObjectArray[x,z].getGridPosition(); 
		
	}


	
}
