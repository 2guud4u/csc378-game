using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralUI : MonoBehaviour
{
    // Start is called before the first frame update
    public static GeneralUI instance;

    public TMPro.TextMeshProUGUI livesText;
    void Start()
    {
        livesText.text = "Lives: 10";
    }
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateLives(int lives){
        livesText.text = "Lives: " + lives;
    }
}
