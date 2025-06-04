using UnityEngine;
using System.Collections;
//ESTE FADE NO SE DESACTIVA CUANDO SE TERMINA EL EFECTO

public class ReverseFadeScript2 : MonoBehaviour 
{
	public float fadeTime = 5;
	public Color fadeColor = Color.black;
	private bool fadeIn = false;
	private float tempTime;
	private float time = 0.0f;
	private bool fadeCompleted = false;
	
	private void Start()
	{
		fadeIn = true;
	}
	
	private void Update()
	{
		if (fadeIn && !fadeCompleted)
		{
			if (time < fadeTime)
				time += Time.deltaTime;
			tempTime = Mathf.InverseLerp(0.0f, fadeTime, time);
			
			if (tempTime >= 1.0f)
			{
				fadeCompleted = true;
				tempTime = 1.0f; // Set tempTime to 1.0 to keep it at maximum color
			}
		}
	}
	
	private void OnGUI()
	{
		if (fadeIn)
		{
			GUI.color = new Color(fadeColor.r, fadeColor.g, fadeColor.b, tempTime);
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Texture2D.whiteTexture);
		}
	}
}