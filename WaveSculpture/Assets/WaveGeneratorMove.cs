using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveGeneratorMove : MonoBehaviour
{
    public float magnitude;
    public float frequency;
    private Vector3 initialPosition;
    
    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        transform.position = initialPosition + Vector3.forward * magnitude* Mathf.Sin(frequency*Time.time);
    }
}
