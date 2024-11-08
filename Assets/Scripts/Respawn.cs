using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform playerPrefab;       
    public Transform spawnPoint;         
    public FollowTarget followTarget;

    public void RespawnPlayer()
    {
       
        if (followTarget.player != null)
        {
            Destroy(followTarget.player.gameObject);
        }

        
        Transform newPlayer = Instantiate(playerPrefab, spawnPoint.position, Quaternion.identity);

        
        followTarget.player = newPlayer;
    }
}

