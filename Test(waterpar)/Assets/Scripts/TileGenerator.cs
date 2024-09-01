using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{

    public int XScale;
    public int YScale;

    public float staringPos;

    public GameObject tile;
    // Start is called before the first frame update
    void Start()
    {
        staringPos = ((XScale + 1) * -0.5f) + 1;
        Vector3 spawnPoint = new Vector3(staringPos, 0, staringPos);
        
        for (int i = 0; i < YScale; i++)
        {
            for (int p = 0; p < XScale; p++)
            {
                Instantiate(tile, spawnPoint, Quaternion.identity);
                spawnPoint.x += 1;
            }
            spawnPoint.z += 1;
            spawnPoint.x -= XScale;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
