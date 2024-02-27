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
            var flyweight = FlyweightFactory.Spawn(flyweights[0]);
            flyweight.transform.position = transform.position;
            flyweight.transform.rotation = transform.rotation;
            
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            var flyweight = FlyweightFactory.Spawn(flyweights[1]);
            flyweight.transform.position = transform.position;
            flyweight.transform.rotation = transform.rotation;
            
        }


    }
}
