using UnityEngine;
using UnityEngine.UI;

public class PlaySoundOnClick : MonoBehaviour
{
    [SerializeField] private AudioClip _sfxClip;
    private AudioSource _audioSource;

    void Start()
    {
 
        _audioSource = gameObject.AddComponent<AudioSource>();
        _audioSource.clip = _sfxClip;
        _audioSource.playOnAwake = false; 
    }

    public void PlaySound()
    {
        _audioSource.Play();
    }
}
