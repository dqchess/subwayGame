﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllMachines : MonoBehaviour
{
    private WasherController WasherController;

    public GameObject currentBag;

    
    public GameObject returnNotice;
    public GameObject noticeParent;

    public bool alreadyNotice = false;

    public List<Sprite> openBags;
    public Dictionary<string, Sprite> openBagsDic = new Dictionary<string, Sprite>();
    
    //控制所有洗衣机的代码
    //只有这一份
    //all of alex's clothes
    public List<Sprite> AlexClothes;
    public List<Sprite> alexClothesTemp = new List<Sprite>();
    
    public List<Sprite> BellaClothes;
    public List<Sprite> bellaClothesTemp = new List<Sprite>();
    
    public List<Sprite> TutorialClothes;
    public List<Sprite> TutorialClothesTemp = new List<Sprite>();

   
    private bool isFirstOpen = true;

    //all the machines
    public List<GameObject> WashingMachines = new List<GameObject>();


    public int washTime;

    private bool isLoad;

    public enum MachineState {
        empty,
        full,
        washing,
        finished
    }

    public MachineState myMachineState;
    
    //all the buttons, aka clothes in the machine
    //length should be 5, which is the number of buttons on screen

//    public Button[] clothesInMachine;

    //length should also be 5, which is the number of buttons on screen
    private Sprite[] UIsprites;

    //all possible positions of buttons on the interface
//    public Vector3[] buttonPositions;



    // Start is called before the first frame update
    void Start()
    {
        //make a copy of the list of clothes
        for (int i = 0; i < AlexClothes.Count; i++)
        {
            alexClothesTemp.Add(AlexClothes[i]);
        }

        //make a copy of the list of clothes
        for (int i = 0; i < BellaClothes.Count; i++)
        {
            bellaClothesTemp.Add(BellaClothes[i]);
        }

        for (int i = 0; i < openBags.Count; i++)
        {
            openBagsDic.Add(openBags[i].name, openBags[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

//    public void GenerateCloth(string tagName)
//    {
//        
//        //randomly generate clothes when player opens the machine
//        if(isFirstOpen)
//        { 
//            for (int i = 0; i < WasherController.buttons.Length; i++)
//            {
//                if(tagName == "Alex")
//                {
//                    print("alexxxxxx");
//                    int randomIndex = Random.Range(0, alexClothesTemp.Count);
//                    print("random = " + randomIndex);
////                  clothesInMachine[i].image.sprite = AlexClothes[randomIndex];
//
////                    Button ClothInMachine =
////                        Instantiate(alexClothesTemp[randomIndex], buttonPositions[i], Quaternion.identity) as Button;
//
//                    Image buttonImage = WasherController.buttons[i].GetComponent<Image>();
//                    buttonImage.sprite = alexClothesTemp[randomIndex];
//                        
//                    alexClothesTemp.Remove(alexClothesTemp[randomIndex]);
//                    //as child of the folder
//                    //doesn't work for some reason I don't understand
//                    //ClothInMachine.transform.SetParent(MachineGroup.transform, false);
//                    //ClothInMachine.transform.SetParent(MachineGroup.transform, false);
//
//
//                }
//                else if (tagName == "Bella")
//                {
//                    int randomIndex = Random.Range(0, bellaClothesTemp.Count);
//                    print("random = " + randomIndex);
////                  clothesInMachine[i].image.sprite = AlexClothes[randomIndex];
//
////                    Button ClothInMachine =
////                        Instantiate(bellaClothesTemp[randomIndex], buttonPositions[i], Quaternion.identity) as Button;
//
//                    Image buttonImage = WasherController.buttons[i].GetComponent<Image>();
//                    buttonImage.sprite = alexClothesTemp[randomIndex];
//                    
//                    bellaClothesTemp.Remove(bellaClothesTemp[randomIndex]);
//                    //as child of the folder
//                    //doesn't work for some reason I don't understand
//
//                    //ClothInMachine.transform.SetParent(MachineGroup.transform, false);
//
//                }
//                
//               
//                //this will make scale a lot bigger than it should be
////              ClothInMachine.transform.parent = MachineGroup.transform;
//
//            
//
//            }
//
//            isFirstOpen = false;
//        }
//        
//    }

    private void GenerateClothByTag()
    {
        
    }
    
}
