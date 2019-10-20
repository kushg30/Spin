using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Battery : MonoBehaviour
{
    public GameObject battery;
    public GameObject motor;
    public UnityEvent OnClick = new UnityEvent();
    int check = 0;
    // Start is called before the first frame update
    void Start()
    {
        battery = this.gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit Hit;

        if (Input.GetMouseButtonDown(0))
            check = 1;
        if(check==1)
        {
            if(Physics.Raycast(ray, out Hit) && Hit.collider.gameObject==gameObject)
            {
                motor.transform.Rotate(Vector3.up, 700 * Time.deltaTime);
                OnClick.Invoke();
            }
        }
    }
}
