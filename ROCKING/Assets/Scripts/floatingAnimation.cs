using System;
using UnityEngine;

public class floatingAnimation : MonoBehaviour
{
    float originalY;
    public float floatStrenght = 1;
    public float animationSpeed = 1;

    void Start()
    {
        this.originalY = this.transform.position.y;
        Debug.Log(originalY);
    }

    // Update is called once per frame
    void Update()
    {
        // vector3 recebe (x, y, z). x,z permanecem os mesmo
        transform.position = new Vector3(transform.position.x,
            originalY + ((float)Math.Sin(Time.time * animationSpeed) * floatStrenght),
            transform.position.z);
    }
}
