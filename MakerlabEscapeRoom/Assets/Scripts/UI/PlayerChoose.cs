using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerChoose : MonoBehaviour
{
    public Button player1,player2;

    // Start is called before the first frame update
    void Start()
    {
        Button btn1= player1.GetComponent<Button>();
        Button btn2= player2.GetComponent<Button>();
        btn1.onClick.AddListener(player1change);
        btn2.onClick.AddListener(player2change);
    }

    void player1change(){
        SceneManager.LoadScene("Ray");
    }

    void player2change(){
        SceneManager.LoadScene("Player2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
