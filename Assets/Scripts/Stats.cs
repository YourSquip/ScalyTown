using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour
{
    //stats
    public int money = 20;
    public int devotion = 5;
    public int food = 6;
    public int population = 0;
    public int total_population = 0;
    public int spawned = 0;

    public BuildingType buildingToPlace = BuildingType.Empty;

    //text display
    public TMP_Text moneyText;
    public TMP_Text devotionText;
    public TMP_Text foodText;
    public TMP_Text populationText;

    public TMP_Text bonusMoneyText;
    public TMP_Text bonusDevotionText;
    public TMP_Text bonusFoodText;
    public TMP_Text bonusPopulationText;

    public TMP_Text scoreText;

    //bonuses
    public int bonusMoney = 0;
    public int bonusDevotion = -1;
    public int bonusFood = 0;
    public int bonusPopulation = 0;

    public int prevBonusPopulation = 0;

    public float changeTime = 20f;
    public float currentTime = 0f;

    public void changeMoney(int num)
    {
        money = num;
    }
    public void changeDevotion(int num)
    {
        devotion = num;
    }
    public void changeFood(int num)
    {
        food = num;
    }
    public void changePopulation(int num)
    {
        population = num;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= changeTime ) {
            changeMoney(money + bonusMoney);
            changeDevotion(devotion + bonusDevotion);
            changeFood(food + bonusFood);
            changePopulation(population + bonusPopulation);
            currentTime = 0f;   
        }
        

        moneyText.SetText("" + money);
        devotionText.SetText("" + devotion);
        foodText.SetText("" + food);
        populationText.SetText("" + population);

        if(bonusMoney >= 0)
        {
            bonusMoneyText.SetText("+" + bonusMoney);
        }
        else
        {
            bonusMoneyText.SetText("" + bonusMoney);
        }
        if (bonusDevotion >= 0)
        {
            bonusDevotionText.SetText("+" + bonusDevotion);
        }
        else
        {
            bonusDevotionText.SetText("" + bonusDevotion);
        }
        if (bonusFood >= 0)
        {
            bonusFoodText.SetText("+" + bonusFood);
        }
        else
        {
            bonusFoodText.SetText("" + bonusFood);
        }
        if (bonusPopulation >= 0)
        {
            bonusPopulationText.SetText("+" + bonusPopulation);
        }
        else
        {
            bonusPopulationText.SetText("" + bonusPopulation);
        }

        scoreText.SetText(""+population);

        WinCheck();
        DevotionCheck();
        BornAbilityCheck();
        LooseCheck();
    }

    void WinCheck()
    {
        if(population >= 20)
        {
            Debug.Log("YOU WON");
            SceneManager.LoadScene("WinScene");
        }
    }
    void LooseCheck()
    {
        if (devotion <= 0)
        {
            Debug.Log("YOU LOST - cult have fallen");
            SceneManager.LoadScene("LostSceneDevotion");
        }
        if (food <= 0)
        {
            Debug.Log("YOU LOST - hunger");
            SceneManager.LoadScene("LostSceneFood");
        }
        if (money <= 0)
        {
            Debug.Log("YOU LOST - town is out of money");
            SceneManager.LoadScene("LostSceneGold");
        }
    }
    void BornAbilityCheck()
    {
        
        if (population >= 2 && food >= population && devotion >= population)
        {
            bonusPopulation = 1;
        }
        

    }
    void DevotionCheck()
    {
        if(devotion < population)
        {
            bonusPopulation = -1;
        }
        //if (devotion < population)
        //{
        //    bonusPopulation *= -1;
        //}
        //else if(devotion >= population && bonusPopulation < 0)
        //{
        //    bonusPopulation *= - 1;
        //}
    }
}

