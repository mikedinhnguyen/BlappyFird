using UnityEngine;

public class MusicClass : MonoBehaviour
{
    private AudioSource song;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        song = GetComponent<AudioSource>();
    }
}
