using UnityEngine;

public class CollectibleCount : MonoBehaviour
{
    TMPro.TMP_Text text;
    int count;
    public AudioClip Alldonesound;

    void Start() => UpdateCount();
    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    void OnEnable() => Collectible.OnCollected += OnCollectibleCollected;
    void OnDisable() => Collectible.OnCollected -= OnCollectibleCollected;
    void OnCollectibleCollected()
    {
        count++;
        UpdateCount();
    }

    void UpdateCount()
    {
        text.text = $"{count} / {Collectible.total}";
        if (count == Collectible.total)
        {
            text.text = $"Supplies collected, leave the area";
            AudioSource.PlayClipAtPoint(Alldonesound, Vector3.zero);
        }
    }
}
