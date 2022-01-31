using UnityEngine;

[CreateAssetMenu(menuName = "Vehicles/Ship")]
public class ShipModel : VehicleModel
{
    public float displacement;

    public override string GetAdditionalInformation()
    {
        return base.GetAdditionalInformation() + $"\nВодоизмещение - {displacement}";
    }
}