using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class line : MonoBehaviour {

	public Vector3 start = new Vector3(0, 0, 0);
	public Vector3 end = new Vector3(1, 1, 1);
	public InputField x;
	public InputField y;
	public InputField z;
	public InputField a;
	public InputField b;
	public InputField c;

	public Button btn;
	// Use this for initialization
	void Start () {
		Button draw = btn.GetComponent<Button> ();
		draw.onClick.AddListener (display);
	}

	// Update is called once per frame
	void Update () {
		
	}



	void display() {
		setPosition ();
		GameObject myLine = new GameObject();
		myLine.transform.position = start;
		myLine.AddComponent<LineRenderer>();
		LineRenderer lr = myLine.GetComponent<LineRenderer>();
		lr.SetWidth(0.01f, 0.01f);
		lr.SetPosition(0, start);
		lr.SetPosition(1, end);
		//lr.material = new Material (Shader.Find("Particles/Additive"));

		lr.startColor = Color.black; 
		lr.endColor = Color.black;

	}

	//turn the text into float
	void setPosition() {
		float xPos = float.Parse (x.text);
		float yPos = float.Parse (y.text);
		float zPos = float.Parse (z.text);
		start = new Vector3 (xPos, yPos, zPos);

		float aPos = float.Parse (a.text);
		float bPos = float.Parse (b.text);
		float cPos = float.Parse (c.text);
		end = new Vector3 (aPos, bPos, cPos);

		end = (start + end) * 10;
	}

	/*
	void DrawLine(Vector3 start, Vector3 end, float duration = 0.2f)
	{
		GameObject myLine = new GameObject();
		myLine.transform.position = start;
		myLine.AddComponent<LineRenderer>();
		LineRenderer lr = myLine.GetComponent<LineRenderer>();
		lr.SetWidth(0.01f, 0.01f);
		lr.SetPosition(0, start);
		lr.SetPosition(1, end);

	}*/


}


