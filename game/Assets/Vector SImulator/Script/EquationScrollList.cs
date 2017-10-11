using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

[System.Serializable]
public class Item
{
	public string equation;
	public float num = 1f;
}

public class EquationScrollList : MonoBehaviour {
	public List<Item> itemList;
	public Transform contentPanel;
	public EquationScrollList otherList;
	public Text numEquationDisplay;
	public SimpleObjectPool buttonObjectPool;
	public float numEqu = 0f;

	// Use this for initialization
	void Start () {
		RefreshDisplay ();
	}
	
	public void RefreshDisplay() {
		AddButtons ();
	}

	private void AddButtons(){
		for (int i = 0; i < itemList.Count; i++) {
			Item item = itemList [i];
			GameObject newButton = buttonObjectPool.GetObject ();   //details can be seen in the pool code.
			newButton.transform.SetParent(contentPanel);

			sampleButton sampleButton = newButton.GetComponent<sampleButton> ();
			sampleButton.Setup (item, this);

		}
	}
}
