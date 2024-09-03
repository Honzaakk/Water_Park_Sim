using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    bool GridModeOn = false;

    public GameObject SelectedBuilding;
    public GameObject LastSelectedBuilding;
    
    public GameObject lastTile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            GridModeOn = GridModeOn == true ? false : true;
            if (LastSelectedBuilding != null)
            {
                Destroy(LastSelectedBuilding);
            }
            ActivateGridMode();
        }
        Raycast();
        if (GridModeOn && LastSelectedBuilding != null && Input.GetMouseButton(0))
        {
            Destroy(LastSelectedBuilding);
            Instantiate(LastSelectedBuilding.GetComponent<ShadowBuilding>().Building, new Vector3(lastTile.transform.position.x, lastTile.transform.position.y + 1.5f, lastTile.transform.position.z), Quaternion.identity);
            lastTile.GetComponent<Tile>().IsOcuppied = true;

        }

    }

    void Raycast()
    {
        if (GridModeOn == true)
        {
            Cursor.visible = true;
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(mouseRay, out RaycastHit hitObject) && lastTile != hitObject.collider.gameObject)
            {
                if (hitObject.collider.tag == "Tile" )
                {

                    lastTile = hitObject.collider.gameObject;
                    Debug.Log(SelectedBuilding.transform.position.y * 0.5f);
                    Instantiate(SelectedBuilding, new Vector3(lastTile.transform.position.x, lastTile.transform.position.y + (SelectedBuilding.transform.localScale.y * 0.5f), lastTile.transform.position.z), Quaternion.identity);
                    if (LastSelectedBuilding != null)
                    {
                        Destroy(LastSelectedBuilding);
                    }
                    LastSelectedBuilding = FindObjectOfType<ShadowBuilding>().gameObject;
                }
            }
        }
    }

    void ActivateGridMode()
    {
        foreach (Tile tile in FindObjectsOfType<Tile>())
        {
            tile.TurnOnGridMode();
        }
    }
}
