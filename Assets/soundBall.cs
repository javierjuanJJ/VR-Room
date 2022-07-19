using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Rigidbody))]
public class soundBall : MonoBehaviour
{
    [SerializeField]
    private AudioClip soundBallClip;

    private AudioSource audioSourceBall;
    
    [SerializeField]
    private GameObject floorRoom;

    private void Awake()
    {
        audioSourceBall = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals(floorRoom.name))
        {
            audioSourceBall.volume = GetComponent<Rigidbody>().velocity.magnitude;
            audioSourceBall.PlayOneShot(soundBallClip);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
