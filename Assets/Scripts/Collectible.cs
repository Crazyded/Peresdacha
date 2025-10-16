using System;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public static event Action OnCollected;
    public static int total;
    public AudioClip collectSound;
    void Awake() => total++;
    void Update()
    {
        transform.localRotation  = Quaternion.Euler(0f, Time.time*100f, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            OnCollected?.Invoke();
            Destroy(gameObject);
        }
    }
}
