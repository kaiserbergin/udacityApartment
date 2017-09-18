using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

/// <summary>
/// The TriggerAnimation class activates a transition whenever the Cardboard button is pressed (or the screen touched).
/// </summary>
public class TriggerAnimation : MonoBehaviour , IPointerClickHandler
{
	[Tooltip ("The Animator component on this gameobject")]
	public Animator animator;
	[Tooltip ("The name of the Animator trigger parameter")]
	public string triggerName;

	public void OnPointerClick(PointerEventData e)
	{
        animator.SetTrigger(triggerName);
    }
}
