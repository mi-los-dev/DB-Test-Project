using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleViewController : MonoBehaviour
{
    [SerializeField] private VehicleModel[] vehiclesData;
    [SerializeField] private VehicleView vehicleViewPrefab;
    [SerializeField] private Transform placeForSlots;
    private List<GameObject> cache = new();
    
    public void LoadDB()
    {
        ClearView();
        foreach (var v in vehiclesData)
        {
            CreateItemView(v);
        }
    }

    private void ClearView()
    {
        foreach (var slot in cache)
        {
            Destroy(slot);
        }
        cache.Clear();
    }
    
    private void CreateItemView(VehicleModel data)
    {
        var slot = Instantiate(vehicleViewPrefab.gameObject, placeForSlots).GetComponent<VehicleView>();
        cache.Add(slot.gameObject);
        slot.SetData(data.nomination, data.image, data.GetAdditionalInformation());
    }
}
