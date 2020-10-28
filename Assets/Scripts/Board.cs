using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public int width;
    public int height;
    private Tiles[,] tiles;
    public GameObject tilePrefab;
    public float xOffset = 0.752f;
    public float yOffset = 0.864f;
    public GameObject[] hexagons;
    public GameObject[,] allHex;
    //GameObject triple;


    void Start()
    {
        tiles = new Tiles[width, height];
        allHex = new GameObject[width, height];
        SetUp(); 
    }

    void SetUp()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                float yPos = j;
                if(i%2 == 1)
                {
                    yPos += yOffset;
                }

                //GameObject tileChild = Instantiate(tilePrefab, new Vector2(i * xOffset, yPos), Quaternion.identity) as GameObject;
                //tileChild.transform.parent = this.transform;
                //tileChild.name = "(" + i + "," + j + ")";
                int hexToUse = Random.Range(0, hexagons.Length);
                GameObject hex = Instantiate(hexagons[hexToUse], new Vector2(i * xOffset, yPos), Quaternion.identity);
                hex.transform.parent = this.transform;
                hex.name = "(" + i * xOffset + "," + yPos + ")";
                //allHex[i, j] = hex;
            }
            
        }
    }

    private void OnMouseDown()
    {
        //Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //triple.transform.parent = this.transform;
    }
}
