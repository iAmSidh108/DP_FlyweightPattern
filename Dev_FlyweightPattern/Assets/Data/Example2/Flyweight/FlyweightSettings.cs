using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Flyweight/ Flyweight Setting")]
public class FlyweightSettings : ScriptableObject
{
    public FlyweightType type;
    public GameObject prefab;
    public float despawnDelay = 5f;
    public float speed = 10f;

    public Flyweight Create()
    {
        var go=Instantiate(prefab);
        go.SetActive(false);
        go.name = prefab.name;

        var flyweight = go.AddComponent<Flyweight>();
        flyweight.settings = this;

        return flyweight;
    }

    
}
