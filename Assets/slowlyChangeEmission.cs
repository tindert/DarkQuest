using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyButtons;

public class slowlyChangeEmission : MonoBehaviour
{
	public float targetIntensity = 1f;
	public float changeDuration = 2f;

	[SerializeField]
	private Material material;
	private float initialIntensity;
	private float timer;

	[Button]
	public void BeginChange()
	{
		material = GetComponent<Renderer>().material;
		initialIntensity = material.GetFloat("_EmissionIntensity");
		timer = 0f;
		StartCoroutine(ChangeEmissionIntensity());
	}

	private IEnumerator ChangeEmissionIntensity()
	{
		while (timer < changeDuration)
		{
			timer += Time.deltaTime;
			float t = timer / changeDuration;
			float intensity = Mathf.Lerp(initialIntensity, targetIntensity, t);
			material.SetFloat("_EmissionIntensity", intensity);
			yield return null;
		}
	}
}
