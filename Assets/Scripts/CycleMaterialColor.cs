using UnityEngine;
using System.Collections;

public class CycleMaterialColor : MonoBehaviour
{
	public string colorPropertyName = "_Color";
	public float speed = 0.1f;
	public float hue = 0.0f;
	public float saturation = 1.0f;
	public float brightness = 1.0f;
	
	// Use this for initialization
	void Start () 
	{
		StartCoroutine ("CycleColors");
	}

	void Update()
	{
		hue += speed*Time.deltaTime;
		
		while(hue > 1.0f)
		{
			hue -= 1.0f;
		}
		
		while(hue <0.0f)
		{
			hue += 1.0f;
		}

		renderer.material.SetColor (colorPropertyName,new HSBColor (hue, saturation, brightness).ToColor ());
	}
}