using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;


public class Tile : MonoBehaviour
{
    [SerializeField] private Stats _stats;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Sprite _baseVersion;
    [SerializeField] private Sprite _lightVersion;

    [SerializeField] private Sprite _houseVersion;
    [SerializeField] private Sprite _fieldVersion;
    [SerializeField] private Sprite _statueVersion;
    [SerializeField] private Sprite _storeVersion;
    [SerializeField] private Sprite _shrineVersion;
    [SerializeField] private Sprite _hospitalVersion;

    public int _xPos;
    public  int _yPos;
    private BuildingType buildingType;
   


    void OnMouseEnter()
    {
        if(buildingType == BuildingType.Empty)
        {
            transform.GetComponent<SpriteRenderer>().sprite = _lightVersion;
        }
        
        //Debug.Log("ON TILE");
        //_renderer.sprite = _lightVersion;
    }

    void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().sprite = _baseVersion;
        //Debug.Log("NOT ON TILE");
        //_renderer.sprite = _baseVersion;
    }

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //transform.GetComponent<SpriteRenderer>().sprite = Buildings.GetSprite(_stats.buildingToPlace);
            //_baseVersion = Buildings.GetSprite(_stats.buildingToPlace);
            Debug.Log(_stats.buildingToPlace);
            switch (_stats.buildingToPlace)
            {
                default:
                case BuildingType.Empty: 
                    //transform.GetComponent<SpriteRenderer>().sprite = _baseVersion;
                    //_baseVersion = _baseVersion;
                    //buildingType = BuildingType.Empty;
                    break;
                case BuildingType.House:
                    transform.GetComponent<SpriteRenderer>().sprite = _houseVersion;
                    _baseVersion = _houseVersion;
                    buildingType = BuildingType.House;
                    break;
                case BuildingType.Statue:
                    transform.GetComponent<SpriteRenderer>().sprite = _statueVersion;
                    _baseVersion = _statueVersion;
                    buildingType = BuildingType.Statue;
                    break;
                case BuildingType.Field:
                    transform.GetComponent<SpriteRenderer>().sprite = _fieldVersion;
                    _baseVersion = _fieldVersion;
                    buildingType = BuildingType.Field;
                    break;
                case BuildingType.Store:
                    transform.GetComponent<SpriteRenderer>().sprite = _storeVersion;
                    _baseVersion = _storeVersion;
                    buildingType = BuildingType.Store;
                    break;
                case BuildingType.Shrine:
                    transform.GetComponent<SpriteRenderer>().sprite = _shrineVersion;
                    _baseVersion = _shrineVersion;
                    buildingType = BuildingType.Shrine;
                    break;
                case BuildingType.Hospital:
                    transform.GetComponent<SpriteRenderer>().sprite = _hospitalVersion;
                    _baseVersion = _hospitalVersion;
                    buildingType = BuildingType.Hospital;
                    break;
            }
            _stats.buildingToPlace = BuildingType.Empty;
        }

    }
}


