﻿using UnityEngine;

public class UnityCube : MonoBehaviour
{
  public Color Color
  {
		get {return gameObject.renderer.material.color;}
    set { gameObject.renderer.material.color = value; }
  }
  public Vector3 Position
  {
    get { return gameObject.transform.position; }
    set { gameObject.transform.position = value; }
    //set 
    //{
    //  Vector3 pos = gameObject.transform.position;
    //  gameObject.transform.position = new Vector3(value, pos.y, pos.z);
    //}
  }

  public static UnityCube Find()
  {
	return GameObject.Find("/Cube").GetComponent<UnityCube>();
  }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               