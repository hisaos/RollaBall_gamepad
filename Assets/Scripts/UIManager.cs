using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
  // Start is called before the first frame update
  public Text item;
  public Text winText;
  private int numItems;

  public int NumItems
  {
    get
    {
      return numItems;
    }
    set
    {
      numItems = value;
    }
  }

  void Start()
  {
    numItems = GameObject.FindGameObjectsWithTag("Item").Length;
    winText.enabled = false;
  }

  // Update is called once per frame
  void Update()
  {
    item.text = numItems.ToString();
    if (numItems <= 0) winText.enabled = true;
  }
}
