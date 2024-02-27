using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public List<GameObject> flyweights;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            var flyweight = Instantiate( flyweights[0].gameObject, transform.position, Quaternion.identity);
            
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            var flyweight = Instantiate(flyweights[1].gameObject);
        }


    }
}
