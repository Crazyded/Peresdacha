using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class DamageVignette : MonoBehaviour
{
    private Volume volume;
    private Vignette vignette;

    private void DamageTaken()
    {
        vignette.intensity.value = 0.5f;
        


    }
}
