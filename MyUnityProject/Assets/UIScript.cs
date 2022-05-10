using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void OnButton1_Click()
  {
    Debug.Log("You have clicked Button1");
  }

  public void OnButton2_Click()
  {
    //Debug.Log("You have clicked Button2");
    SceneManager.LoadScene("MainScene");

  }

  public void OnButton3_Click()
  {
    Debug.Log("You have clicked Button3");
  }
}
