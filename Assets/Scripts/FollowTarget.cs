using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public Transform Bg1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            transform.position = player.position + offset;
        }
        Bg1.transform.position = new Vector2(transform.position.x * 1.0f, Bg1.transform.position.y);
    }
}
