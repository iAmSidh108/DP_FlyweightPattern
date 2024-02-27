using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField] Vector3 speed;

    void Update()
    {
        transform.position += speed * Time.deltaTime;
    }
}
