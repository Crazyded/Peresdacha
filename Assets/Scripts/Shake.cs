using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class Shake : MonoBehaviour
{
    [SerializeField] CinemachineImpulseSource screenShake;
    [SerializeField] float powerAmount;

    public void ScreenShake()
    {
        screenShake.GenerateImpulse(powerAmount);
    }
}
