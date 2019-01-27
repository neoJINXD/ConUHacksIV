using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    public SpriteRenderer rink;

	// Use this for initialization
	void Start () {
        Camera.main.orthographicSize = rink.bounds.size.y / 2;
	}
}