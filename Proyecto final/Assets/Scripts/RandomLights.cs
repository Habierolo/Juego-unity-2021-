using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLights : MonoBehaviour
{
    public float minIntensity = 0.25f;
    public float maxIntensity = 0.5f;
 
    float random;
 
    void Start()
    {
        random = Random.Range(0.0f, 65535.0f);
    }
 
    void Update()
    {
        float noise = Mathf.PerlinNoise(random, Time.time);
        GetComponent<Light>().intensity = Mathf.Lerp(minIntensity, maxIntensity, noise);
    }
}
