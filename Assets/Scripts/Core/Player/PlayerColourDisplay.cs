using Unity.Collections;
using UnityEngine;

public class PlayerColourDisplay : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private TeamColourLookup teamColourLookup;
    [SerializeField] private TankPlayer player;
    [SerializeField] private SpriteRenderer[] playerSprites;

    public void Start()
    {
        HandleTeamChanged(-1, player.TeamIndex.Value);

        player.TeamIndex.OnValueChanged += HandleTeamChanged;
    }

    private void HandleTeamChanged(int oldTeamIndex, int newTeamIndex)
    {
        Color teamColour = teamColourLookup.GetTeamColour(newTeamIndex);

        foreach (SpriteRenderer sprite in playerSprites)
        {
            sprite.color = teamColour;
        }
    }

    private void OnDestroy()
    {
        player.TeamIndex.OnValueChanged -= HandleTeamChanged;
    }
}
