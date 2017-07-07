using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMangager : MonoBehaviour {


    //I took most of this from the Card/Creature Manager.

    // Player should only have health and cannot attack. 
    public CardAsset cardAsset;
    [Header("Text References")]
    public Text NameText;
    public Text DescriptionText;
    public Text HealthText;
    [Header("Image References")]
    public Image CardGraphicImage;
    public Image CardUnitImage;


    // Change starting hp here 
    public int startHealth = 15; 


    // Sets the starting HP
    public void setHealth()
    {
        HealthText.text = startHealth.ToString();
    }

    void Awake()
    {
        if (cardAsset != null)
        {
            ReadCardFromAsset();
        }
    }


    // Is static
    private bool canBePlayed = false;

    public void ReadCardFromAsset()
    {
        NameText.text = cardAsset.name;
        DescriptionText.text = cardAsset.Description;
        CardGraphicImage.sprite = cardAsset.CardImage;
        CardUnitImage.sprite = cardAsset.UnitImage;

        if (cardAsset.MaxHealth != 0)
        {
            HealthText.text = cardAsset.MaxHealth.ToString();
        }
    }

    //Player card should only take damage, but only if there are no other cards on field?
    public void TakeDamage(int amount, int healthAfter)
    {
        if (amount > 0)
        {
            HealthText.text = healthAfter.ToString();
        }
    }

}
