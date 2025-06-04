using UnityEngine;

public class FadeIn : MonoBehaviour
{
	public float fadeTime = 5;
	public Color fadeColor = Color.black;
	private bool fadeOut = false;
	private float tempTime;
	private float time = 0.0f;
	
	private void Start()
	{
		fadeOut = true;
	}
	
	private void Update()
	{
		if (fadeOut)
		{
			if (time < fadeTime)
				time += Time.deltaTime;
			tempTime = Mathf.InverseLerp(0.0f, fadeTime, time);
		}
		
		if (tempTime >= 1.0f)
			enabled = false;
	}
	
	private void OnGUI()
	{
		if (fadeOut)
		{
			GUI.color = new Color(fadeColor.r, fadeColor.g, fadeColor.b, 1 - tempTime);
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Texture2D.whiteTexture);
		}
	}
}