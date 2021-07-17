using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip block;
    public AudioClip border;
    public AudioClip loseBorder;
    public static AudioManager Instance;
    

    private void Awake()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void AudioBlock()
    {
        audioSource.PlayOneShot(block);
    }
    public void AudioBorder()
    {
        audioSource.PlayOneShot(border);
    }
    public void AudioLoseBorder()
    {
        audioSource.PlayOneShot(loseBorder);
    }

}
