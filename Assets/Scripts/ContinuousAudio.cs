using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousAudio : MonoBehaviour {
    static ContinuousAudio instance = null;
    void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        } 
        else {
            Destroy(transform.gameObject);
        }
    }
}
