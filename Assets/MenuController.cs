using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject[] marker;
    public GameObject Menu;
    public GameObject BackMenu;
    public string GameObjectName;

    public void ChooseObject(GameObject GO)
    {
        for (int i = 0; i < marker.Length; i++)
        {
            marker[i].SetActive(false);
        }

        GO.SetActive(true);
        GameObjectName = GO.name;
        Menu.SetActive(false);
    }

    public void exit()
    {
        Application.Quit(); 
    }
}
