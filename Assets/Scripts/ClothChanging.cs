﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothChanging : MonoBehaviour
{
    private CalculateInventory CalculateInventory;

    private GameObject InventoryController;
    //this dictionary is the player inventory

    //a list that stores UI location
    private Sprite currentSprite;
    private Button selfButton;
    public SpriteRenderer workCloth;

    public SpriteRenderer whiteShirt;
    public SpriteRenderer blackPants;
    
    
   

    // Start is called before the first frame update
    void Start()
    {
        InventoryController = GameObject.Find("---InventoryController");
        CalculateInventory = InventoryController.GetComponent<CalculateInventory>();

//        selfButton.onClick.AddListener(AddClothToInventory);

    }

    // Update is called once per frame
    void Update()
    {
        currentSprite = GetComponent<Button>().image.sprite;
        print("pressed " + currentSprite.name);

    }

    
    public void ChangeCloth()
    {
        //currentSprite = GetComponent<Button>().image.sprite;

        
        print("inMethodpressed " + this.gameObject.name);
        
        if(CalculateInventory.allCloth.ContainsKey(currentSprite.name))
        {
            print("contains");
            if(currentSprite.name.Contains("Top"))
            {
                CalculateInventory.topSR.sprite = CalculateInventory.allCloth[currentSprite.name];
                print("change top");
                
                whiteShirt.enabled = false;
                workCloth.enabled = false;



            }
            else if(currentSprite.name.Contains("Bottom"))
            {
                CalculateInventory.otherSR.sprite = CalculateInventory.allCloth[currentSprite.name];
                print("change bottom");
                
                workCloth.enabled = false;

                blackPants.enabled = false;
            }
            else if(currentSprite.name.Contains("shoe"))
            {
                CalculateInventory.shoeSR.sprite = CalculateInventory.allCloth[currentSprite.name];
                print("change shoe");
            }
            else if(currentSprite.name.Contains("Everything"))
            {
                CalculateInventory.everythingSR.sprite = CalculateInventory.allCloth[currentSprite.name];
                print("change everything");
                
                workCloth.enabled = false;

                blackPants.enabled = true;
                whiteShirt.enabled = true;
            }
        }    
    }

    public void ChangeWorkCloth()
    {
     
        workCloth.enabled = !workCloth.enabled;


        CalculateInventory.topSR.sprite = null;
        CalculateInventory.otherSR.sprite = null;
        CalculateInventory.everythingSR.sprite = null;
        
        blackPants.enabled = true;
        whiteShirt.enabled = true;
    }
    
}

