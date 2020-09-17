using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayer : MonoBehaviour
{
    private Image imageIndecatorMood;
    private GameObject cat;
    private float mood;
    private Text descriptionCat;

    private void Start()
    {
        imageIndecatorMood = gameObject.transform.GetChild(0).gameObject.transform.GetChild(4).gameObject.GetComponent<Image>();
        cat = GameObject.FindGameObjectWithTag("Player");
        descriptionCat = GameObject.FindGameObjectWithTag("UIText").gameObject.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>();
        mood = cat.GetComponent<CatController>().GetMood();
        UpdateText();
    }

    private void Update()
    {
        mood = cat.GetComponent<CatController>().GetMood();

        if (mood == 0)
        {
            imageIndecatorMood.color = Color.red;
        }
        else if(mood == 1)
        {
            imageIndecatorMood.color = Color.yellow;
        }
        else if(mood == 2)
        {
            imageIndecatorMood.color = Color.green;
        }
    }

    public void UpdateText()
    {
        descriptionCat.text = cat.GetComponent<CatController>().GetText();
    }
}
