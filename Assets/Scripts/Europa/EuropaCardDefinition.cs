using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EuropaCardDefinition : MonoBehaviour
{
	public string animalSprite;
	private string id;
	public int status;
	public AudioSource cardSound;

    public void ClickCardSound(){
        cardSound.Play(0);
    }
    // Start is called before the first frame update
    void Start()
    {
		status = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void SetAnimalSprite(string a){
		animalSprite = a;
	}
	public void ShowAnimal(){
		if(status == 1 || status == 2)	return;
		int cS = EuropaCardsController.cantSelected;
		if(cS >= 2)	return;
		status = 1;
		if(cS == 0){
			EuropaCardsController.XSelected = gameObject;
		}else if(cS == 1){
			EuropaCardsController.YSelected = gameObject;
		}
		GetComponent<Image>().sprite = Resources.Load <Sprite>(animalSprite);
		ClickCardSound();
		EuropaCardsController.cantSelected++;
	}
	
	public void HideAnimal(){
		GetComponent<Image>().sprite = EuropaCardsController.spriteReverse;
		status = 0;
	}
	
	public void SaveAnimal(){
		status = 2;
	}
	
	public void SetId(string idT){
		id = idT;
	}
	public string GetId(){
		return id;
	}
}
