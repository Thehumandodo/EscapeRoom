using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class keypadBehavior : MonoBehaviour
{

    public Button num1,num2,num3,num4,num5,num6,num7,num8,num9,clrscr;
    string concat;
    public Text textField;

    public void setText(string text){
        textField.text = text;
    }

    // Start is called before the first frame update
    void Start()
    {
        Button btn1 = num1.GetComponent<Button>();
        Button btn2 = num2.GetComponent<Button>();
        Button btn3 = num3.GetComponent<Button>();
        Button btn4 = num4.GetComponent<Button>();
        Button btn5 = num5.GetComponent<Button>();
        Button btn6 = num6.GetComponent<Button>();
        Button btn7 = num7.GetComponent<Button>();
        Button btn8 = num8.GetComponent<Button>();
        Button btn9 = num9.GetComponent<Button>();
        Button btnClr = clrscr.GetComponent<Button>();

        btn1.onClick.AddListener(gotobtn1);
        btn2.onClick.AddListener(gotobtn2);
        btn3.onClick.AddListener(gotobtn3);
        btn4.onClick.AddListener(gotobtn4);
        btn5.onClick.AddListener(gotobtn5);
        btn6.onClick.AddListener(gotobtn6);
        btn7.onClick.AddListener(gotobtn7);
        btn8.onClick.AddListener(gotobtn8);
        btn9.onClick.AddListener(gotobtn9);
        btnClr.onClick.AddListener(gotobtnclr);
    }

    void gotobtn1(){
        concat+="1";
        setText(concat);
    }
    void gotobtn2(){
        concat+="2";
        setText(concat);
    }
    void gotobtn3(){
        concat+="3";
        setText(concat);
    }
    void gotobtn4(){
        concat+="4";
        setText(concat);
    }
    void gotobtn5(){
        concat+="5";
        setText(concat);
    }
    void gotobtn6(){
        concat+="6";
        setText(concat);
    }
    void gotobtn7(){
        concat+="7";
        setText(concat);
    }
    void gotobtn8(){
        concat+="8";
        setText(concat);
    }
    void gotobtn9(){
        concat+="9";
        setText(concat);
    }
    void gotobtnclr(){
        concat="";
        setText("0000");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
