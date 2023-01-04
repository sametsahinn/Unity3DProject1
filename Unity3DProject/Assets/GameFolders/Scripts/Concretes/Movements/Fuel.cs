using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    [SerializeField] float maxFuel = 100f;
    [SerializeField] float currentFuel;
    [SerializeField] ParticleSystem partical;

    public bool IsEmpty => currentFuel < 1f;

    public float CurrentFuel => currentFuel / maxFuel;

    private void Awake()
    {
        currentFuel = maxFuel;
    }

    public void FuelIncrease(float increase)
    {
        currentFuel += increase;
        currentFuel = Mathf.Min(currentFuel, maxFuel);

        if(partical.isPlaying)
        {
            partical.Stop();
        }
        SoundManager.Instance.StopSound(0);

    }

    public void FuelDecrease(float decrease)
    {
        currentFuel -= decrease;
        currentFuel = Mathf.Max(currentFuel, 0f);

        if (partical.isStopped)
        {
            partical.Play();
        }
        SoundManager.Instance.PlaySound(0);
    }
}
