using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Cube3D : MonoBehaviour
{
    public PathCreator myPath;
    float updatePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        updatePos += 5 * Time.deltaTime;
        transform.position = myPath.path.GetPointAtDistance(updatePos);
        transform.rotation = myPath.path.GetRotationAtDistance(updatePos);
    }
}
