using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class sampleButton : MonoBehaviour {
	public Button button;
	public Text delete;
	public Text info;

	private Item item;
	private EquationScrollList scrollList;
	// Use this for initialization
	void Start () {
		
	}


	public void Setup(Item currentItem, EquationScrollList currentScrollList) {
		item = currentItem;
		info.text = item.equation;
		delete.text = item.num.ToString ();

		scrollList = currentScrollList;
	}
}
