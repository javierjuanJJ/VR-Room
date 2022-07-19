using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class hourClock : MonoBehaviour
{
    [SerializeField] private GameObject handHour, handMinute, handSecond;
    const float degreesPerHour = 30f, degreesPerMinute = 6f, degreesPerSecond = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;

        handHour.transform.localRotation = Quaternion.Euler (0f, (float) time.TotalHours * degreesPerHour, 0f);
        handMinute.transform.localRotation = Quaternion.Euler (0f, (float) time.TotalMinutes * degreesPerMinute, 0f);
        handSecond.transform.localRotation = Quaternion.Euler (0f, (float) time.TotalSeconds * degreesPerSecond, 0f);
        
    }
}
