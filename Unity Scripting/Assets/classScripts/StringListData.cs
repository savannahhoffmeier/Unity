 using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class StringListData : ScriptableObject
{
  public List<string> value;
  private int indexer = 0;

  private void OnEnable()
  {
    indexer = 0;
  }

  public void UpdateText(Text txt)
  {
    txt.text = value[indexer];
    indexer = (indexer + 1) % value.Count;
  }
}
