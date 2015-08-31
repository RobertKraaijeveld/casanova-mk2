﻿using UnityEngine;
using System.Collections.Generic;

public class UnityPlanet : MonoBehaviour 
{
	public bool ClickedOver
	{
		get 
		{
			RaycastHit hit;
			var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit, 100))
			{
				if (this.gameObject.name.Equals(hit.collider.gameObject.name))
				{
					//Debug.Log(this.gameObject.name + " selected");
					return true;
				}
				else
					return false;
			}
			else {return false;}
		}
	}

  public int OwnershipNumber = 0;

  public int Ownership
  {
    get { return this.OwnershipNumber; }
    set { this.OwnershipNumber = value; }
  }
  public string Text
  {
    get { return gameObject.transform.GetChild(2).GetComponent<TextMesh>().text; }
    set { gameObject.transform.GetChild(2).GetComponent<TextMesh>().text = value; }
  }

  GameObject selection;
	public bool Selected
	{
    get { return selection.activeSelf; }
    set { selection.SetActive(value); }
  }

  public void Start()
  {
    selection = transform.FindChild("Selection").gameObject;
    Selected = false;
  }

	public static void Print(string message)
	{
		Debug.Log (message);
	}

	public Vector3 Position
	{
		get { return gameObject.transform.position; }
		set { gameObject.transform.position = value; }
	}

  public Color Color
  {
    get { return this.transform.renderer.material.color;}
    set { this.transform.renderer.material.color = value; }
  }
	
	public int Ships = 0;
	
	public static List<UnityPlanet> FindAllPlanets()
	{
		var objPlanets = GameObject.FindGameObjectsWithTag("Planet");
		var planets = new List<UnityPlanet>();
		foreach (var obj in objPlanets) 
		{
			var component = obj.GetComponent<UnityPlanet> ();
			planets.Add (component);
		}
		//Debug.Log (planets.Count.ToString());
		return planets;
	}
  

}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      