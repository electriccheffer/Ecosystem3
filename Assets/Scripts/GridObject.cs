using UnityEngine;

public class GridObject
{
	private GridSystem gridSystem; 

	private GridPosition gridPosition; 


	public GridObject(GridSystem gridSystem,GridPosition gridPosition){
		
		this.gridSystem = gridSystem; 
		this.gridPosition = gridPosition; 

	}	    

	public GridPosition getGridPosition(){
		
		return this.gridPosition; 

	}
	

	public override string ToString(){

		return this.gridPosition.ToString();
		
	}
}
