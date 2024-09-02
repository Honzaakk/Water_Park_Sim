using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    bool IsOcuppied;

    public GameObject TileSpaceShow;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TurnOnGridMode()
    {
        if(TileSpaceShow.activeInHierarchy == true)
        {
            TileSpaceShow.SetActive(false);
        }
        else if (TileSpaceShow.activeInHierarchy == false)
        {
            TileSpaceShow.SetActive(true);
        }
        
    }
}
