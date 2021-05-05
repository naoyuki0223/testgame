using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleInventory : MonoBehaviour
{
  [SerializeField]
  private bool[] itemFlags = new bool[5];
  
  [SerializeField]
  GameObject iconPrefab = null;
  [SerializeField]
  Transform iconParent = null;
  [SerializeField]
  InventoryItem[] items = null;

  // アイテムを持ってるかどうかのフラグ
  bool[] itemFlags;

  // アイテムのアイコンを管理するためのディクショナリ
  Dictionary<int, GameObject> icons = new Dictionary<int, GameObject>();

  void Start()
  {
    itemFlags = new bool[items.Length];
  }

  // アイテムを持ってるかどうかを確認するメソッド
  public bool GetItemFlag(string itemName)
  {
    int index = GetItemIndexFromName(itemName);

    return itemFlags[index];
  }

  public void SetItem(string itemName, bool isOn)
  {
    int index = GetItemIndexFromName(itemName);

    if (!itemFlags[index] && isOn)
    {
      // アイテム未所持の状態で新しく入手したとき
      // 新しいアイコンを生成し、インベントリのキャンバスの子に設定
      GameObject icon = Instantiate(iconPrefab, iconParent);

      // アイコンの画像を設定
      icon.GetComponent<Image>().sprite = items[index].itemSprite;

      icons.Add(index, icon);
    }
    itemFlags[index] = isOn;
  }
}

// インベントリに登録できるアイテムを定義するためのクラス
[System.Serializable]
public class InventoryItem
{

  public string itemName = "";
  public Sprite itemSprite = null;
  
}

//アイテム所持確認メソッド
public bool GetItemFlag(Item item) {
	return itemFlags[(int) item];
}