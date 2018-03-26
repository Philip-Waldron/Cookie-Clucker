using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
	public AudioClip[] sounds;
	AudioSource audioSource;

	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	void Update()
	{
		if (!audioSource.isPlaying)
		{
			audioSource.clip = sounds[Random.Range(0,2)];
			audioSource.Play();
		}
	}
}