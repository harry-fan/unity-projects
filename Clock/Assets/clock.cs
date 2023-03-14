using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class clock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;
        hourTransform.localRotation = Quaternion.Euler(0f, time.Hour * perHour, 0f);
        minsTransform.localRotation = Quaternion.Euler(0f, time.Minute * perMin, 0f);
        secsTransform.localRotation = Quaternion.Euler(0f, time.Second * perSec, 0f);
    }

    const float perHour = 30f;
    const float perMin = 6f;
    const float perSec = 6f;

    public Transform hourTransform;
    public Transform minsTransform;
    public Transform secsTransform;
}
