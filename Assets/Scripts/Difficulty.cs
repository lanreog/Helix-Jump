using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        /*gameManager = GameObject.Find("DifficultyMenu").GetComponent<GameManager>();
        difficulyButtons = GetComponent<Button>();
        difficulyButtons.onClick.AddListener(SetDifficulty);*/
    }

    public void SetDifficulty()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Button.FindObjectOfType<GameObject>().SetActive(false);
            Debug.Log("button was clicked");
        }
    }
}
