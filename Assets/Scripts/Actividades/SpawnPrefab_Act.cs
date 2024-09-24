using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab_Act : MonoBehaviour
{
    public GameObject circlePrefab;
    public Transform spawnPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            /*GameObject newBullet = Instantiate(circlePrefabPrefab);
            newBullet.transform.position = spawnPoint.position;
            newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * 100.0f);*/
        }
    }

    void Start()
    {
        EventManager.m_Instance.AddListener<SpawnItem_Event>(SpawnPrefabListener);
    }

    public void SpawnPrefabListener(SpawnItem_Event _event){
        
     }
}

