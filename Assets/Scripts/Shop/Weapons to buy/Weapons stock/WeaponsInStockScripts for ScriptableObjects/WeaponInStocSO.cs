using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "WeaponInStock", menuName = "Store/Weapons Stock/Weapon")]
public class WeaponInStocSO : ScriptableObject
{
    [Header("Weapon")]
    [SerializeField] private GameObject weapon;
    public GameObject Weapon => weapon;

    [Header("ScriptableObject")]
    [SerializeField] private WeaponDataSO weaponData;
    public WeaponDataSO WeaponData => weaponData;

    [Header("Items")]
    [SerializeField] private float price;
    [SerializeField] private Sprite weaponSprite;
    public float Price => price;
    public Sprite WeaponSprite => weaponSprite;
}
