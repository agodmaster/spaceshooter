using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
    public float speed =5.0f;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        transform.Rotate(1f,1f,1f);
        // deltaTime掛けると1秒間計算
        // 回転時World座標系に
        transform.Translate(0,0,-speed*Time.deltaTime,Space.World);
        if (transform.position.z < -30.0f) {
            Destroy(gameObject);
        }
    }
}
