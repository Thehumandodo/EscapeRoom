using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public Button backButton;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Button btn = backButton.GetComponent<Button>();
        btn.onClick.AddListener(clicked);
    }

    void clicked(){
        SceneManager.LoadScene("Player1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
