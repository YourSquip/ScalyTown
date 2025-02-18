using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class Grid : MonoBehaviour
{
    private int width = 6;
    private int height = 4;


    private Tile[,] tiles;

    private void Start()
    {
        tiles = new Tile[width, height];
       
    }


}
