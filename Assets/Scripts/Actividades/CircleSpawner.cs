using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public GameObject circlePrefab;
    public Transform spawnPoint;

    void Start(){
        EventManager.m_Instance.AddListener<SpawnItem_Event>(SpawnCircleListener);
    }

    private void SpawnCircleListener(SpawnItem_Event _event){
        Circle circleMonoBehaviour = null;
        PoolManager.Instance.SpawnObject<Circle>(out circleMonoBehaviour, circlePrefab, spawnPoint.position, spawnPoint.rotation, PoolManager.PoolType.GameObjects);
    }
}
