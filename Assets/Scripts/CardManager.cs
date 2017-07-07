using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CardManager : MonoBehaviour {

	public CardAsset cardAsset;
	[Header("Text References")]
	public Text NameText;
	public Text ManaCostText;
	public Text DescriptionText;
	public Text HealthText;
	public Text AttackText;
	[Header("Image References")]
	public Image CardGraphicImage;
	public Image CardUnitImage;
	
	void Awake() {
		if (cardAsset != null) {
			ReadCardFromAsset ();
		}
	}

	private bool canBePlayed = false;

	public void ReadCardFromAsset() {
		NameText.text = cardAsset.name;
		ManaCostText.text = cardAsset.ManaCost.ToString();
		DescriptionText.text = cardAsset.Description;
		CardGraphicImage.sprite = cardAsset.CardImage;
		CardUnitImage.sprite = cardAsset.UnitImage;

		if (cardAsset.MaxHealth != 0) {
			AttackText.text = cardAsset.Attack.ToString();
			HealthText.text = cardAsset.MaxHealth.ToString();	
		}
	}
}
