using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    float upperBorder;
    [SerializeField]
    float lowerBorder;
    [SerializeField]
    float leftBorder;
    [SerializeField]
    float rightBorder;
    [SerializeField]
    GameObject moneyPrefab;
    [SerializeField]
    GameObject barrierPrefab;
    [SerializeField]
    float spawnCooldown;
    [SerializeField]
    float objectsSpeed;
    float waitTime;
    float waitTimeForMoney;
    bool oneTime;

    private void Update()
    {
        if ( waitTime< Time.time)
        {
            oneTime = false;
            waitTimeForMoney = Time.time + spawnCooldown / 2;
            waitTime = Time.time + spawnCooldown;
            GameObject newBarrier = Instantiate(barrierPrefab, new Vector3(leftBorder, Random.Range(lowerBorder, upperBorder), 0), barrierPrefab.transform.rotation);
            StartCoroutine(tranlateObject(newBarrier));
        }
        if(waitTimeForMoney< Time.time && oneTime == false)
        {
            oneTime = true;
            GameObject newMoney = Instantiate(moneyPrefab, new Vector3(leftBorder, Random.Range(lowerBorder, upperBorder), 0), barrierPrefab.transform.rotation);
            StartCoroutine(tranlateObject(newMoney));
        }
    }
    IEnumerator tranlateObject(GameObject go)
    {
        while (go != null)
        {
            go.transform.Translate(Vector2.right * objectsSpeed * Time.deltaTime);
            if (go.transform.position.x > rightBorder)
            {
                Destroy(go.gameObject);
                yield break;
            }
            yield return null;
        }
            
    }
}
