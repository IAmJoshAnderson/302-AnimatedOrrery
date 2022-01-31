using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; //Recognizes Slider Class from Time Demo

public class GUIDemo : MonoBehaviour
{

    public TMP_Text textPlayerHealth;

    public Slider slider;

    public GameObject MainCamera;
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;
    public GameObject camera5;


    // Start is called before the first frame update
    void Start()
    {
        if(slider) slider.value = Time.timeScale;
        MainCamera.SetActive(true);
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
        camera5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BackToMainCamera()
    {
        MainCamera.SetActive(true);
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
        camera5.SetActive(false);
    }

    public void EnableCamera1()
    {
        MainCamera.SetActive(false);
        camera1.SetActive(true);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
        camera5.SetActive(false);
    }

    public void EnableCamera2()
    {
        MainCamera.SetActive(false);
        camera1.SetActive(false);
        camera2.SetActive(true);
        camera3.SetActive(false);
        camera4.SetActive(false);
        camera5.SetActive(false);
    }
    public void EnableCamera3()
    {
        MainCamera.SetActive(false);
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(true);
        camera4.SetActive(false);
        camera5.SetActive(false);
    }
    public void EnableCamera4()
    {
        MainCamera.SetActive(false);
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(true);
        camera5.SetActive(false);
    }
    public void EnableCamera5()
    {
        MainCamera.SetActive(false);
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
        camera5.SetActive(true);
    }
    public void SliderUpdated(float value)
    {
        Time.timeScale = value;

    }


}
