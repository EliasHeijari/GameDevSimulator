using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public event EventHandler OnCollisionClicked;
    [SerializeField] private SpriteRenderer spriteRenderer;

    private void Start() {
        // Try to get spriteRenderer from child if not setted in editor
        if (spriteRenderer == null)
        {
            transform.GetChild(0).gameObject.TryGetComponent(out SpriteRenderer childSpriteRenderer);
            if (childSpriteRenderer != null){
                spriteRenderer = childSpriteRenderer;
            }
            else if (spriteRenderer == null){
                Debug.LogError("Didnt get spriteRenderer From Child, Make Sure To Set It As index 0 in childs or Set it in editor");
            }
        }
    }

    private void OnMouseDown() {
        OnCollisionClicked?.Invoke(this, EventArgs.Empty);
    }
    private void OnMouseEnter() {
        spriteRenderer.color = GetColorWithNewAlpha(spriteRenderer.color, 0.3f);
    }
    private void OnMouseExit() {
        spriteRenderer.color = GetColorWithNewAlpha(spriteRenderer.color, 1f);
    }

    private Color GetColorWithNewAlpha(Color color, float alpha){
        color.a = alpha;
        return color;
    }
}
