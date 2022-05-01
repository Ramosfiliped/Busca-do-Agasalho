using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoatRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // dentro do update
        // float antigoX = transform.rotation.x;
        // float antigoY = transform.rotation.y;
        // float antigoZ = transform.rotation.z;

        // Quaternion novaRotacao = new Quaternion();
        // novaRotacao.Set(antigoX + 10, antigoY, antigoZ + 10, 1);
        // transform.rotation = Quaternion.Lerp (transform.rotation, novaRotacao, Time.deltaTime*5);

        // dentro do update
        transform.Rotate (0, 50*Time.deltaTime, 0); //rotates 50 degrees per second around z axis
    }
}
