using UnityEngine;
using System.Collections;

public class ActivateGameObjectTimerNoChildren : MonoBehaviour {

	
	public GameObject gameObject;
	
	public float  time = 1f;
	
	void Start() {
		StartCoroutine(ActivateRoutine());
	}
	public IEnumerator ActivateRoutine() {
		yield return new WaitForSeconds(time);    // Ajustar los segundos 

		gameObject.SetActive(true);
	}
}