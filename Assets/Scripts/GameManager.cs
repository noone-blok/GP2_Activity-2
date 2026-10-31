using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class GameManager : MonoBehaviour
{
    private List<string> activeEnemies = new List<string>();
    [SerializeField] private TextMeshProUGUI listText;

    public void SpawnWave()
    {
        activeEnemies.Add("Regular Enemy");
        activeEnemies.Add("Ice Enemy");
        activeEnemies.Add("Fire Enemy");
        activeEnemies.Add("Dog");
        activeEnemies.Add("Shadow Enemy");

        UpdateUI();
    }

    public void SpawnEnemy(string enemyName) 
    {
        activeEnemies.Add(enemyName);
        UpdateUI();
    }

    public void RemoveEnemy(string enemyName) 
    {
        if (activeEnemies.Remove(enemyName))
        {
            Debug.Log($"Removed {enemyName}");
        }
        else
        {
            Debug.LogWarning($"Couldn't Find {enemyName}");
        }

        UpdateUI();
    }

    public void WipeWave()
    {
        activeEnemies.Clear();

        UpdateUI();
    }

    private void UpdateUI()
    {
        listText.text = "Enemy List : \n";

        for (int i = 0; i < activeEnemies.Count; i++)
        {
            listText.text += $"{activeEnemies[i]}\n";
        }
    }
}
