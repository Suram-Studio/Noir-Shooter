using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandSFX : MonoBehaviour
{
    private AudioSource source;
	public AudioClip[] clips;

	private void Start()
	{
		source = GetComponent<AudioSource>();
		source.clip = clips[Random.Range(0, clips.Length)];
		source.Play();
	}
}
