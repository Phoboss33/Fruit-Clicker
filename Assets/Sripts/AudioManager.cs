using UnityEngine;

public class AudioManager : MonoBehaviour {
    public static AudioManager Instance { get; private set; }
    [SerializeField] private AudioSource audioSource;

    private void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(gameObject); 
        }
        else {
            Instance = this; 
            DontDestroyOnLoad(gameObject); 
        }
    }

    private void Start() {

    }

    public void PlaySound(AudioClip clip) {
        audioSource.PlayOneShot(clip);
    }
}
