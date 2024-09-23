using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Click : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private AudioClip _sfxClip;  // The sound clip to play
    [SerializeField] private int maxAudioSources = 5;  // Max number of overlapping sounds
    private List<AudioSource> _audioSources = new List<AudioSource>();  // List to hold AudioSources

    void Start()
    {
        // Initialize the list with multiple AudioSource components
        for (int i = 0; i < maxAudioSources; i++)
        {
            AudioSource newSource = gameObject.AddComponent<AudioSource>();
            newSource.clip = _sfxClip;
            _audioSources.Add(newSource);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        GameManager.Singleton.OnClick();

        // Play the sound using an available AudioSource
        foreach (AudioSource source in _audioSources)
        {
            if (!source.isPlaying)
            {
                source.Play();
                break;  // Play only on one available AudioSource
            }
        }
    }
}
