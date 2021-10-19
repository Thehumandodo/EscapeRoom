using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class toKeypad : MonoBehaviour
{
    public Button keypad;

    // Start is called before the first frame update
    void Start()
    {
        Button btn1 = keypad.GetComponent<Button>();
        btn1.onClick.AddListener(gotoKeypad);
    }

    void gotoKeypad(){
        SceneManager.LoadScene("KeyPad");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
