using UnityEngine;

public class AudioManager : MonoBehaviour
{


    // AUDIO
    AudioSource audioSource;

    public AudioClip levelOneMusic;
    public AudioClip hitSound;



    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        if (levelOneMusic != null)
        {
            audioSource.clip = levelOneMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    public void PlaySound(string ID)
    {
        if (ID == "hitSound")
        {
            audioSource.PlayOneShot(hitSound);
        }
    }
}
