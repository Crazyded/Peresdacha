using Unity.VisualScripting;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    public CollectibleCount neededtoleave;
    public Collectible lefttocollect;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
          
            print("Trigger Entered");
            Application.Quit();
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
