using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using JetBrains.Annotations;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject myPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 0f, 1.5f);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnPipes()
    {
        float randNumb = Random.Range(2.5f, 5.5f);
        gameObject.transform.position = new Vector3(20, randNumb, 0);
        Instantiate(myPrefab, gameObject.transform.position, Quaternion.identity);
    }
}
