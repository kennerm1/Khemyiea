using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum PickupType
{
    Proton,
    Neutron,
    Electron,
    Health,
    HeliumKey,
    Letter
}

public class ItemCollector : MonoBehaviour
{
    //private int items = 0;

    //[SerializeField] public TextMeshProUGUI itemsText;

    public PickupType type;
    public int value;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            if (type == PickupType.Proton)
                player.GiveProton(value);
            else if (type == PickupType.Neutron)
                player.GiveNeutron(value);
            else if (type == PickupType.Electron)
                player.GiveElectron(value);
            else if (type == PickupType.Health)
                player.Heal(value);
            else if (type == PickupType.HeliumKey)
                //Display win screen
                player.WinGame(value);
            else if (type == PickupType.Letter)
                player.UpdateJournal(value);
            Destroy(gameObject);
        }
    }
}