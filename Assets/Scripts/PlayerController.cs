using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 dir;
    private double start_time;
    [SerializeField] private int speed;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        start_time = Time.time;
    }

    private void FixedUpdate()
    {
        if (Time.time > start_time + 10)
        {
            dir.z = speed;
            controller.Move(dir * Time.fixedDeltaTime);
        }
    }

}