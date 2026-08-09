using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Hallowmare/Item", order = 1)]
public class ItemDef : ScriptableObject
{
    public string displayName;
    public string id;
    public Sprite icon;
    public int value;
}
