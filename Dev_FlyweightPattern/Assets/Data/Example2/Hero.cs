using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public List<FlyweightSettings> flyweights;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            var flyweight = flyweights[0].Create();
            flyweight.transform.position = transform.position;
            flyweight.transform.rotation = transform.rotation;
            flyweight.gameObject.SetActive(true);
            
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            var flyweight = flyweights[1].Create();
            flyweight.transform.position = transform.position;
            flyweight.transform.rotation = transform.rotation;
            flyweight.gameObject.SetActive(true);
        }


    }
}
