using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public string playerName;
    public GameObject inputField; //where you will be typing the name

    //store the entered name
    public void StoreName()
    {
        playerName = inputField.GetComponent<Text>().text;
        Debug.Log(playerName);
    }
    


    private static GameManager instance;

    public static GameManager FindInstance()
    {
        return instance;
    }

    private void Awake()
    {
        if(instance != null && instance !=this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }


}
