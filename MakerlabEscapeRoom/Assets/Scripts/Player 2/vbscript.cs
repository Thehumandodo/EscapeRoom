using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class vbscript : MonoBehaviour
{

    public GameObject message;
    public VirtualButtonBehaviour Green, Red, Yellow;
    // Start is called before the first frame update

    
    string toastString;
    AndroidJavaObject currentActivity;

    public void MyShowToastMethod(string stringing){
        showToastOnUiThread(stringing);
    }

    void showToastOnUiThread(string toastString){
        AndroidJavaClass UnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        currentActivity = UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

        this.toastString = toastString;
        currentActivity.Call("runOnUiThread", new AndroidJavaRunnable (showToast));
    }

    void showToast(){
        AndroidJavaObject context = currentActivity.Call<AndroidJavaObject>("getApplicationContext");
        AndroidJavaClass Toast = new AndroidJavaClass("android.widget.Toast");

        AndroidJavaObject javaString = new AndroidJavaObject("java.lang.String", toastString);
        AndroidJavaObject toast = Toast.CallStatic<AndroidJavaObject> ("makeText", context, javaString, Toast.GetStatic<int>("LENGTH_SHORT"));

        toast.Call("show");
    }

    void Start()
    {
        message.SetActive(false);
        Green.RegisterOnButtonPressed(onButtonPressedGreen);
        Green.RegisterOnButtonReleased(onButtonReleased);
        Red.RegisterOnButtonPressed(onButtonPressedRed);
        Yellow.RegisterOnButtonPressed(onButtonPressedYellow);
    }

    public void onButtonPressedGreen(VirtualButtonBehaviour green){
        MyShowToastMethod("Green Pressed");
    }

    public void onButtonPressedRed(VirtualButtonBehaviour red){
        MyShowToastMethod("red Pressed");
    }

    public void onButtonPressedYellow(VirtualButtonBehaviour yellow){
        MyShowToastMethod("Yellow Pressed");
    }

    public void onButtonReleased(VirtualButtonBehaviour green){
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
