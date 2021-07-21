using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    Vector3 circlePosition;

    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position);
        circlePosition = this.transform.position;
        GetComponent<Button>().onClick.AddListener(Click);
    }

    private void Update() {
        transform.eulerAngles = new Vector3(0,0, ball.transform.eulerAngles.z);
    }

    void Click(){
        Debug.Log("Click event occur.");
        Vector3 expos = Input.mousePosition;
        Vector3 npos = Camera.main.ScreenToWorldPoint(expos);
        Vector3 fpos = new Vector3(npos.x, npos.y);
        Debug.Log(fpos - circlePosition);
        ball.GetComponent<Rigidbody2D>().AddForce(-(fpos-circlePosition)*550);
 
    }
         

}
