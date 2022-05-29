using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day_night_cicle : MonoBehaviour
{
    GameObject sun;

    // Start is called before the first frame update
    void Start()
    {
        sun = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        sun.transform.Rotate(0.02f, 0, 0, Space.World);
    }
}
