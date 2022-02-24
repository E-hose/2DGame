using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    private Vector3 temPos;

    [SerializeField]
    private float minX, maxX;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // LateUpdate is being called after Update calculations, thus saving quality
    void LateUpdate()
    {
        if (player==null)
            return;

        temPos = transform.position;
        temPos.x = player.position.x;

        if (temPos.x < minX)
            temPos.x = minX;
        if (temPos.x > maxX)
            temPos.x = maxX;

        transform.position = temPos;
    }
}
