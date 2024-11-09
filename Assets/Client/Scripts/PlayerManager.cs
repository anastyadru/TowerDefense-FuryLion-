// Copyright (c) 2012-2024 FuryLion Group. All Rights Reserved.

using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerManager : MonoBehaviour
{
    private PlayerBtn playerBtnPressed;
    public int _gold = 100;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null && hit.collider.CompareTag("PlayerSide"))
                {
                    PlacePlayer(hit.point);
                }
            }
        }
        
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null && hit.collider.CompareTag("Player"))
                {
                    RemovePlayer(hit.collider.gameObject);
                }
            }
        }
    }

    public void PlacePlayer(Vector3 position)
    {
        if (!EventSystem.current.IsPointerOverGameObject() && playerBtnPressed != null)
        {
            GameObject newPlayer = Instantiate(playerBtnPressed.PlayerObject);
            newPlayer.transform.position = position;
        }
    }

    public void SelectedPlayer(GameObject playerSelectedObject)
    {
        PlayerBtn playerSelected = playerSelectedObject.GetComponent<PlayerBtn>();
        if (playerSelected != null)
        {
            playerBtnPressed = playerSelected;
            Debug.Log("Pressed" + playerBtnPressed.gameObject);
        }
    }
    
    public void RemovePlayer(GameObject playerToRemove)
    {
        Destroy(playerToRemove);
    }
}