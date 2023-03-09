using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float speed = 2;
    public Button Start_btn;

    // Start is called before the first frame update
    void Start()
    {
        Start_btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void TaskOnClick()
    {
        // Output this to console when the Button is clicked
        Debug.Log("You have clicked the button!");
        // Start Movement of Cubes
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

}