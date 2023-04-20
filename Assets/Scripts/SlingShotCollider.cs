using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingShotCollider : MonoBehaviour
{
    LineRenderer platform;
    EdgeCollider2D edgeCollider;

    Vector3 points;
    Vector2[] points2 = new Vector2[35];

    private void Start()
    {
        edgeCollider = this.gameObject.AddComponent<EdgeCollider2D>();
        platform = this.gameObject.GetComponent<LineRenderer>();
        getNewPositions();

        edgeCollider.points = points2;
    }

    private void Update()
    {
        edgeCollider.offset= new Vector2(-transform.position.x, -transform.position.y);
        getNewPositions();
        
        edgeCollider.points = points2;
    }

    void getNewPositions()
    {
        for (int i = 0; i < platform.positionCount; i++)
        {
            points = platform.GetPosition(i);
            points2[i] = new Vector2(points.x, points.y);
        }
    }
}

