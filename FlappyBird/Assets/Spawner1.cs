using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using JetBrains.Annotations;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public GameObject myPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 0f, Random.Range(1f, 2f));
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnPipes()
    {
        float randNumb = Random.Range(-10f, -9f);
        gameObject.transform.position = new Vector3(30, randNumb, 10);
        Instantiate(myPrefab, gameObject.transform.position, Quaternion.identity);
    }
}
