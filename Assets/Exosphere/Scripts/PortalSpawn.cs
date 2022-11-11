using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpawn : MonoBehaviour
{
    public Transform[] portalSpawnPoints;
    private int spawnedPortals;
    public GameObject portal;
    [SerializeField] int portalAmount = 1;

    void Start()
    {
        SpawnPortal();
    }

    public void SpawnPortal()
    {
        List<Transform> portals = new();
        while (spawnedPortals != portalAmount)
        {
            foreach (var portalPoint in portalSpawnPoints)
            {
                int rnd = Random.Range(0, 5);
                Debug.Log(portalPoint.name + " got " + rnd);

                if (rnd == 4 && !portals.Contains(portalPoint)) 
                {
                    portals.Add(portalPoint);
                    Instantiate(portal, portalPoint);
                    Debug.Log(portalPoint.name + " Has been placed");
                    spawnedPortals++;
                }
                else if (rnd == 4 && portals.Contains(portalPoint))
                {
                    Debug.Log(portalPoint.name + " has already been placed");
                }
            }
        }
    }
}
