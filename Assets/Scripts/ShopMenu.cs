using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    [SerializeField] private Stats stats;
    public TMP_Text hints;

    public void BuyHouse()
    {
        if(stats.buildingToPlace == BuildingType.Empty)
        {
            if (stats.food < 2)
            {
                //Debug.Log("Not enough food");
                hints.SetText("Not enough food for this building");
            }
            else if (stats.money < Buildings.GetCost(BuildingType.House))
            {
                //Debug.Log("Not enough money");
                hints.SetText("Not enough money for this building");
            }
            else
            {
                stats.changeMoney(stats.money - Buildings.GetCost(BuildingType.House));
                stats.changeFood(stats.food - 2);
                stats.bonusMoney += 1;
                stats.population += 2;
                stats.buildingToPlace = BuildingType.House;
                //Debug.Log("Place it");
                hints.SetText("Place the building");

            }
        }
        else
        {
            hints.SetText("Place previos building first");
            //Debug.Log("Place previos building first");
        }
        
            
        
    }

    public void BuyStatue()
    {
        if (stats.buildingToPlace == BuildingType.Empty)
        {
            if (stats.population < 1)
            {
                hints.SetText("Not enough villagers for this building");
            }
            else if (stats.money < Buildings.GetCost(BuildingType.Statue))
            {
                hints.SetText("Not enough money for this building");
            }
            else
            {
                stats.changeMoney(stats.money - Buildings.GetCost(BuildingType.Statue));
                stats.changePopulation(stats.population - 1);
                stats.bonusDevotion += 2;
                //stats.bonusMoney += 1;
                stats.buildingToPlace = BuildingType.Statue;
                hints.SetText("Place the building");

            }
        }
        else
        {
            hints.SetText("Place previous building first");
        }
        


    }

    public void BuyField()
    {
        if (stats.buildingToPlace == BuildingType.Empty)
        {
            if (stats.population < 1)
            {
                hints.SetText("Not enough villagers for this building");
            }
            else if (stats.money < Buildings.GetCost(BuildingType.Field))
            {
                hints.SetText("Not enough money for this building");
            }
            else
            {
                stats.changeMoney(stats.money - Buildings.GetCost(BuildingType.Field));
                stats.changePopulation(stats.population - 1);
                stats.bonusFood += 2;
                stats.bonusMoney += 2;
                stats.buildingToPlace = BuildingType.Field;
                hints.SetText("Place the building");

            }
        }
        else
        {
            hints.SetText("Place previous building first");
        }
        


    }

    public void BuyStore()
    {
        if (stats.buildingToPlace == BuildingType.Empty)
        {
            if (stats.population < 3)
            {
                hints.SetText("Not enough villagers for this building");
            }
            else if (stats.money < Buildings.GetCost(BuildingType.Store))
            {
                hints.SetText("Not enough money for this building");
            }
            else
            {
                stats.changeMoney(stats.money - Buildings.GetCost(BuildingType.Store));
                stats.changePopulation(stats.population - 3);
                stats.bonusFood += 4;
                stats.bonusMoney += 5;
                stats.buildingToPlace = BuildingType.Store;
                hints.SetText("Place the building");

            }
        }
        else
        {
            hints.SetText("Place previous building first");
        }
        


    }
    public void BuyShrine()
    {
        if (stats.buildingToPlace == BuildingType.Empty)
        {
            if (stats.population < 2)
            {
                hints.SetText("Not enough villagers for this building");
            }
            else if (stats.money < Buildings.GetCost(BuildingType.Shrine))
            {
                hints.SetText("Not enough money for this building");
            }
            else
            {
                stats.changeMoney(stats.money - Buildings.GetCost(BuildingType.Shrine));
                stats.changePopulation(stats.population - 2);
                stats.bonusDevotion += 5;
                stats.bonusMoney += 2;
                stats.buildingToPlace = BuildingType.Shrine;
                hints.SetText("Place the building");

            }
        }
        else
        {
            hints.SetText("Place previous building first");
        }
        


    }

    public void BuyHospital()
    {
        if (stats.buildingToPlace == BuildingType.Empty)
        {
            if (stats.population < 3)
            {
                hints.SetText("Not enough villagers for this building");
            }
            else if (stats.money < Buildings.GetCost(BuildingType.Hospital))
            {
                hints.SetText("Not enough money for this building");
            }
            else
            {
                stats.changeMoney(stats.money - Buildings.GetCost(BuildingType.Hospital));
                stats.changePopulation(stats.population - 3);
                //stats.bonusDevotion += 5;
                stats.bonusMoney += 4;
                stats.population *= 2;
                stats.buildingToPlace = BuildingType.Hospital;
                hints.SetText("Place the building");

            }
        }
        else
        {
            hints.SetText("Place previous building first");
        }
        


    }
}
