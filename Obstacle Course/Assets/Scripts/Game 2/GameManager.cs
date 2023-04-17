using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager: MonoBehaviour
{
    public int Score = 0;

    public int MaxScore = 5;
    public TextMeshProUGUI TargetText;
    public GameObject WinScreenPanel;

    private void Start() 
    {
        TargetText.text = "Targets Hit: " + Score.ToString();; 
    }
    public void UpdateScore()
    {
        Score++;
        TargetText.text = "Targets Hit: " + Score.ToString();
    }

    public void Update() 
    {
        if(Score >= 5)
        {
            WinScreenPanel.gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }

    
}
