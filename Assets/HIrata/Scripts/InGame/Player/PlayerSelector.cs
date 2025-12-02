using UnityEngine;

public class PlayerSelector : MonoBehaviour
{
    public static PlayerSelector Instance;
    public PlayerMoveer selectedPlayer;

    void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                PlayerMoveer player = hit.collider.GetComponent<PlayerMoveer>();
                if (player != null)
                {
                    selectedPlayer = player;

                    // 修正：Select()/Unselect() を呼ぶ
                    PlayerMoveer[] allPlayers = UnityEngine.Object.FindObjectsByType<PlayerMoveer>(
      FindObjectsSortMode.None
  );

                    foreach (var p in allPlayers)
                    {
                        if (p == selectedPlayer)
                            p.Select();
                        else
                            p.Unselect();
                    }

                    Debug.Log($"選択中プレイヤー: {player.name}");
                }
            }
        }
    }
}
