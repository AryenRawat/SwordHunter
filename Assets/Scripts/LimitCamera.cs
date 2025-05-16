using UnityEngine;
using System.Collections;

public class LimitCamera : MonoBehaviour
{
    public Transform background;
    private float camHalfWidth, camHalfHeight;
    private float bgMinX;
    private float bgMaxX;
    private float bgMinY;
    private float bgMaxY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer bground = background.GetComponent<SpriteRenderer>();
        Bounds bgbounds = bground.bounds;
        bgMinX = bgbounds.min.x;
        bgMaxX = bgbounds.max.x;
        bgMinY=bgbounds.min.y;
        bgMaxY = bgbounds.max.y;
        Camera camera = Camera.main;
        camHalfHeight = camera.orthographicSize;
        camHalfWidth = camera.aspect*camHalfHeight;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 cameraPos= Camera.main.transform.position;

        cameraPos.x=Mathf.Clamp(cameraPos.x,bgMinX+camHalfWidth,bgMaxX-camHalfWidth);
        cameraPos.y=Mathf.Clamp(cameraPos.y,bgMinY+camHalfHeight,bgMaxY-camHalfHeight);
        Camera.main.transform.position=cameraPos;
        
        
    }
}
