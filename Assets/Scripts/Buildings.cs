using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Buildings 
{

    //public int houseCost = 5;
    //public int statueCost = 5;
    //public int fieldCost = 5;
    //public int storeCost = 10;
    //public int shrineCost = 15;
    //public int hospitalCost = 30;


    public static int GetCost(BuildingType buildingType)
    {
        switch (buildingType)
        {
            default:
            case BuildingType.Empty: return 0;
            case BuildingType.House: return 5;
            case BuildingType.Statue: return 7;
            case BuildingType.Field: return 5;
            case BuildingType.Store: return 10;
            case BuildingType.Shrine: return 15;
            case BuildingType.Hospital: return 20;


        }
    }
    //public static Sprite GetSprite(BuildingType buildingType)
    //{
    //    switch (buildingType)
    //    {
    //        default:
    //        case BuildingType.Empty: return BuildingSprites.emptySprite;
    //        case BuildingType.House: return BuildingSprites.houseSprite;
    //        case BuildingType.Statue: return BuildingSprites.statueSprite;
    //        case BuildingType.Field: return BuildingSprites.fieldSprite;
    //        case BuildingType.Store: return BuildingSprites.storeSprite;
    //        case BuildingType.Shrine: return BuildingSprites.shrineSprite;
    //        case BuildingType.Hospital: return BuildingSprites.hospitalSprite;


    //    }
    //}
}


public enum BuildingType
{
    Empty,
    House,
    Statue,
    Field,
    Store,
    Shrine,
    Hospital

}
