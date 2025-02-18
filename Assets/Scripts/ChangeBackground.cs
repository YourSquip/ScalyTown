using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackground : MonoBehaviour
{
    [SerializeField] private Sprite _bg1;
    [SerializeField] private Sprite _bg2;
  
    public float changeTime = 1f;
    public float currentTime = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime <=2f)
        {
            transform.GetComponent<SpriteRenderer>().sprite = _bg2;
            //currentTime = 0f;
        }
        if(currentTime > 2f && currentTime <= 4f)
        {
            transform.GetComponent<SpriteRenderer>().sprite = _bg1;
        }
        if (currentTime > 4f)
        {
            currentTime = 0f;
        }

    }
}
