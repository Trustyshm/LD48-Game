using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycardSpawner : MonoBehaviour
{

    public GameObject keycardB1;
    public List<Transform> keycardSpawnPoints = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        int selectedSpot = Random.Range(1, keycardSpawnPoints.Count + 1);
        Instantiate(keycardB1, keycardSpawnPoints[selectedSpot - 1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
