using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyweight : MonoBehaviour
{
    public FlyweightSettings settings;    //Intrinsic State

    private void OnEnable()
    {
        StartCoroutine(DespawnAfterDelay(settings.despawnDelay));
    }

    private void Update()
    {
        transform.Translate(Vector3.right * (settings.speed * Time.deltaTime));

    }

    IEnumerator DespawnAfterDelay(float delay)
    {
        yield return Helpers.GetWaitForSeconds(delay);
        FlyweightFactory.ReturnToPool(this);
    }
}
