using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static SoundManager instance;

    private void Awake()
    {
        // Check if an instance already exists
        if (instance == null)
        {
            // If not, set the current instance as the singleton instance
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If an instance already exists, destroy the duplicate instance
            Destroy(gameObject);
        }
    }

    // You can add other methods to control the audio playback as per your requirements
    public AudioSource src;
    public AudioClip sfx1, sfx2, sfx3;

    public void Sound1()
    {
        src.clip = sfx1;
        src.Play();
    }
    public void Sound2()
    {
        src.clip = sfx2;
        src.Play();
    }
    public void Sound3()
    {
        src.clip = sfx3;
        src.Play();
    }
}
