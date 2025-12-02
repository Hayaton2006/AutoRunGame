using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;

public class PlayerSelector : MonoBehaviour
{
    public static PlayerSelector Instance;
    public PlayerMoveer selectedPlayer;

    private PlayerMoveer[] allPlayers;
    private int currentIndex = 0;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    void Start()
    {
        allPlayers = FindObjectsByType<PlayerMoveer>(FindObjectsSortMode.None);

        // ★ 見た目の位置（transform.position.x）で左から順に並べる ★
        allPlayers = allPlayers
            .OrderBy(p => p.transform.position.x)
            .ToArray();

        // 全部 Unselect
        foreach (var p in allPlayers)
            p.Unselect();

        // 一番左を選択
        if (allPlayers.Length > 0)
        {
            currentIndex = 0;
            selectedPlayer = allPlayers[0];
            selectedPlayer.Select();
        }
    }

    void Update()
    {
        if (Keyboard.current.shiftKey.wasPressedThisFrame)
        {
            currentIndex = (currentIndex + 1) % allPlayers.Length;

            selectedPlayer = allPlayers[currentIndex];

            for (int i = 0; i < allPlayers.Length; i++)
            {
                if (i == currentIndex)
                    allPlayers[i].Select();
                else
                    allPlayers[i].Unselect();
            }

            Debug.Log($"選択中プレイヤー: {selectedPlayer.name}");
        }
    }
}
